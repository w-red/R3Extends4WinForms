using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="WebBrowser"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class WebBrowserR3Extends
    {
        /// <summary><see cref="WebBrowser.CanGoBackChanged"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CanGoBackChangedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.CanGoBackChanged += h,
                h => wb.CanGoBackChanged -= h,
                tkn);

        /// <summary><see cref="WebBrowser.CanGoForwardChanged"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CanGoForwardChangedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.CanGoForwardChanged += h,
                h => wb.CanGoForwardChanged -= h,
                tkn);

        /// <summary><see cref="WebBrowser.DocumentCompleted"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<WebBrowserDocumentCompletedEventArgs> DocumentCompletedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<WebBrowserDocumentCompletedEventHandler, WebBrowserDocumentCompletedEventArgs>(
                h => (s, e) => h(e),
                h => wb.DocumentCompleted += h,
                h => wb.DocumentCompleted -= h,
                tkn);

        /// <summary><see cref="WebBrowser.DocumentTitleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DocumentTitleChangedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.DocumentTitleChanged += h,
                h => wb.DocumentTitleChanged -= h,
                tkn);

        /// <summary><see cref="WebBrowser.EncryptionLevelChanged"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> EncryptionLevelChangedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.EncryptionLevelChanged += h,
                h => wb.EncryptionLevelChanged -= h,
                tkn);

        /// <summary><see cref="WebBrowser.FileDownload"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> FileDownloadAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.FileDownload += h,
                h => wb.FileDownload -= h,
                tkn);

        /// <summary><see cref="WebBrowser.Navigated"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<WebBrowserNavigatedEventArgs> NavigatedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<WebBrowserNavigatedEventHandler, WebBrowserNavigatedEventArgs>(
                h => (s, e) => h(e),
                h => wb.Navigated += h,
                h => wb.Navigated -= h,
                tkn);

        /// <summary><see cref="WebBrowser.Navigating"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<WebBrowserNavigatingEventArgs> NavigatingAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<WebBrowserNavigatingEventHandler, WebBrowserNavigatingEventArgs>(
                h => (s, e) => h(e),
                h => wb.Navigating += h,
                h => wb.Navigating -= h,
                tkn);

        /// <summary><see cref="WebBrowser.NewWindow"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CancelEventArgs> NewWindowAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => wb.NewWindow += h,
                h => wb.NewWindow -= h,
                tkn);

        /// <summary><see cref="WebBrowser.ProgressChanged"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<WebBrowserProgressChangedEventArgs> ProgressChangedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<WebBrowserProgressChangedEventHandler, WebBrowserProgressChangedEventArgs>(
                h => (s, e) => h(e),
                h => wb.ProgressChanged += h,
                h => wb.ProgressChanged -= h,
                tkn);

        /// <summary><see cref="WebBrowser.StatusTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="wb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> StatusTextChangedAsObservable(
            this WebBrowser wb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => wb.StatusTextChanged += h,
                h => wb.StatusTextChanged -= h,
                tkn);
    }
}
