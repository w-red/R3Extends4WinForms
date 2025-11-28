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
    /// <summary><see cref="HtmlElement.Click"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> ClickAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.Click += h,
            h => he.Click -= h,
            tkn);

    /// <summary><see cref="HtmlElement.DoubleClick"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> DoubleClickAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.DoubleClick += h,
            h => he.DoubleClick -= h,
            tkn);

    /// <summary><see cref="HtmlElement.DragEnd"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> DragEndAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.DragEnd += h,
            h => he.DragEnd -= h,
            tkn);

    /// <summary><see cref="HtmlElement.DragLeave"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> DragLeaveAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.DragLeave += h,
            h => he.DragLeave -= h,
            tkn);

    /// <summary><see cref="HtmlElement.DragOver"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> DragOverAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.DragOver += h,
            h => he.DragOver -= h,
            tkn);

    /// <summary><see cref="HtmlElement.Drag"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> DragAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.Drag += h,
            h => he.Drag -= h,
            tkn);

    /// <summary><see cref="HtmlElement.Focusing"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> FocusingAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.Focusing += h,
            h => he.Focusing -= h,
            tkn);

    /// <summary><see cref="HtmlElement.GotFocus"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> GotFocusAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.GotFocus += h,
            h => he.GotFocus -= h,
            tkn);

    /// <summary><see cref="HtmlElement.KeyDown"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> KeyDownAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.KeyDown += h,
            h => he.KeyDown -= h,
            tkn);

    /// <summary><see cref="HtmlElement.KeyPress"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> KeyPressAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.KeyPress += h,
            h => he.KeyPress -= h,
            tkn);

    /// <summary><see cref="HtmlElement.KeyUp"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> KeyUpAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.KeyUp += h,
            h => he.KeyUp -= h,
            tkn);

    /// <summary><see cref="HtmlElement.LosingFocus"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> LosingFocusAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.LosingFocus += h,
            h => he.LosingFocus -= h,
            tkn);

    /// <summary><see cref="HtmlElement.LostFocus"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> LostFocusAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.LostFocus += h,
            h => he.LostFocus -= h,
            tkn);

    /// <summary><see cref="HtmlElement.MouseDown"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> MouseDownAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.MouseDown += h,
            h => he.MouseDown -= h,
            tkn);

    /// <summary><see cref="HtmlElement.MouseEnter"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> MouseEnterAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.MouseEnter += h,
            h => he.MouseEnter -= h,
            tkn);

    /// <summary><see cref="HtmlElement.MouseLeave"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> MouseLeaveAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.MouseLeave += h,
            h => he.MouseLeave -= h,
            tkn);

    /// <summary><see cref="HtmlElement.MouseMove"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> MouseMoveAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.MouseMove += h,
            h => he.MouseMove -= h,
            tkn);

    /// <summary><see cref="HtmlElement.MouseOver"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> MouseOverAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.MouseOver += h,
            h => he.MouseOver -= h,
            tkn);

    /// <summary><see cref="HtmlElement.MouseUp"/> as <see cref="Observable"/></summary>
    /// <param name="he">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HtmlElementEventArgs> MouseUpAsObservable(
        this HtmlElement he,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HtmlElementEventHandler, HtmlElementEventArgs>(
            h => (s, e) => h(e),
            h => he.MouseUp += h,
            h => he.MouseUp -= h,
            tkn);
}
