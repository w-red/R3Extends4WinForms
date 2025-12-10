using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("Event Handler & Argument Checker");
Console.WriteLine("================================");

var projectRoot = new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent?.Parent?.FullName;
if (projectRoot == null)
{
    Console.WriteLine("Error: Could not determine the project root directory.");
    return;
}

var winFormsEvents = GetWinFormsEventDefs();
var srcPath = Path.Combine(projectRoot, "src");
var implementations = GetOrParseImplementations(srcPath);

var tgtName = "";
#if NET10_0_OR_GREATER
    tgtName = "NET10";
#elif NET8_0_OR_GREATER
    tgtName = "NET8";
#elif NET6_0_OR_GREATER
    tgtName = "NET6";
#elif NET472_OR_GREATER
    tgtName = "472";
#endif

var reportPath = Path.Combine(projectRoot, "tools", "EventHandlerChecker", $"HandlerTypeReport{tgtName}.md");

GenerateReport(winFormsEvents, implementations, reportPath);

Console.WriteLine($"Analysis complete.");
Console.WriteLine($"Report generated at: {reportPath}");

static Dictionary<string, EventDef> GetWinFormsEventDefs()
{
    var defs = new Dictionary<string, EventDef>();
    var assembly = typeof(Control).Assembly; 

    // We only care about types that are likely to have extensions
    // Filter to System.Windows.Forms namespace and Public types
    var types = 
        assembly
        .GetTypes()
        .Where(t => t.IsPublic && t.Namespace == "System.Windows.Forms");

    foreach (var type in types)
    {
        // Removed DeclaredOnly to find inherited events regarding the specific control type
        var events = type.GetEvents(BindingFlags.Public | BindingFlags.Instance);
        foreach (var ev in events)
        {

            var handlerType = ev.EventHandlerType;
            if (handlerType == null) continue;

            var invokeMethod = handlerType.GetMethod("Invoke");
            if (invokeMethod == null) continue;

            var parameters = invokeMethod.GetParameters();
            if (parameters.Length != 2) continue; // Non-standard event pattern

            // parameters[1] is 'e' (EventArgs)
            var argsType = parameters[1].ParameterType;

            var key = $"{GetCleanTypeName(type.Name)}/{ev.Name}";
            // Timer is special case often in these checks, but strictly speaking it's System.Windows.Forms.Timer
            if (type.Name == "Timer") key = "System.Windows.Forms.Timer/" + ev.Name;

            defs[key] = new EventDef(handlerType.Name, argsType.Name);
        }
    }
    return defs;
}

static List<ImplementationDef> GetOrParseImplementations(string srcPath)
{
    var list = new List<ImplementationDef>();
    
    // Regex explanation:
    // Capture Return Type: public Observable<(.+)>
    // Capture Event Name:  MethodNameAsObservable
    // Capture Handler type in FromEvent: FromEvent<Handler,
    // Capture Args type in FromEvent: FromEvent<Handler, Args>
    // Note: We need to handle multi-line and spacing flexibilities.
    
    var methodPattern = new Regex(
        @"public\s+Observable<(?<RetT>.+?)>\s+(?<Name>\w+)AsObservable[\s\S]*?Observable\.FromEvent\s*<\s*(?<HandlerT>.+?),\s*(?<ArgsT>.+?)\s*>",
        RegexOptions.Compiled | RegexOptions.Multiline);

    var files = Directory.EnumerateFiles(srcPath, "*R3Extends.cs", SearchOption.TopDirectoryOnly);

    foreach (var file in files)
    {
        var typeName = Path.GetFileNameWithoutExtension(file).Replace("R3Extends", "");
        if (typeName == "Timer") typeName = "System.Windows.Forms.Timer";

        var content = File.ReadAllText(file);
        
        var matches = methodPattern.Matches(content);
        foreach (Match match in matches)
        {
            list.Add(new ImplementationDef(
                typeName,
                match.Groups["Name"].Value,
                match.Groups["RetT"].Value.Trim(),
                match.Groups["HandlerT"].Value.Trim(),
                match.Groups["ArgsT"].Value.Trim()
            ));
        }
    }

    return list;
}

static void GenerateReport(Dictionary<string, EventDef> definitions, List<ImplementationDef> implementations, string path)
{
    var report = new StringBuilder();
    var tableRows = new StringBuilder(); // Main table content
    var missingRows = new StringBuilder(); // Missing items table content

    // Header logic calculation
    int totalImplementations = implementations.Count;
    int checkedCount = 0;
    int successCount = 0;
    int errorCount = 0;
    int missingCount = 0;

    // Group implementations by Type/Event
    foreach (var impl in implementations)
    {
        var key = $"{impl.TypeName}/{impl.EventName}";
        
        if (definitions.TryGetValue(key, out var def))
        {
            checkedCount++;
            
            // Allow loose matching (e.g. valid namespace qualifications)
            // But usually we just want simplified name matching
            
            bool safeHandler = IsMatch(def.HandlerType, impl.HandlerType);
            bool safeArgs = IsMatch(def.ArgsType, impl.ArgsType);
            bool safeRet = IsMatch(def.ArgsType, impl.ReturnType);

            if (safeHandler && safeArgs && safeRet)
            {
                successCount++;
                // Correct
                tableRows.AppendLine($"| ✅ | {impl.TypeName} | {impl.EventName} | {def.HandlerType} | {impl.HandlerType} | {def.ArgsType} | {impl.ArgsType} | {impl.ReturnType} |");
            }
            else
            {
                errorCount++;
                tableRows.AppendLine($"| ❌ | {impl.TypeName} | {impl.EventName} | **{def.HandlerType}** | `{impl.HandlerType}` | **{def.ArgsType}** | `{impl.ArgsType}` | `{impl.ReturnType}` |");
            }
        }
        else
        {
             missingCount++;
             // Implementation exists but event not found in WinForms.
             // These are stored in a separate table.
             missingRows.AppendLine($"| ⚠️ | {impl.TypeName} | {impl.EventName} | N/A | `{impl.HandlerType}` | N/A | `{impl.ArgsType}` | `{impl.ReturnType}` |");
        }
    }

    report.AppendLine("# Event Handler & Argument Type Check Report");
    report.AppendLine($"Generated on {DateTime.UtcNow:u}");
    report.AppendLine();
    
    // Summary Table
    report.AppendLine("## Summary");
    report.AppendLine("| Category | Count |");
    report.AppendLine("|---|---:|");
    report.AppendLine($"| Total Implementations | {totalImplementations} |");
    report.AppendLine($"| Checked (Found in WinForms) | {checkedCount} |");
    report.AppendLine($"| Correct (✅) | {successCount} |");
    report.AppendLine($"| Incorrect (❌) | {errorCount} |");
    report.AppendLine($"| Missing/Ignored (⚠️) | {missingCount} |");
    report.AppendLine();

    // Details Table
    report.AppendLine("## Details");
    report.AppendLine("| Status | Class | Event | Expected Handler | Actual Handler | Expected Args | Actual Args | Ret Type |");
    report.AppendLine("|:---:|---|---|---|---|---|---|---|");
    report.Append(tableRows.ToString());

    // Missing Items Table (if any)
    if (missingCount > 0)
    {
        report.AppendLine();
        report.AppendLine("## Ignored Events (Not found in System.Windows.Forms)");
        report.AppendLine("> These events exist in the implementation but could not be found in the `System.Windows.Forms` assembly via reflection. They might be from other assemblies (e.g. `System.ComponentModel`) or are obscured.");
        report.AppendLine();
        report.AppendLine("| Status | Class | Event | Expected Handler | Actual Handler | Expected Args | Actual Args | Ret Type |");
        report.AppendLine("|:---:|---|---|---|---|---|---|---|");
        report.Append(missingRows.ToString());
    }
    
    File.WriteAllText(path, report.ToString());
}

static bool IsMatch(string expected, string actual)
{
    // Handle generics notation from Reflection (e.g. EventHandler`1)
    if (expected.Contains("`"))
    {
        expected = expected.Substring(0, expected.IndexOf("`"));
    }

    // Standardize actual to remove generics part for comparison if needed, 
    // BUT we want to be correct. 
    // If expected is "EventHandler", acts matches "EventHandler<T>" -> this is debatable.
    // However, WinForms uses EventHandler<T> for EventHandler`1.
    
    // If exact match
    if (actual == expected) return true;
    
    // If actual is fully qualified
    if (actual.EndsWith("." + expected)) return true;

    // If expected was generic (stripped `1), check if actual starts with it + <
    if (actual.StartsWith(expected + "<") || actual.EndsWith("." + expected + "<")) return true;

    return false;
}

static string GetCleanTypeName(string name)
{
    // Generic cleanup if needed, but WinForms controls are usually non-generic
    return name;
}

record EventDef(string HandlerType, string ArgsType);
record ImplementationDef(string TypeName, string EventName, string ReturnType, string HandlerType, string ArgsType);
