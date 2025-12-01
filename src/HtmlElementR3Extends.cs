using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="HtmlElement"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class HtmlElementR3Extends
{
    /// <summary><see cref="HtmlElement"/> extension methods.</summary>
    extension(HtmlElement he)
    {
        /// <summary><see cref="HtmlElement.Click"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> ClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.Click += h,
                h => he.Click -= h,
                tkn);

        /// <summary><see cref="HtmlElement.DoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> DoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DoubleClick += h,
                h => he.DoubleClick -= h,
                tkn);

        /// <summary><see cref="HtmlElement.DragEnd"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> DragEndAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DragEnd += h,
                h => he.DragEnd -= h,
                tkn);

        /// <summary><see cref="HtmlElement.DragLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> DragLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DragLeave += h,
                h => he.DragLeave -= h,
                tkn);

        /// <summary><see cref="HtmlElement.DragOver"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> DragOverAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.DragOver += h,
                h => he.DragOver -= h,
                tkn);

        /// <summary><see cref="HtmlElement.Drag"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> DragAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.Drag += h,
                h => he.Drag -= h,
                tkn);

        /// <summary><see cref="HtmlElement.Focusing"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> FocusingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.Focusing += h,
                h => he.Focusing -= h,
                tkn);

        /// <summary><see cref="HtmlElement.GotFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> GotFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.GotFocus += h,
                h => he.GotFocus -= h,
                tkn);

        /// <summary><see cref="HtmlElement.KeyDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> KeyDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.KeyDown += h,
                h => he.KeyDown -= h,
                tkn);

        /// <summary><see cref="HtmlElement.KeyPress"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> KeyPressAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.KeyPress += h,
                h => he.KeyPress -= h,
                tkn);

        /// <summary><see cref="HtmlElement.KeyUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> KeyUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.KeyUp += h,
                h => he.KeyUp -= h,
                tkn);

        /// <summary><see cref="HtmlElement.LosingFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> LosingFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.LosingFocus += h,
                h => he.LosingFocus -= h,
                tkn);

        /// <summary><see cref="HtmlElement.LostFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> LostFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.LostFocus += h,
                h => he.LostFocus -= h,
                tkn);

        /// <summary><see cref="HtmlElement.MouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseDown += h,
                h => he.MouseDown -= h,
                tkn);

        /// <summary><see cref="HtmlElement.MouseEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseEnter += h,
                h => he.MouseEnter -= h,
                tkn);

        /// <summary><see cref="HtmlElement.MouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseLeave += h,
                h => he.MouseLeave -= h,
                tkn);

        /// <summary><see cref="HtmlElement.MouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseMoveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseMove += h,
                h => he.MouseMove -= h,
                tkn);

        /// <summary><see cref="HtmlElement.MouseOver"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseOverAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseOver += h,
                h => he.MouseOver -= h,
                tkn);

        /// <summary><see cref="HtmlElement.MouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<HtmlElementEventArgs> MouseUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
                h => (s, e) => h(e),
                h => he.MouseUp += h,
                h => he.MouseUp -= h,
                tkn);
    }
}
