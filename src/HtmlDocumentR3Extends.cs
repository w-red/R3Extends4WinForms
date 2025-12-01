using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="HtmlDocument"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class HtmlDocumentR3Extends
{
    /// <summary><see cref="HtmlDocument"/> extension methods.</summary>
    extension(HtmlDocument hd)
    {
        /// <summary><see cref="HtmlDocument.Click"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> ClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Click += h,
                h => hd.Click -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.ContextMenuShowing"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> ContextMenuShowingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.ContextMenuShowing += h,
                h => hd.ContextMenuShowing -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.Focusing"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> FocusingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Focusing += h,
                h => hd.Focusing -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.LosingFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> LosingFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.LosingFocus += h,
                h => hd.LosingFocus -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseDown += h,
                h => hd.MouseDown -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseLeave += h,
                h => hd.MouseLeave -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseMoveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseMove += h,
                h => hd.MouseMove -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseOver"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseOverAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseOver += h,
                h => hd.MouseOver -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseUp += h,
                h => hd.MouseUp -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.Stop"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> StopAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Stop += h,
                h => hd.Stop -= h,
                tkn);
    }
}
