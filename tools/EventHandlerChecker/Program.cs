using R3Extends4WinForms;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using R3;

Console.WriteLine("Event Handler Checker");
Console.WriteLine("================================");

var projectRoot = new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent?.Parent?.FullName;
if (projectRoot == null)
{
    Console.WriteLine("Error: Could not determine the project root directory.");
    return;
}

var winFormsEvents = GetWinFormsEventDefs();
var componentEvents = GetComponentEventDefs();
var implEvents = GetR3Ex4WinFormsEventDefs();

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

var reportPath = 
    Path.Combine(
        projectRoot,
        "tools",
        "EventHandlerChecker",
        $"HandlerTypeReport{tgtName}.md");

GenerateReport(winFormsEvents, componentEvents, implEvents, reportPath);

Console.WriteLine($"Analysis complete.");
Console.WriteLine($"Report generated at: {reportPath}");


static Dictionary<string, EventDef> GetWinFormsEventDefs()
{
    var defs = new Dictionary<string, EventDef>();
    var winFormsAssembly = typeof(Control).Assembly;

    // We only care about types that are likely to have extensions
    // Filter to System.Windows.Forms namespace and Public types
    var winFormsTypes =
        winFormsAssembly
        .GetTypes()
        .Where(t => t.IsPublic && t.Namespace == "System.Windows.Forms");

    foreach (var type in winFormsTypes)
    {
        // Get both instance and static events to support classes like Application
        var events = type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
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

            var key = $"{type.Name}/{ev.Name}";
            // Timer is special case often in these checks, but strictly speaking it's System.Windows.Forms.Timer
            if (type.Name == "Timer") key = "System.Windows.Forms.Timer/" + ev.Name;

            defs[key] = new EventDef(handlerType, argsType);
        }
    }

    return defs;
}

static Dictionary<string, EventDef> GetComponentEventDefs()
{
    var defs = new Dictionary<string, EventDef>();
    var componentType = typeof(System.ComponentModel.Component);
    var disposedEvent = componentType.GetEvent("Disposed");
    if (disposedEvent != null)
    {
        var handlerType = disposedEvent.EventHandlerType;
        if (handlerType != null)
        {
            var invokeMethod = handlerType.GetMethod("Invoke");
            if (invokeMethod != null)
            {
                var parameters = invokeMethod.GetParameters();
                if (parameters.Length == 2)
                {
                    var argsType = parameters[1].ParameterType;
                    var key = "System.ComponentModel.Component/Disposed";
                    defs[key] = new EventDef(handlerType, argsType);
                }
            }
        }
    }
    return defs;
}


static Dictionary<string, ImplementationDef> GetR3Ex4WinFormsEventDefs()
{
    var defs = new Dictionary<string, ImplementationDef>();
    var assembly = typeof(ApplicationR3Extends).Assembly;

    // We only care about types that are likely to have extensions
    // Filter to System.Windows.Forms namespace and Public types
    var types =
        assembly
        .GetTypes()
        .Where(t => t.IsPublic);

    foreach (var type in types)
    {
        Debug.Print($"Checking type: {type.Name}");
        // Get both instance and static events to support classes like Application
        var methods =
            type
            .GetMethods(
                BindingFlags.Public | 
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly);
        foreach (var mt in methods)
        {
            Debug.Print($"Checking method: {mt.Name}, ret:{mt.ReturnType.GetGenericTypeDefinition()}, args:{mt.GetParameters()}");

            var impTypeName = 
                mt.DeclaringType!.Name.Replace("R3Extends", "");
            var impEventName = 
                mt.Name.Replace("AsObservable", "");
            var retType = 
                mt.ReturnType.GetGenericArguments();
            if (impTypeName == "Timer")
            {
                impTypeName = "System.Windows.Forms.Timer";
            }
            else if (impTypeName == "Component")
            {
                impTypeName = "System.ComponentModel.Component";
            }

            defs.Add(
                $"{impTypeName}/{impEventName}",
                new ImplementationDef(
                    impTypeName,
                    impEventName,
                    retType[0]  // Observable<T> -> T
                )
            );
        }
    }
    return defs;
}

static string GetFriendlyTypeNameString(Type type)
{
    if (type.IsGenericType)
    {
        // ジェネリック型の場合
        // 型定義名を取得し、後ろの `N を削除する
        var genericArgs = type.GetGenericArguments();
        var builder = new StringBuilder();

        builder
            .Append(type.Name.Substring(0, type.Name.IndexOf('`')))
            .Append('<');

        // 各ジェネリック引数に対しても再帰的にこのメソッドを適用する
        builder.Append(string.Join(", ",
            genericArgs
            .Select((ga) => GetFriendlyTypeNameString(ga))))
            .Append('>');

        return builder.ToString();
    }
    else
    {
        // 非ジェネリック型の場合
        // そのままの名前を返す
        return type.Name;
    }
}

static void GenerateReport(
    Dictionary<string, EventDef> winFormsDefinitions,
    Dictionary<string, EventDef> componentsDefinitions,
    Dictionary<string, ImplementationDef> implementations,
    string path)
{
    var report = new StringBuilder();
    var tableRows = new StringBuilder(); // Main table content
    var componentRows = new StringBuilder(); // Component events table content
    var missingRows = new StringBuilder(); // Missing items table content

    // Header logic calculation
    int totalImplementations = implementations.Count;
    int checkedCount = 0;
    int successCount = 0;
    int errorCount = 0;
    int missingCount = 0;

    // Group implementations by Type/Event
    foreach (var impl in implementations.Values)
    {
        var key = $"{impl.TypeName}/{impl.EventName}";

        if (winFormsDefinitions.TryGetValue(key, out var def))
        {
            checkedCount++;

            // Allow loose matching (e.g. valid namespace qualifications)
            // But usually we just want simplified name matching

            if (IsMatch(def.ArgsType, impl.ReturnType))
            {
                successCount++;
                // Correct
                var typeUrl = GetLearnUrl(impl.TypeName);
                var eventUrl = GetLearnUrl(impl.TypeName, impl.EventName);
                tableRows.AppendLine($"| ✅ | [{impl.TypeName}]({typeUrl}) | [{impl.EventName}]({eventUrl}) | {def.ArgsType} | {impl.ReturnType} |");
            }
            else
            {
                errorCount++;
                var typeUrl = GetLearnUrl(impl.TypeName);
                var eventUrl = GetLearnUrl(impl.TypeName, impl.EventName);
                tableRows.AppendLine($"| ❌ | [{impl.TypeName}]({typeUrl}) | [{impl.EventName}]({eventUrl}) | **{def.ArgsType}** | `{impl.ReturnType}` |");
            }
        }
        else if (componentsDefinitions.TryGetValue(key, out var cDef))
        {
            checkedCount++;
            if (IsMatch(cDef.ArgsType, impl.ReturnType))
            {
                successCount++;
                // Correct
                var typeUrl = GetLearnUrl(impl.TypeName);
                var eventUrl = GetLearnUrl(impl.TypeName, impl.EventName);
                componentRows.AppendLine($"| ✅ | [{impl.TypeName}]({typeUrl}) | [{impl.EventName}]({eventUrl}) | {cDef.ArgsType} | {impl.ReturnType} |");
            }
            else
            {
                errorCount++;
                var typeUrl = GetLearnUrl(impl.TypeName);
                var eventUrl = GetLearnUrl(impl.TypeName, impl.EventName);
                componentRows.AppendLine($"| ❌ | [{impl.TypeName}]({typeUrl}) | [{impl.EventName}]({eventUrl}) | **{def.ArgsType}** | `{impl.ReturnType}` |");
            }
        }
        else
        {
            missingCount++;
            // Implementation exists but event not found in WinForms.
            // These are stored in a separate table.
            var typeUrl = GetLearnUrl(impl.TypeName);
            var eventUrl = GetLearnUrl(impl.TypeName, impl.EventName);
            missingRows.AppendLine($"| ⚠️ | [{impl.TypeName}]({typeUrl}) | [{impl.EventName}]({eventUrl}) | N/A | `{impl.ReturnType}` |");
        }
    }

    report.AppendLine("# Event Handler & Argument Type Check Report")
        .AppendLine($"Generated on {DateTime.UtcNow:u}")
        .AppendLine();

    // Summary Table
    report.AppendLine("## Summary")
        .AppendLine("| Category | Count |")
        .AppendLine("|---|---:|")
        .AppendLine($"| Total Implementations | {totalImplementations} |")
        .AppendLine($"| Checked (Found in WinForms, Components) | {checkedCount} |")
        .AppendLine($"| Correct (✅) | {successCount} |")
        .AppendLine($"| Incorrect (❌) | {errorCount} |")
        .AppendLine($"| Missing/Ignored (⚠️) | {missingCount} |")
        .AppendLine();

    // Details Table(System.Windows.Forms)
    report.AppendLine("## Details(System.Windows.Forms)")
        .AppendLine("| Status | Class | Event | Expected Args | Actual Args |")
        .AppendLine("|:---:|---|---|---|---|")
        .Append(tableRows);

    // Details Table(System.ComponentModel)
    report.AppendLine("## Details(System.ComponentModel)")
        .AppendLine("| Status | Class | Event | Expected Args | Actual Args |")
        .AppendLine("|:---:|---|---|---|---|")
        .Append(componentRows);


    // Missing Items Table (if any)
    if (missingCount > 0)
    {
        report.AppendLine();
        report.AppendLine("## Ignored Events (Not found in System.Windows.Forms)")
            .AppendLine("> These events exist in the implementation but could not be found in the `System.Windows.Forms` assembly via reflection. They might be from other assemblies (e.g. `System.ComponentModel`) or are obscured.")
            .AppendLine();
        report.AppendLine("| Status | Class | Event | Expected Args | Actual Args |")
            .AppendLine("|:---:|---|---|---|---|")
            .Append(missingRows);
    }

    File.WriteAllText(path, report.ToString());
}


static bool IsMatch(Type expected, Type actual)
{
    return expected.Equals(actual);
}

static string GetLearnUrl(string typeName, string? eventName = null)
{
    var baseUrl = "https://learn.microsoft.com/dotnet/api/";

    // In EventHandlerChecker, typeName comes from the file name minus "R3Extends", or "System.Windows.Forms.Timer".
    // Or from WinForms reflection which is just "Button", "Timer" etc.

    // We need to ensure we have the full namespace for the URL unless it's already there (rarely for controls except Timer)
    var fullTypeName =
        typeName.Contains('.') ?
        typeName : $"System.Windows.Forms.{typeName}";

    var url = $"{baseUrl}{fullTypeName.ToLower()}";

    if (!string.IsNullOrEmpty(eventName))
    {
        url += $".{eventName!.ToLower()}";
    }

    return url;
}

record EventDef(
    Type HandlerType,
    Type ArgsType);

record ImplementationDef(
    string TypeName,
    string EventName,
    Type ReturnType);

