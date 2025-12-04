using R3.WinForms;
using System.Diagnostics;
using WinFormsSampleNet472;

namespace WinFormsNET8;

public static class Program
{
    /// <summary>entry point for the application.</summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var frm = new R3Extends4WinFormsSample();
        // R3 enabled UnhandledException
        WinFormsProviderInitializer
            .SetDefaultObservableSystem(
                static (ex) =>
                    Trace.WriteLine($"R3 UnhandledException:{ex}"),
                frm);
        Application.Run(frm);
    }
}
