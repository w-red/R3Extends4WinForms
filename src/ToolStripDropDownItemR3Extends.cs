using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripDropDownItem"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripDropDownItemR3Extends
{
    /// <summary><see cref="ToolStripDropDownItem.DropDownOpened"/> as <see cref="Observable"/></summary>
    /// <param name="tsddi">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DropDownOpenedAsObservable(
        this ToolStripDropDownItem tsddi,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsddi.DropDownOpened += h,
            h => tsddi.DropDownOpened -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDownItem.DropDownOpening"/> as <see cref="Observable"/></summary>
    /// <param name="tsddi">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DropDownOpeningAsObservable(
        this ToolStripDropDownItem tsddi,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsddi.DropDownOpening += h,
            h => tsddi.DropDownOpening -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDownItem.DropDownClosed"/> as <see cref="Observable"/></summary>
    /// <param name="tsddi">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DropDownClosedAsObservable(
        this ToolStripDropDownItem tsddi,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsddi.DropDownClosed += h,
            h => tsddi.DropDownClosed -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDownItem.DropDownItemClicked"/> as <see cref="Observable"/></summary>
    /// <param name="tsddi">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemClickedEventArgs> DropDownItemClickedAsObservable(
        this ToolStripDropDownItem tsddi,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
            h => (s, e) => h(e),
            h => tsddi.DropDownItemClicked += h,
            h => tsddi.DropDownItemClicked -= h,
            tkn);
}
