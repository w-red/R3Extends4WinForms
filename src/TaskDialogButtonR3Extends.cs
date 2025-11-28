using R3;

namespace R3Extends4WinForms;

#if NET5_0_OR_GREATER
/// <summary><see cref="R3"/>'s Extends for <see cref="TaskDialogButton"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class TaskDialogButtonR3Extends
{
    /// <summary><see cref="TaskDialogButton.Click"/> as <see cref="Observable"/></summary>
    /// <param name="tdb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> ClickAsObservable(
        this TaskDialogButton tdb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tdb.Click += h,
            h => tdb.Click -= h,
            tkn);
}
#endif
