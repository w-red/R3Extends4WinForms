using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripButton"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripButtonR3Extends
{
    /// <summary><see cref="ToolStripButton.CheckedChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CheckedChangedAsObservable(
        this ToolStripButton tsb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsb.CheckedChanged += h,
            h => tsb.CheckedChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripButton.CheckStateChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CheckStateChangedAsObservable(
        this ToolStripButton tsb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsb.CheckStateChanged += h,
            h => tsb.CheckStateChanged -= h,
            tkn);
}
