using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="DateTimePicker"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class DateTimePickerR3Extends
{
    /// <summary><see cref="DateTimePicker.CloseUp"/> as <see cref="Observable"/></summary>
    /// <param name="dtp">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CloseUpAsObservable(
        this DateTimePicker dtp,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => dtp.CloseUp += h,
            h => dtp.CloseUp -= h,
            tkn);

    /// <summary><see cref="DateTimePicker.DropDown"/> as <see cref="Observable"/></summary>
    /// <param name="dtp">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DropDownAsObservable(
        this DateTimePicker dtp,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => dtp.DropDown += h,
            h => dtp.DropDown -= h,
            tkn);

    /// <summary><see cref="DateTimePicker.FormatChanged"/> as <see cref="Observable"/></summary>
    /// <param name="dtp">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> FormatChangedAsObservable(
        this DateTimePicker dtp,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => dtp.FormatChanged += h,
            h => dtp.FormatChanged -= h,
            tkn);

    /// <summary><see cref="DateTimePicker.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
    /// <param name="dtp">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
        this DateTimePicker dtp,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => dtp.RightToLeftLayoutChanged += h,
            h => dtp.RightToLeftLayoutChanged -= h,
            tkn);

    /// <summary><see cref="DateTimePicker.TextChanged"/> as <see cref="Observable"/></summary>
    /// <param name="dtp">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> TextChangedAsObservable(
        this DateTimePicker dtp,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => dtp.TextChanged += h,
            h => dtp.TextChanged -= h,
            tkn);

    /// <summary><see cref="DateTimePicker.ValueChanged"/> as <see cref="Observable"/></summary>
    /// <param name="dtp">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> ValueChangedAsObservable(
        this DateTimePicker dtp,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => dtp.ValueChanged += h,
            h => dtp.ValueChanged -= h,
            tkn);
}
