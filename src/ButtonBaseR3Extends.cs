using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ButtonBase"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ButtonBaseR3Extends
{
    /// <summary><see cref="ButtonBase.AutoSizeChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> AutoSizeChangedAsObservable(
        this ButtonBase bb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bb.AutoSizeChanged += h,
            h => bb.AutoSizeChanged -= h,
            tkn);

#if NET7_0_OR_GREATER
    /// <summary><see cref="ButtonBase.CommandCanExecuteChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CommandCanExecuteChangedAsObservable(
        this ButtonBase bb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bb.CommandCanExecuteChanged += h,
            h => bb.CommandCanExecuteChanged -= h,
            tkn);

    /// <summary><see cref="ButtonBase.CommandChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CommandChangedAsObservable(
        this ButtonBase bb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bb.CommandChanged += h,
            h => bb.CommandChanged -= h,
            tkn);

    /// <summary><see cref="ButtonBase.CommandParameterChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CommandParameterChangedAsObservable(
        this ButtonBase bb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bb.CommandParameterChanged += h,
            h => bb.CommandParameterChanged -= h,
            tkn);
#endif
}
