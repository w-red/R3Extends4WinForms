using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="UserControl"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class UserControlR3Extends
{
    /// <summary><see cref="UserControl"/> extension methods.</summary>
    extension(UserControl uc)
    {
        /// <summary><see cref="UserControl.Load"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LoadAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.Load += h,
                h => uc.Load -= h,
                tkn);

        /// <summary><see cref="UserControl.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AutoSizeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.AutoValidateChanged += h,
                h => uc.AutoValidateChanged -= h,
                tkn);

        /// <summary><see cref="UserControl.AutoValidateChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AutoValidateChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.AutoValidateChanged += h,
                h => uc.AutoValidateChanged -= h,
                tkn);

        /// <summary><see cref="UserControl.TextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => uc.TextChanged += h,
                h => uc.TextChanged -= h,
                tkn);
    }
}
