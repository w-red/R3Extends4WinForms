using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;
using System.Reflection;
using System.Text;

Console.WriteLine("Event Coverage Checker");
Console.WriteLine("======================");

var projectRoot = new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent?.Parent?.FullName;
if (projectRoot == null)
{
    Console.WriteLine("Error: Could not determine the project root directory.");
    return;
}

// Determine preprocessor symbols based on target framework
var preprocessorSymbols = new List<string>();
var tgtName = "";

#if NET10_0_OR_GREATER
    tgtName = "NET10";
    preprocessorSymbols.AddRange([ 
        "NET10_0", "NET10_0_OR_GREATER", 
        "NET9_0_OR_GREATER", 
        "NET8_0_OR_GREATER", 
        "NET7_0_OR_GREATER", 
        "NET6_0_OR_GREATER", 
        "NET5_0_OR_GREATER", 
        "NETCOREAPP", "NETCOREAPP3_1_OR_GREATER" 
    ]);
#elif NET8_0_OR_GREATER
    tgtName = "NET8";
    preprocessorSymbols.AddRange([
        "NET8_0", "NET8_0_OR_GREATER", 
        "NET7_0_OR_GREATER", 
        "NET6_0_OR_GREATER", 
        "NET5_0_OR_GREATER", 
        "NETCOREAPP", "NETCOREAPP3_1_OR_GREATER" 
    ]);
#elif NET6_0_OR_GREATER
    tgtName = "NET6";
    preprocessorSymbols.AddRange([
        "NET6_0", "NET6_0_OR_GREATER", 
        "NET5_0_OR_GREATER", 
        "NETCOREAPP", "NETCOREAPP3_1_OR_GREATER" 
    ]);
#elif NET472_OR_GREATER || NET472 || NET462_OR_GREATER || NETFRAMEWORK
    tgtName = "472";
    preprocessorSymbols.AddRange([
        "NET472", "NET472_OR_GREATER", 
        "NET471_OR_GREATER", 
        "NET47_OR_GREATER", 
        "NET462_OR_GREATER", 
        "NET461_OR_GREATER", 
        "NET46_OR_GREATER", 
        "NET452_OR_GREATER", 
        "NET451_OR_GREATER", 
        "NET45_OR_GREATER", 
        "NET40_OR_GREATER", 
        "NET35_OR_GREATER", 
        "NET20_OR_GREATER", 
        "NETFRAMEWORK" 
    ]);
#else
    tgtName = "Unknown";
#endif

// Can be passed as args or detected
Console.WriteLine($"Running for Target: {tgtName}");
Console.WriteLine($"Symbols: {string.Join(", ", preprocessorSymbols)}");

// List of types to be treated as legacy/compatibility
var ignoredTypes = new HashSet<string>
{
    "DataGrid",
    "DataGridBoolColumn",
    "DataGridColumnStyle",
    "DataGridTableStyle",
    "DataGridTextBox",
    "GridColumnStylesCollection",
    "GridTableStylesCollection",
    "MainMenu",
    "MenuItem",
    "ContextMenu",
    "StatusBar",
    "ToolBar"
};

// For .NET Framework 4.7.2, these types are not legacy
if (tgtName == "472")
{
    ignoredTypes.Clear();
}

// ... (in Main) ...
var winFormsEvents = GetWinFormsEvents().ToHashSet(); // Get all events
var componentsEvents = GetComponetEvents().ToHashSet();
var activeEvents = winFormsEvents
    .Where(e => !ignoredTypes.Contains(e.Split('/')[0])).ToHashSet();

var implementedExtensions =
    GetImplementedObservableExtensions(
        Path.Combine(projectRoot, "src"), preprocessorSymbols);

var reportPath = 
    Path
    .Combine(
        projectRoot,
        "tools",
        "EventCoverageChecker",
        $"CoverageReport{tgtName}.md");

GenerateReport(
    winFormsEvents,
    componentsEvents,
    implementedExtensions,
    ignoredTypes,
    reportPath);

var missingCount = activeEvents.Except(implementedExtensions).Count();
Console.WriteLine($"Analysis complete. Found {missingCount} missing events (excluding legacy types).");
Console.WriteLine($"Report generated at: {reportPath}");

// ...

static void GenerateReport(
    HashSet<string> winFormsEvents,
    HashSet<string> componentEvents,
    HashSet<string> implementedEvents,
    HashSet<string> ignoredTypes,
    string path)
{
    var report = new StringBuilder();
#if true
    var wholeEvents = 
        winFormsEvents
        .Union(componentEvents)
        .ToHashSet();
    var activeEvents = wholeEvents
        .Where(e => !ignoredTypes.Contains(e.Split('/')[0]))
        .ToHashSet();
    var ignoredEvents = wholeEvents
        .Where(e => ignoredTypes.Contains(e.Split('/')[0]))
        .ToHashSet();
#else
    var activeEvents = winFormsEvents
        .Where(e => !ignoredTypes.Contains(e.Split('/')[0]))
        .ToHashSet();
    var ignoredEvents = winFormsEvents
        .Where(e => ignoredTypes.Contains(e.Split('/')[0]))
        .ToHashSet();

    var missingEvents = 
        activeEvents
        .Except(implementedEvents)
        .ToHashSet();
#endif

    var missingEvents =
        activeEvents
        .Except(implementedEvents)
        .ToHashSet();

    report.AppendLine("# Event Coverage Report")
        .AppendLine()
        .AppendLine($"*Generated on {DateTime.UtcNow:u}*")
        .AppendLine()
        .AppendLine($"*Target Framework {AppContext.TargetFrameworkName}*")
        .AppendLine();

    // Summary Table
    report.AppendLine("## Summary");
    report.AppendLine("| Category | Count |")
        .AppendLine("|---|---:|")
        .AppendLine($"| Total Active Events (Found in WinForms and Component) | {activeEvents.Count} |")
        .AppendLine($"| Implemented (✅) | {activeEvents.Intersect(implementedEvents).Count()} |")
        .AppendLine($"| Missing (❌) | {missingEvents.Count} |")
        .AppendLine($"| Ignored (⚠️) | {ignoredEvents.Count} |")
        .AppendLine();

    if (activeEvents.Count == 0)
    {
        report.AppendLine("No browsable events found to check.");
        File.WriteAllText(path, report.ToString());
        return;
    }
    
    // Main Section: Active Components
    var groupedByClass = 
        activeEvents
        .Select(e =>
        {
            var parts = e.Split('/');
            return new { TypeName = parts[0], EventName = parts[1] };
        })
        .GroupBy(e => e.TypeName)
        .OrderBy(g => g.Key);

    report.AppendLine("## Coverage Details by Class");
    report.AppendLine();

    foreach (var group in groupedByClass)
    {
        var typeName = group.Key;
        var events = 
            group
            .OrderBy(e => e.EventName)
            .ToList();
        
        var implementedCount =
            events
            .Count(
                e => 
                    implementedEvents
                    .Contains($"{typeName}/{e.EventName}"));
        var coverage = 
            events.Count == 0 ?
            (double)implementedCount / events.Count : 0;
        
        var typeUrl = GetLearnUrl(typeName);
        report.AppendLine($"### [`{typeName}`]({typeUrl})")
            .AppendLine($"**Coverage: {coverage:P0}** ({implementedCount} / {events.Count})")
            .AppendLine();
        report.AppendLine("| Status | Event Name |")
            .AppendLine("|:------:|------------|");

        foreach (var ev in events)
        {
            var isImplemented = 
                implementedEvents
                .Contains($"{typeName}/{ev.EventName}");
            var statusIcon =
                isImplemented ? "✅" : "❌";
            var eventUrl =
                GetLearnUrl(typeName, ev.EventName);
            report
                .AppendLine($"| {statusIcon} | [{ev.EventName}]({eventUrl}) |");
        }
        report.AppendLine();
    }

    // Secondary Section: Legacy Components
    if (ignoredEvents.Count > 0)
    {
        report.AppendLine("## Ignored / Legacy Components")
            .AppendLine("These components are deprecated or present only for compatibility. They are excluded from the main coverage statistics.")
            .AppendLine();

        var ignoredGrouped = 
            ignoredEvents
            .Select(e =>
            {
                var parts = e.Split('/');
                return new { TypeName = parts[0], EventName = parts[1] };
            })
            .GroupBy(e => e.TypeName)
            .OrderBy(g => g.Key);
        
        foreach (var group in ignoredGrouped)
        {
             var typeName = group.Key;
             var events = 
                group
                .OrderBy(e => e.EventName)
                .ToList();
             
             // Check if somehow implemented (unlikely but good to show)
             var implementedCount = events
                .Count(
                    e => implementedEvents
                        .Contains($"{typeName}/{e.EventName}"));
             
             var typeUrl = GetLearnUrl(typeName);
             report.AppendLine($"### [`{typeName}`]({typeUrl}) (Legacy)");
             if (implementedCount > 0)
             {
                 report.AppendLine($"**Implemented:** {implementedCount} / {events.Count}");
             }
             else
             {
                 report.AppendLine("**Implemented:** 0 (Expected)");
             }
             report.AppendLine();
             report.AppendLine("| Status | Event Name |");
             report.AppendLine("|:------:|------------|");
             
             foreach (var ev in events)
             {
                var isImplemented = implementedEvents.Contains($"{typeName}/{ev.EventName}");
                // Use a different icon or just X? User wants table. 
                // Let's use ⚠️ for ignored-missing, or just X but context implies it is ignored.
                // User asked to "separate table", so X is fine as long as header says Ignored.
                var statusIcon = isImplemented ? "✅" : "⚠️"; // Warning sign for ignored items seems appropriate
                var eventUrl = GetLearnUrl(typeName, ev.EventName);
                report.AppendLine($"| {statusIcon} | [{ev.EventName}]({eventUrl}) |");
             }
             report.AppendLine();
        }
    }

    File.WriteAllText(path, report.ToString());
}

static string GetLearnUrl(string typeName, string? eventName = null)
{
    var baseUrl = "https://learn.microsoft.com/dotnet/api/";
    var lowerType = typeName.ToLower();
    
    // Handle special cases if any, though System.Windows.Forms.Timer usually resolves fine as system.windows.forms.timer
    // But in our code we might have just "Timer", so we need to ensure full qualification for URL if needed.
    // However, the existing code uses "Timer" for System.Windows.Forms.Timer in some places, 
    // but the URL needs "system.windows.forms.timer".
    // Let's check how typeName comes in. 
    // In GetWinFormsEvents, we use type.Name (e.g. Button). 
    // Except for Timer where we use type.FullName (System.Windows.Forms.Timer).
    // So typeName passed here will be "Button" or "System.Windows.Forms.Timer".
    
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

static HashSet<string> GetWinFormsEvents()
{
    var eventsSet = new HashSet<string>();
    var assembly = typeof(Control).Assembly; // System.Windows.Forms.dll

    var types = 
        assembly
        .GetTypes()
        .Where(t => t.IsPublic && t.Namespace == "System.Windows.Forms");

    foreach (var type in types)
    {
        // Get both instance and static events to support classes like Application
        var events =
            type
            .GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var ev in events)
        {
            var browsableAttr = 
                ev
                .GetCustomAttributes(typeof(BrowsableAttribute), false)
                .OfType<BrowsableAttribute>()
                .FirstOrDefault();
            
            // Exclude events where Browsable(false) is set
            if (browsableAttr != null && !browsableAttr.Browsable)
            {
                continue;
            }
            
            if (!"Timer".Equals(type.Name))
            {
                eventsSet.Add($"{type.Name}/{ev.Name}");
            }
            else
            {
                eventsSet.Add($"{type.FullName}/{ev.Name}");
            }
        }
    }
    
    // Add static events from Application class
    var appType = typeof(System.Windows.Forms.Application);
    var staticEvents = appType.GetEvents(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
    
    foreach (var ev in staticEvents)
    {
        var browsableAttr = 
            ev
            .GetCustomAttributes(typeof(BrowsableAttribute), false)
            .OfType<BrowsableAttribute>()
            .FirstOrDefault();
        
        // Exclude events where Browsable(false) is set
        if (browsableAttr != null && !browsableAttr.Browsable)
        {
            continue;
        }
        
        eventsSet.Add($"Application/{ev.Name}");
    }
    
    return eventsSet;
}

static HashSet<string> GetComponetEvents()
{
    var eventsSet = new HashSet<string>();
    var assembly = typeof(Component).Assembly;

    var types =
        assembly
        .GetTypes()
        .Where(
            t => t.IsPublic &&
                t.Namespace == "System.ComponentModel" &&
                t.Name == "Component");

    foreach (var type in types)
    {
        // Get both instance and static events to support classes like Application
        var events =
            type
            .GetEvents(
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly);
        foreach (var ev in events)
        {
            eventsSet.Add($"{type.FullName}/{ev.Name}");
        }
    }

    return eventsSet;
}


static HashSet<string> GetImplementedObservableExtensions(string srcPath, List<string> symbols)
{
    var implementedSet = new HashSet<string>();
    
    // Configure parse options with preprocessor symbols
    var parseOptions = new CSharpParseOptions(
        LanguageVersion.Latest, 
        preprocessorSymbols: symbols);

    var files = Directory.EnumerateFiles(srcPath, "*R3Extends.cs", SearchOption.TopDirectoryOnly);

    foreach (var file in files)
    {
        var typeName = 
            Path
            .GetFileNameWithoutExtension(file)
            .Replace("R3Extends", "");
        if ("Component".Equals(typeName))
        {
            typeName = "System.ComponentModel.Component";
        }
        if ("Timer".Equals(typeName))
        {
            typeName = "System.Windows.Forms.Timer";
        }
        // Application is a special case - it's a static class with static events
        // but we still want to track it as "Application"
        // (no special handling needed, just use "Application")
        
        var content = File.ReadAllText(file);

        // Parse with Roslyn
        var syntaxTree = CSharpSyntaxTree.ParseText(content, parseOptions);
        var root = syntaxTree.GetRoot();

        // Find methods returning Observable<T> and named *AsObservable
        var methods = 
            root
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>();

        foreach (var method in methods)
        {
            var methodName = method.Identifier.Text;
            if (!methodName.EndsWith("AsObservable")) continue;
            
            // Basic verify return type starts with Observable
            // (We could check GenericNameSyntax but text check is usually enough given naming conventions)
            if (!method.ReturnType.ToString().StartsWith("Observable")) continue;

            // Extract event name
            var eventName = methodName.Substring(0, methodName.Length - "AsObservable".Length);
            
            implementedSet.Add($"{typeName}/{eventName}");
        }
    }
    return implementedSet;
}
