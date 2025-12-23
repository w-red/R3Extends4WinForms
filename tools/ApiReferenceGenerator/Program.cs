using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;
using System.Reflection;
using System.Text;

Console.WriteLine("API Reference Generator");
Console.WriteLine("=======================");

var projectRoot = new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent?.Parent?.FullName;
if (projectRoot == null)
{
    Console.WriteLine("Error: Could not determine the project root directory.");
    return;
}

var srcPath = Path.Combine(projectRoot, "src");
var outputPath = Path.Combine(projectRoot, "wikipage", "Home.md");

var frameworks = new[] { "472", "Net6", "Net8", "Net10" };
var symbolsMap = new Dictionary<string, List<string>>
{
    { "472", new List<string> { 
        "NET472", "NET472_OR_GREATER", "NET471_OR_GREATER", "NET47_OR_GREATER", 
        "NET462_OR_GREATER", "NET461_OR_GREATER", "NET46_OR_GREATER", 
        "NET452_OR_GREATER", "NET451_OR_GREATER", "NET45_OR_GREATER", 
        "NET40_OR_GREATER", "NET35_OR_GREATER", "NET20_OR_GREATER", "NETFRAMEWORK" 
    } },
    { "Net6", new List<string> { 
        "NET6_0", "NET6_0_OR_GREATER", "NET5_0_OR_GREATER", "NETCOREAPP", "NETCOREAPP3_1_OR_GREATER" 
    } },
    { "Net8", new List<string> { 
        "NET8_0", "NET8_0_OR_GREATER", "NET7_0_OR_GREATER", "NET6_0_OR_GREATER", "NET5_0_OR_GREATER", "NETCOREAPP", "NETCOREAPP3_1_OR_GREATER" 
    } },
    { "Net10", new List<string> { 
        "NET10_0", "NET10_0_OR_GREATER", "NET9_0_OR_GREATER", "NET8_0_OR_GREATER", "NET7_0_OR_GREATER", "NET6_0_OR_GREATER", "NET5_0_OR_GREATER", "NETCOREAPP", "NETCOREAPP3_1_OR_GREATER" 
    } }
};

// 1. ソースコードから各フレームワークの実装済みメソッドを抽出
var implementedByFramework = new Dictionary<string, HashSet<string>>();
foreach (var fw in frameworks)
{
    implementedByFramework[fw] = GetImplementedObservableExtensions(srcPath, symbolsMap[fw]);
}

// 2. WinForms の全イベントを取得 (リフレクションを使用)
// 注意: 各フレームワークの DLL を直接参照するのは難しいため、
// 実行時の環境 から取得し、一部の型は除外する等の処理を行う。
var winFormsEvents = GetWinFormsEvents();
var componentEvents = GetComponetEvents();
var allEvents = winFormsEvents.Union(componentEvents).OrderBy(e => e).ToList();

// 3. Markdown 生成
var report = new StringBuilder();
report.AppendLine("# R3Extends4WinForms API reference");
report.AppendLine();
report.AppendLine("R3Extends4WinForms is the extension methods for [System.Windows.WinForms](https://learn.microsoft.com/dotnet/api/system.windows.forms) for [R3](https://github.com/Cysharp/R3).");
report.AppendLine();

// System.Windows.Forms セクション
report.AppendLine("## [System.Windows.Forms](https://learn.microsoft.com/dotnet/api/system.windows.forms) events from `AsObservable` method");
report.AppendLine();
report.AppendLine("The extension methods used in R3Extends are as follows:");
report.AppendLine();
report.AppendLine("```csharp");
report.AppendLine("/// Any event<AnyEventHandler> as Observable...");
report.AppendLine("public Observable<AnyEventHandler> AnyEventAsObservable(CancellationToken tkn = default)");
report.AppendLine("```");
report.AppendLine();

AppendClassesSection(report, winFormsEvents, implementedByFramework);

// System.ComponentModel セクション
report.AppendLine("## [System.ComponentModel](https://learn.microsoft.com/dotnet/api/system.componentmodel) events from `AsObservable` method");
report.AppendLine();
AppendClassesSection(report, componentEvents, implementedByFramework);

File.WriteAllText(outputPath, report.ToString());
Console.WriteLine($"Generated: {outputPath}");

// --- Helper Methods ---

static void AppendClassesSection(StringBuilder report, HashSet<string> events, Dictionary<string, HashSet<string>> implementedByFramework)
{
    var groupedByClass = events
        .Select(e => {
            var parts = e.Split('/');
            return new { TypeName = parts[0], EventName = parts[1] };
        })
        .GroupBy(e => e.TypeName)
        .OrderBy(g => g.Key);

    foreach (var group in groupedByClass)
    {
        var typeName = group.Key;
        var typeUrl = GetLearnUrl(typeName);
        var className = typeName.Contains('.') ? typeName.Split('.').Last() : typeName;
        var fileName = $"{className}R3Extends.cs";

        report.AppendLine($"### [{className}]({typeUrl})")
            .AppendLine()
            .AppendLine($"Extensions implement at [{fileName}](https://github.com/w-red/R3Extends4WinForms/tree/master/src/{fileName}).")
            .AppendLine();

        if (className == "ToolStripManager")
        {
            report.AppendLine("> [!NOTE]")
                  .AppendLine("> `RendererChanged` event is static event.")
                  .AppendLine("> So `RendererChangedAsObservable` method is static method.")
                  .AppendLine("> ")
                  .AppendLine("> Usage:")
                  .AppendLine(">")
                  .AppendLine("> ```csharp")
                  .AppendLine("> ToolStripManagerR3Extends.RendererChangedAsObservable().Subscribe(_ =>")
                  .AppendLine("> {")
                  .AppendLine(">     // do something")
                  .AppendLine("> });")
                  .AppendLine("> ```")
                  .AppendLine();
        }
        report.AppendLine("| Event | AsObservable method | 472 | Net6 | Net8 | Net10 |")
            .AppendLine("| :--- | :--- | :---: | :---: | :---: | :---: |");

        foreach (var ev in group.OrderBy(e => e.EventName))
        {
            var eventUrl = GetLearnUrl(typeName, ev.EventName);
            var methodName = $"`{ev.EventName}AsObservable`";
            
            var status472 = implementedByFramework["472"].Contains($"{typeName}/{ev.EventName}") ? "✅" : "❌";
            var statusNet6 = implementedByFramework["Net6"].Contains($"{typeName}/{ev.EventName}") ? "✅" : "❌";
            var statusNet8 = implementedByFramework["Net8"].Contains($"{typeName}/{ev.EventName}") ? "✅" : "❌";
            var statusNet10 = implementedByFramework["Net10"].Contains($"{typeName}/{ev.EventName}") ? "✅" : "❌";

            report.AppendLine($"| [{ev.EventName}]({eventUrl}) | {methodName} | {status472} | {statusNet6} | {statusNet8} | {statusNet10} |");
        }
        report.AppendLine();
    }
}

static string GetLearnUrl(string typeName, string? eventName = null)
{
    var baseUrl = "https://learn.microsoft.com/dotnet/api/";
    var fullTypeName = typeName.Contains('.') ? typeName : $"System.Windows.Forms.{typeName}";
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
    var assembly = typeof(System.Windows.Forms.Control).Assembly;

    var types = assembly.GetTypes()
        .Where(t => t.IsPublic && t.Namespace == "System.Windows.Forms");

    foreach (var type in types)
    {
        var events = type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var ev in events)
        {
            var browsableAttr = ev.GetCustomAttributes(typeof(BrowsableAttribute), false).OfType<BrowsableAttribute>().FirstOrDefault();
            if (browsableAttr != null && !browsableAttr.Browsable) continue;
            
            var key = type.Name == "Timer" ? type.FullName! : type.Name;
            eventsSet.Add($"{key}/{ev.Name}");
        }
    }

    // Application
    var appType = typeof(System.Windows.Forms.Application);
    foreach (var ev in appType.GetEvents(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
    {
        eventsSet.Add($"Application/{ev.Name}");
    }
    
    return eventsSet;
}

static HashSet<string> GetComponetEvents()
{
    var eventsSet = new HashSet<string>();
    var assembly = typeof(System.ComponentModel.Component).Assembly;
    var type = typeof(System.ComponentModel.Component);
    
    foreach (var ev in type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
    {
        eventsSet.Add($"{type.FullName}/{ev.Name}");
    }

    return eventsSet;
}

static HashSet<string> GetImplementedObservableExtensions(string srcPath, List<string> symbols)
{
    var implementedSet = new HashSet<string>();
    var parseOptions = new CSharpParseOptions(LanguageVersion.Latest, preprocessorSymbols: symbols);
    var files = Directory.EnumerateFiles(srcPath, "*R3Extends.cs", SearchOption.TopDirectoryOnly);

    foreach (var file in files)
    {
        var typeName = Path.GetFileNameWithoutExtension(file).Replace("R3Extends", "");
        if (typeName == "Component") typeName = "System.ComponentModel.Component";
        if (typeName == "Timer") typeName = "System.Windows.Forms.Timer";
        
        var content = File.ReadAllText(file);
        var syntaxTree = CSharpSyntaxTree.ParseText(content, parseOptions);
        var root = syntaxTree.GetRoot();

        var methods = root.DescendantNodes().OfType<MethodDeclarationSyntax>();
        foreach (var method in methods)
        {
            var methodName = method.Identifier.Text;
            if (!methodName.EndsWith("AsObservable")) continue;
            if (!method.ReturnType.ToString().StartsWith("Observable")) continue;

            var eventName = methodName.Substring(0, methodName.Length - "AsObservable".Length);
            implementedSet.Add($"{typeName}/{eventName}");
        }
    }
    return implementedSet;
}
