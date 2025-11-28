using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="NotifyIcon"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class NotifyIconR3Extends
{
    /// <summary><see cref="NotifyIcon.BalloonTipClicked"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BalloonTipClickedAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ni.BalloonTipClicked += h,
            h => ni.BalloonTipClicked -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.BalloonTipClosed"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BalloonTipClosedAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ni.BalloonTipClosed += h,
            h => ni.BalloonTipClosed -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.BalloonTipShown"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BalloonTipShownAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ni.BalloonTipShown += h,
            h => ni.BalloonTipShown -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.Click"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> ClickAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ni.Click += h,
            h => ni.Click -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.DoubleClick"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DoubleClickAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ni.DoubleClick += h,
            h => ni.DoubleClick -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.MouseClick"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<MouseEventArgs> MouseClickAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
            h => (s, e) => h(e),
            h => ni.MouseClick += h,
            h => ni.MouseClick -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.MouseDoubleClick"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<MouseEventArgs> MouseDoubleClickAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
            h => (s, e) => h(e),
            h => ni.MouseDoubleClick += h,
            h => ni.MouseDoubleClick -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.MouseDown"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<MouseEventArgs> MouseDownAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
            h => (s, e) => h(e),
            h => ni.MouseDown += h,
            h => ni.MouseDown -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.MouseMove"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<MouseEventArgs> MouseMoveAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
            h => (s, e) => h(e),
            h => ni.MouseMove += h,
            h => ni.MouseMove -= h,
            tkn);

    /// <summary><see cref="NotifyIcon.MouseUp"/> as <see cref="Observable"/></summary>
    /// <param name="ni">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<MouseEventArgs> MouseUpAsObservable(
        this NotifyIcon ni,
        CancellationToken tkn = default) =>
        Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
            h => (s, e) => h(e),
            h => ni.MouseUp += h,
            h => ni.MouseUp -= h,
            tkn);
}
