using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="CheckBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class CheckBoxR3Extends
{
    /// <summary><see cref="CheckBox.AppearanceChanged"/> as <see cref="Observable"/></summary>
    /// <param name="cb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> AppearanceChangedAsObservable(
        this CheckBox cb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => cb.AppearanceChanged += h,
            h => cb.AppearanceChanged -= h,
            tkn);

    /// <summary><see cref="CheckBox.CheckedChanged"/> as <see cref="Observable"/></summary>
    /// <param name="cb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CheckedChangedAsObservable(
        this CheckBox cb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => cb.CheckedChanged += h,
            h => cb.CheckedChanged -= h,
            tkn);

    /// <summary><see cref="CheckBox.CheckStateChanged"/> as <see cref="Observable"/></summary>
    /// <param name="cb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CheckStateChangedAsObservable(
        this CheckBox cb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => cb.CheckStateChanged += h,
            h => cb.CheckStateChanged -= h,
            tkn);
}
