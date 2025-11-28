using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="TabControl"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class TabControlR3Extends
{
    /// <summary><see cref="TabControl.Deselected"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<TabControlEventArgs> DeselectedAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<TabControlEventHandler, TabControlEventArgs>(
            h => (s, e) => h(e),
            h => tc.Deselected += h,
            h => tc.Deselected -= h,
            tkn);

    /// <summary><see cref="TabControl.Deselecting"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<TabControlCancelEventArgs> DeselectingAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<TabControlCancelEventHandler, TabControlCancelEventArgs>(
            h => (s, e) => h(e),
            h => tc.Deselecting += h,
            h => tc.Deselecting -= h,
            tkn);

    /// <summary><see cref="TabControl.DrawItem"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<DrawItemEventArgs> DrawItemAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
            h => (s, e) => h(e),
            h => tc.DrawItem += h,
            h => tc.DrawItem -= h,
            tkn);

    /// <summary><see cref="TabControl.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tc.RightToLeftLayoutChanged += h,
            h => tc.RightToLeftLayoutChanged -= h,
            tkn);

    /// <summary><see cref="TabControl.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> SelectedIndexChangedAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => tc.SelectedIndexChanged += h,
            h => tc.SelectedIndexChanged -= h,
            tkn);

    /// <summary><see cref="TabControl.Selected"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<TabControlEventArgs> SelectedAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<TabControlEventHandler, TabControlEventArgs>(
            h => (s, e) => h(e),
            h => tc.Selected += h,
            h => tc.Selected -= h,
            tkn);

    /// <summary><see cref="TabControl.Selecting"/> as <see cref="Observable"/></summary>
    /// <param name="tc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<TabControlCancelEventArgs> SelectingAsObservable(
        this TabControl tc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<TabControlCancelEventHandler, TabControlCancelEventArgs>(
            h => (s, e) => h(e),
            h => tc.Selecting += h,
            h => tc.Selecting -= h,
            tkn);
}
