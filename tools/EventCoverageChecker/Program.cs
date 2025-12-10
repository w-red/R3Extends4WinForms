using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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
    preprocessorSymbols.AddRange(new[] { "NET10_0", "NET10_0_OR_GREATER", "NET8_0_OR_GREATER", "NET6_0_OR_GREATER", "NET5_0_OR_GREATER", "NETCOREAPP" });
#elif NET8_0_OR_GREATER
    tgtName = "NET8";
    preprocessorSymbols.AddRange(new[] { "NET8_0", "NET8_0_OR_GREATER", "NET7_0_OR_GREATER", "NET6_0_OR_GREATER", "NET5_0_OR_GREATER", "NETCOREAPP" });
#elif NET6_0_OR_GREATER
    tgtName = "NET6";
    preprocessorSymbols.AddRange(new[] { "NET6_0", "NET6_0_OR_GREATER", "NET5_0_OR_GREATER", "NETCOREAPP" });
#elif NET472_OR_GREATER || NET472 || NET462_OR_GREATER || NETFRAMEWORK
    tgtName = "472";
    preprocessorSymbols.AddRange(new[] { "NET472", "NET472_OR_GREATER", "NETFRAMEWORK" });
#else
    tgtName = "Unknown";
#endif

// Can be passed as args or detected
Console.WriteLine($"Running for Target: {tgtName}");
Console.WriteLine($"Symbols: {string.Join(", ", preprocessorSymbols)}");

var winFormsEvents = GetWinFormsEvents();
var implementedExtensions = GetImplementedObservableExtensions(Path.Combine(projectRoot, "src"), preprocessorSymbols);

var reportPath = 
    Path
    .Combine(
        projectRoot,
        "tools",
        "EventCoverageChecker",
        $"CoverageReport{tgtName}.md");
GenerateReport(winFormsEvents, implementedExtensions, reportPath);

var missingCount = winFormsEvents.Except(implementedExtensions).Count();
Console.WriteLine($"Analysis complete. Found {missingCount} missing events.");
Console.WriteLine($"Report generated at: {reportPath}");


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
        var events =
            type
            .GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
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
        if ("Timer".Equals(typeName))
        {
            typeName = "System.Windows.Forms.Timer";
        }
        
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

static void GenerateReport(
    HashSet<string> allEvents,
    HashSet<string> implementedEvents,
    string path)
{
    var report = new StringBuilder();
    var missingEvents = 
        allEvents
        .Except(implementedEvents)
        .ToHashSet();
    
    report.AppendLine("# Event Coverage Report").AppendLine()
        .AppendLine($"*Generated on {DateTime.UtcNow:u}*").AppendLine()
        .AppendLine($"*Target Framework {AppContext.TargetFrameworkName}*").AppendLine()
        .AppendLine($"**Total Events:** {allEvents.Count} | **Implemented:** {implementedEvents.Count} | **Missing:** {missingEvents.Count}").AppendLine();

    if (!allEvents.Any())
    {
        report.AppendLine("No browsable events found to check.");
        File.WriteAllText(path, report.ToString());
        return;
    }
    
    var groupedByClass = 
        allEvents
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
        var events = group.OrderBy(e => e.EventName).ToList();
        
        var implementedCount =
            events
            .Count(e => implementedEvents.Contains($"{typeName}/{e.EventName}"));
        var coverage = 
            events.Any() ?
            (double)implementedCount / events.Count : 0;
        
        report.AppendLine($"### `{typeName}`");
        report.AppendLine($"**Coverage: {coverage:P0}** ({implementedCount} / {events.Count})");
        report.AppendLine();
        report.AppendLine("| Status | Event Name |");
        report.AppendLine("|:------:|------------|");

        foreach (var ev in events)
        {
            var isImplemented = 
                implementedEvents
                .Contains($"{typeName}/{ev.EventName}");
            var statusIcon = isImplemented ? "✅" : "❌";
            report.AppendLine($"| {statusIcon} | {ev.EventName} |");
        }
        report.AppendLine();
    }

    File.WriteAllText(path, report.ToString());
}