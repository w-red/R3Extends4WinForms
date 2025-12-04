using R3.WinForms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsSampleNet472;

/// <summary>Program</summary>
public static class Program
{
    /// <summary>Entry point.</summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
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
