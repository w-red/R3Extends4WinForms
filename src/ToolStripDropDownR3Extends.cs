using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripDropDown"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripDropDownR3Extends
{
    /// <summary><see cref="ToolStripDropDown.BackgroundImageChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BackgroundImageChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.BackgroundImageChanged += h,
            h => tsdd.BackgroundImageChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.BackgroundImageLayoutChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BackgroundImageLayoutChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.BackgroundImageLayoutChanged += h,
            h => tsdd.BackgroundImageLayoutChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.BindingContextChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BindingContextChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.BindingContextChanged += h,
            h => tsdd.BindingContextChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.ChangeUICues"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<UICuesEventArgs> ChangeUICuesAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.ChangeUICues += h,
            h => tsdd.ChangeUICues -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.Closed"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripDropDownClosedEventArgs> ClosedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripDropDownClosedEventHandler, ToolStripDropDownClosedEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.Closed += h,
            h => tsdd.Closed -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.Closing"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripDropDownClosingEventArgs> ClosingAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripDropDownClosingEventHandler, ToolStripDropDownClosingEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.Closing += h,
            h => tsdd.Closing -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.ContextMenuStripChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> ContextMenuStripChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.ContextMenuStripChanged += h,
            h => tsdd.ContextMenuStripChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.DockChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DockChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.DockChanged += h,
            h => tsdd.DockChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.Enter"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> EnterAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.Enter += h,
            h => tsdd.Enter -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.Leave"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> LeaveAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.Leave += h,
            h => tsdd.Leave -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.FontChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> FontChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.FontChanged += h,
            h => tsdd.FontChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.HelpRequested"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<HelpEventArgs> HelpRequestedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<HelpEventHandler, HelpEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.HelpRequested += h,
            h => tsdd.HelpRequested -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.ImeModeChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> ImeModeChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.ImeModeChanged += h,
            h => tsdd.ImeModeChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.KeyDown"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<KeyEventArgs> KeyDownAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.KeyDown += h,
            h => tsdd.KeyDown -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.KeyUp"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<KeyEventArgs> KeyUpAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.KeyUp += h,
            h => tsdd.KeyUp -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.KeyPress"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<KeyPressEventArgs> KeyPressAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.KeyPress += h,
            h => tsdd.KeyPress -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.Opened"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> OpenedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.Opened += h,
            h => tsdd.Opened -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.Opening"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<CancelEventArgs> OpeningAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
            h => (s, e) => h(e),
            h => tsdd.Opening += h,
            h => tsdd.Opening -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.RegionChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> RegionChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.RegionChanged += h,
            h => tsdd.RegionChanged -= h,
            tkn);

    /// <summary><see cref="ToolStripDropDown.StyleChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tsdd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> StyleChangedAsObservable(
        this ToolStripDropDown tsdd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tsdd.StyleChanged += h,
            h => tsdd.StyleChanged -= h,
            tkn);
}
