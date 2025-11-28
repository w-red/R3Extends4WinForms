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

    extension(MaskedTextBox mtb)
    {
        /// <summary><see cref="MaskedTextBox.IsOverwriteModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> IsOverwriteModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mtb.IsOverwriteModeChanged += h,
                h => mtb.IsOverwriteModeChanged -= h,
                tkn);

        /// <summary><see cref="MaskedTextBox.MaskChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MaskChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mtb.MaskChanged += h,
                h => mtb.MaskChanged -= h,
                tkn);

        /// <summary><see cref="MaskedTextBox.MaskInputRejected"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MaskInputRejectedEventArgs> MaskInputRejectedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MaskInputRejectedEventHandler, MaskInputRejectedEventArgs>(
                h => (s, e) => h(e),
                h => mtb.MaskInputRejected += h,
                h => mtb.MaskInputRejected -= h,
                tkn);

        /// <summary><see cref="MaskedTextBox.TextAlignChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextAlignChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mtb.TextAlignChanged += h,
                h => mtb.TextAlignChanged -= h,
                tkn);

        /// <summary><see cref="MaskedTextBox.TypeValidationCompleted"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<TypeValidationEventArgs> TypeValidationCompletedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<TypeValidationEventHandler, TypeValidationEventArgs>(
                h => (s, e) => h(e),
                h => mtb.TypeValidationCompleted += h,
                h => mtb.TypeValidationCompleted -= h,
                tkn);
    }
}
