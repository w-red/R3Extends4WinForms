using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ScrollableControl"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ScrollableControlR3Extends
{
    /// <summary><see cref="ScrollableControl.Scroll"/> as <see cref="Observable"/></summary>
    /// <param name="sc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ScrollEventArgs> ScrollAsObservable(
        this ScrollableControl sc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>(
            h => (s, e) => h(e),
            h => sc.Scroll += h,
            h => sc.Scroll -= h,
            tkn);
}
