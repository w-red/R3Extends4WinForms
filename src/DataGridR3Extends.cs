using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="DataGrid"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class DataGridR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGrid dg)
    {
        /// <summary><see cref="DataGrid.AllowNavigationChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowNavigationChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.AllowNavigationChanged += h,
                h => dg.AllowNavigationChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.BackButtonClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BackButtonClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.BackButtonClick += h,
                h => dg.BackButtonClick -= h,
                tkn);

        /// <summary><see cref="DataGrid.BackgroundColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BackgroundColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.BackgroundColorChanged += h,
                h => dg.BackgroundColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BorderStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.BorderStyleChanged += h,
                h => dg.BorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.CaptionVisibleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CaptionVisibleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.CaptionVisibleChanged += h,
                h => dg.CaptionVisibleChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.CurrentCellChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CurrentCellChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.CurrentCellChanged += h,
                h => dg.CurrentCellChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.DataSourceChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DataSourceChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.DataSourceChanged += h,
                h => dg.DataSourceChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.FlatModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> FlatModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.FlatModeChanged += h,
                h => dg.FlatModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.Navigate"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<NavigateEventArgs> NavigateAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<NavigateEventHandler, NavigateEventArgs>(
                h => (s, e) => h(e),
                h => dg.Navigate += h,
                h => dg.Navigate -= h,
                tkn);

        /// <summary><see cref="DataGrid.ParentRowsLabelStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ParentRowsLabelStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ParentRowsLabelStyleChanged += h,
                h => dg.ParentRowsLabelStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.ParentRowsVisibleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ParentRowsVisibleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ParentRowsVisibleChanged += h,
                h => dg.ParentRowsVisibleChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ReadOnlyChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ReadOnlyChanged += h,
                h => dg.ReadOnlyChanged -= h,
                tkn);

        /// <summary><see cref="DataGrid.Scroll"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ScrollAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.Scroll += h,
                h => dg.Scroll -= h,
                tkn);

        /// <summary><see cref="DataGrid.ShowParentDetailsButtonClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ShowParentDetailsButtonClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dg.ShowParentDetailsButtonClick += h,
                h => dg.ShowParentDetailsButtonClick -= h,
                tkn);
    }
#endif
}
