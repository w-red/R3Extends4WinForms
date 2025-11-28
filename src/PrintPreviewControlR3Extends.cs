using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="PrintPreviewControl"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class PrintPreviewControlR3Extends
{
    /// <summary><see cref="PrintPreviewControl.StartPageChanged"/> as <see cref="Observable"/></summary>
    /// <param name="ppc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> StartPageChangedAsObservable(
        this PrintPreviewControl ppc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ppc.StartPageChanged += h,
            h => ppc.StartPageChanged -= h,
            tkn);
}
