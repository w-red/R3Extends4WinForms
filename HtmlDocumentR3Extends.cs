using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="HtmlDocument"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class HtmlDocumentR3Extends
    {
        /// <summary><see cref="HtmlDocument.Click"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> ClickAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Click += h,
                h => hd.Click -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.ContextMenuShowing"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> ContextMenuShowingAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.ContextMenuShowing += h,
                h => hd.ContextMenuShowing -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.Focusing"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> FocusingAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Focusing += h,
                h => hd.Focusing -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.LosingFocus"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> LosingFocusAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.LosingFocus += h,
                h => hd.LosingFocus -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> MouseDownAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseDown += h,
                h => hd.MouseDown -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> MouseLeaveAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseLeave += h,
                h => hd.MouseLeave -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> MouseMoveAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseMove += h,
                h => hd.MouseMove -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseOver"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> MouseOverAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseOver += h,
                h => hd.MouseOver -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.MouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> MouseUpAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.MouseUp += h,
                h => hd.MouseUp -= h,
                tkn);

        /// <summary><see cref="HtmlDocument.Stop"/> as <see cref="Observable"/></summary>
        /// <param name="hd">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HtmlElementEventArgs> StopAsObservable(
            this HtmlDocument hd,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => hd.Stop += h,
                h => hd.Stop -= h,
                tkn);
    }
}
