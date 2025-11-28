using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="MaskedTextBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class MaskedTextBoxR3Extends
{
    /// <summary><see cref="MaskedTextBox.IsOverwriteModeChanged"/> as <see cref="Observable"/></summary>
    /// <param name="rtb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> IsOverwriteModeChangedAsObservable(
        this MaskedTextBox rtb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => rtb.IsOverwriteModeChanged += h,
            h => rtb.IsOverwriteModeChanged -= h,
            tkn);

    /// <summary><see cref="MaskedTextBox.MaskChanged"/> as <see cref="Observable"/></summary>
    /// <param name="rtb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> MaskChangedAsObservable(
        this MaskedTextBox rtb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => rtb.MaskChanged += h,
            h => rtb.MaskChanged -= h,
            tkn);

    /// <summary><see cref="MaskedTextBox.MaskInputRejected"/> as <see cref="Observable"/></summary>
    /// <param name="rtb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<MaskInputRejectedEventArgs> MaskInputRejectedAsObservable(
        this MaskedTextBox rtb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<MaskInputRejectedEventHandler, MaskInputRejectedEventArgs>(
            h => (s, e) => h(e),
            h => rtb.MaskInputRejected += h,
            h => rtb.MaskInputRejected -= h,
            tkn);

    /// <summary><see cref="MaskedTextBox.TextAlignChanged"/> as <see cref="Observable"/></summary>
    /// <param name="rtb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> TextAlignChangedAsObservable(
        this MaskedTextBox rtb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => rtb.TextAlignChanged += h,
            h => rtb.TextAlignChanged -= h,
            tkn);

    /// <summary><see cref="MaskedTextBox.TypeValidationCompleted"/> as <see cref="Observable"/></summary>
    /// <param name="rtb">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<TypeValidationEventArgs> TypeValidationCompletedAsObservable(
        this MaskedTextBox rtb,
        CancellationToken tkn = default) =>
        Observable.FromEvent<TypeValidationEventHandler, TypeValidationEventArgs>(
            h => (s, e) => h(e),
            h => rtb.TypeValidationCompleted += h,
            h => rtb.TypeValidationCompleted -= h,
            tkn);
}
