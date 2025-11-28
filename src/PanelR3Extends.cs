using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="Panel"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class PanelR3Extends
{
    /// <summary><see cref="Panel.AutoSizeChanged"/> as <see cref="Observable"/></summary>
    /// <param name="p">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> AutoSizeChangedAsObservable(
        this Panel p,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => p.AutoSizeChanged += h,
            h => p.AutoSizeChanged -= h,
            tkn);

}
