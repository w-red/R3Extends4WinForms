using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

Console.WriteLine("Event Coverage Checker");
Console.WriteLine("======================");

var projectRoot = new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent?.Parent?.FullName;
if (projectRoot == null)
{
    Console.WriteLine("Error: Could not determine the project root directory.");
    return;
}

var winFormsEvents = GetWinFormsEvents();
var implementedExtensions = GetImplementedObservableExtensions(Path.Combine(projectRoot, "src"));

var reportPath = Path.Combine(projectRoot, "tools", "EventCoverageChecker", "CoverageReport.md");
GenerateReport(winFormsEvents, implementedExtensions, reportPath);

var missingCount = winFormsEvents.Except(implementedExtensions).Count();
Console.WriteLine($"Analysis complete. Found {missingCount} missing events.");
Console.WriteLine($"Report generated at: {reportPath}");


static HashSet<string> GetWinFormsEvents()
{
    var eventsSet = new HashSet<string>();
    var assembly = typeof(Control).Assembly; // System.Windows.Forms.dll

    var types = assembly.GetTypes().Where(t => t.IsPublic && t.Namespace == "System.Windows.Forms");

    foreach (var type in types)
    {
        var events = type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var ev in events)
        {
            var browsableAttr = ev.GetCustomAttributes(typeof(BrowsableAttribute), false)
                                  .OfType<BrowsableAttribute>()
                                  .FirstOrDefault();
            
            // Exclude events where Browsable(false) is set
            if (browsableAttr != null && !browsableAttr.Browsable)
            {
                continue;
            }
            
            eventsSet.Add($"{type.Name}.{ev.Name}");
        }
    }
    return eventsSet;
}

static HashSet<string> GetImplementedObservableExtensions(string srcPath)
{
    var implementedSet = new HashSet<string>();
    var extensionRegex = new Regex(
        @"public Observable<.*> ([a-zA-Z0-9_]+)AsObservable\s*\(\s*CancellationToken",
        RegexOptions.Compiled | RegexOptions.Multiline);

    var files = Directory.EnumerateFiles(srcPath, "*R3Extends.cs", SearchOption.TopDirectoryOnly);

    foreach (var file in files)
    {
        var typeName = Path.GetFileNameWithoutExtension(file).Replace("R3Extends", "");
        var content = File.ReadAllText(file);

        if (!content.Contains($"extension({typeName}"))
        {
            continue;
        }

        var matches = extensionRegex.Matches(content);

        foreach (Match match in matches)
        {
            if (match.Groups.Count == 2)
            {
                var eventName = match.Groups[1].Value.Trim();
                implementedSet.Add($"{typeName}.{eventName}");
            }
        }
    }
    return implementedSet;
}

static void GenerateReport(HashSet<string> allEvents, HashSet<string> implementedEvents, string path)
{
    var report = new StringBuilder();
    var missingEvents = allEvents.Except(implementedEvents).ToHashSet();
    
    report.AppendLine("# Event Coverage Report");
    report.AppendLine();
    report.AppendLine($"**Total Events:** {allEvents.Count} | **Implemented:** {implementedEvents.Count} | **Missing:** {missingEvents.Count}");
    report.AppendLine();

    if (!allEvents.Any())
    {
        report.AppendLine("No browsable events found to check.");
        File.WriteAllText(path, report.ToString());
        return;
    }
    
    var groupedByClass = allEvents
        .Select(e =>
        {
            var parts = e.Split('.');
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
        
        var implementedCount = events.Count(e => implementedEvents.Contains($"{typeName}.{e.EventName}"));
        var coverage = events.Any() ? (double)implementedCount / events.Count : 0;
        
        report.AppendLine($"### `{typeName}`");
        report.AppendLine($"**Coverage: {coverage:P0}** ({implementedCount} / {events.Count})");
        report.AppendLine();
        report.AppendLine("| Status | Event Name |");
        report.AppendLine("|:------:|------------|");

        foreach (var ev in events)
        {
            var isImplemented = implementedEvents.Contains($"{typeName}.{ev.EventName}");
            var statusIcon = isImplemented ? "✅" : "❌";
            report.AppendLine($"| {statusIcon} | {ev.EventName} |");
        }
        report.AppendLine();
    }

    File.WriteAllText(path, report.ToString());
}