using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="RadioButton"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class RadioButtonR3Extends
{
    /// <summary><see cref="RadioButton"/> extension methods.</summary>
    extension(RadioButton rb)
    {
        /// <summary><see cref="RadioButton.AppearanceChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AppearanceChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rb.AppearanceChanged += h,
                h => rb.AppearanceChanged -= h,
                tkn);

        /// <summary><see cref="RadioButton.CheckedChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CheckedChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rb.CheckedChanged += h,
                h => rb.CheckedChanged -= h,
                tkn);
    }
}
