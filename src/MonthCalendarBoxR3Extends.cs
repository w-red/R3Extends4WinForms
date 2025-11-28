using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="MonthCalendar"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class MonthCalendarR3Extends
{
    /// <summary><see cref="MonthCalendar.DateChanged"/> as <see cref="Observable"/></summary>
    /// <param name="mc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<DateRangeEventArgs> DateChangedAsObservable(
        this MonthCalendar mc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<DateRangeEventHandler, DateRangeEventArgs>(
            h => (s, e) => h(e),
            h => mc.DateChanged += h,
            h => mc.DateChanged -= h,
            tkn);

    /// <summary><see cref="MonthCalendar.DateSelected"/> as <see cref="Observable"/></summary>
    /// <param name="mc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<DateRangeEventArgs> DateSelectedAsObservable(
        this MonthCalendar mc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<DateRangeEventHandler, DateRangeEventArgs>(
            h => (s, e) => h(e),
            h => mc.DateSelected += h,
            h => mc.DateSelected -= h,
            tkn);

    /// <summary><see cref="MonthCalendar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
    /// <param name="mc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
        this MonthCalendar mc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => mc.RightToLeftLayoutChanged += h,
            h => mc.RightToLeftLayoutChanged -= h,
            tkn);
}
