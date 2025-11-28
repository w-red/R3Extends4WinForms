using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="BindingSource"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class BindingSourceR3Extends
{
    /// <summary><see cref="BindingSource.AddingNew"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<AddingNewEventArgs> AddingNewAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<AddingNewEventHandler, AddingNewEventArgs>(
            h => (s, e) => h(e),
            h => bs.AddingNew += h,
            h => bs.AddingNew -= h,
            tkn);

    /// <summary><see cref="BindingSource.BindingComplete"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<BindingCompleteEventArgs> BindingCompleteAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
            h => (s, e) => h(e),
            h => bs.BindingComplete += h,
            h => bs.BindingComplete -= h,
            tkn);

    /// <summary><see cref="BindingSource.CurrentChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CurrentChangedAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bs.CurrentChanged += h,
            h => bs.CurrentChanged -= h,
            tkn);

    /// <summary><see cref="BindingSource.CurrentItemChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> CurrentItemChangedAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bs.CurrentItemChanged += h,
            h => bs.CurrentItemChanged -= h,
            tkn);

    /// <summary><see cref="BindingSource.DataError"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<BindingManagerDataErrorEventArgs> DataErrorAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
            h => (s, e) => h(e),
            h => bs.DataError += h,
            h => bs.DataError -= h,
            tkn);

    /// <summary><see cref="BindingSource.DataMemberChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DataMemberChangedAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bs.DataMemberChanged += h,
            h => bs.DataMemberChanged -= h,
            tkn);

    /// <summary><see cref="BindingSource.DataSourceChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> DataSourceChangedAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bs.DataSourceChanged += h,
            h => bs.DataSourceChanged -= h,
            tkn);

    /// <summary><see cref="BindingSource.ListChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ListChangedEventArgs> ListChangedAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ListChangedEventHandler, ListChangedEventArgs>(
            h => (s, e) => h(e),
            h => bs.ListChanged += h,
            h => bs.ListChanged -= h,
            tkn);

    /// <summary><see cref="BindingSource.PositionChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bs">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> PositionChangedAsObservable(
        this BindingSource bs,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bs.PositionChanged += h,
            h => bs.PositionChanged -= h,
            tkn);
}
