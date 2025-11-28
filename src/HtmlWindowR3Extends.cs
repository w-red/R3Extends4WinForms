using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="HtmlWindow"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class HtmlWindowR3Extends
{
    /// <summary><see cref="HtmlWindow"/> extension methods.</summary>
    extension(HtmlWindow hw)
    {
        /// <summary><see cref="HtmlWindow.Error"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementErrorEventArgs> ErrorAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementErrorEventHandler, HtmlElementErrorEventArgs>(
                h => (s, e) => h(e),
                h => hw.Error += h,
                h => hw.Error -= h,
                tkn);

        /// <summary><see cref="HtmlWindow.GotFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> GotFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.GotFocus += h,
                h => hw.GotFocus -= h,
                tkn);

        /// <summary><see cref="HtmlWindow.Load"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> LoadAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Load += h,
                h => hw.Load -= h,
                tkn);

        /// <summary><see cref="HtmlWindow.LostFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> LostFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.LostFocus += h,
                h => hw.LostFocus -= h,
                tkn);

        /// <summary><see cref="HtmlWindow.Resize"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> ResizeAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Resize += h,
                h => hw.Resize -= h,
                tkn);

        /// <summary><see cref="HtmlWindow.Scroll"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> ScrollAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Scroll += h,
                h => hw.Scroll -= h,
                tkn);

        /// <summary><see cref="HtmlWindow.Unload"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> UnloadAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hw.Unload += h,
                h => hw.Unload -= h,
                tkn);
    }
}
