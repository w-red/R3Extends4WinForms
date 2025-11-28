using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="System.Windows.Forms.Timer"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class TimerR3Extends
{
    /// <summary><see cref="System.Windows.Forms.Timer.Tick"/> as <see cref="Observable"/></summary>
    /// <param name="t">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> TickAsObservable(
        this System.Windows.Forms.Timer t,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => t.Tick += h,
            h => t.Tick -= h,
            tkn);
}
