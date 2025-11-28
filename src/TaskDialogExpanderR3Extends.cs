using R3;

namespace R3Extends4WinForms;

#if NET5_0_OR_GREATER
/// <summary><see cref="R3"/>'s Extends for <see cref="TaskDialogExpander"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class TaskDialogExpanderR3Extends
{
    /// <summary><see cref="TaskDialogExpander.ExpandedChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tde">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> ExpandedChangedAsObservable(
        this TaskDialogExpander tde,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tde.ExpandedChanged += h,
            h => tde.ExpandedChanged -= h,
            tkn);
}
#endif
