using R3;
using System.Windows.Forms;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="DataGridTableStyle"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class DataGridTableStyleR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGridTableStyle dgts)
    {
        /// <summary><see cref="DataGridTableStyle.AllowSortingChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowSortingChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.AllowSortingChanged += h,
                h => dgts.AllowSortingChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.AlternatingBackColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AlternatingBackColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.AlternatingBackColorChanged += h,
                h => dgts.AlternatingBackColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.BackColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BackColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.BackColorChanged += h,
                h => dgts.BackColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.ColumnHeadersVisibleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ColumnHeadersVisibleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.ColumnHeadersVisibleChanged += h,
                h => dgts.ColumnHeadersVisibleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.ForeColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ForeColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.ForeColorChanged += h,
                h => dgts.ForeColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.GridLineColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> GridLineColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.GridLineColorChanged += h,
                h => dgts.GridLineColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.GridLineStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> GridLineStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.GridLineStyleChanged += h,
                h => dgts.GridLineStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.HeaderBackColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> HeaderBackColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.HeaderBackColorChanged += h,
                h => dgts.HeaderBackColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.HeaderFontChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> HeaderFontChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.HeaderFontChanged += h,
                h => dgts.HeaderFontChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.HeaderForeColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> HeaderForeColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.HeaderForeColorChanged += h,
                h => dgts.HeaderForeColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.LinkColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LinkColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.LinkColorChanged += h,
                h => dgts.LinkColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.LinkHoverColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LinkHoverColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.LinkHoverColorChanged += h,
                h => dgts.LinkHoverColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.MappingNameChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MappingNameChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.MappingNameChanged += h,
                h => dgts.MappingNameChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.PreferredColumnWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> PreferredColumnWidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.PreferredColumnWidthChanged += h,
                h => dgts.PreferredColumnWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.PreferredRowHeightChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> PreferredRowHeightChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.PreferredRowHeightChanged += h,
                h => dgts.PreferredRowHeightChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ReadOnlyChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.ReadOnlyChanged += h,
                h => dgts.ReadOnlyChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.RowHeadersVisibleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RowHeadersVisibleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.RowHeadersVisibleChanged += h,
                h => dgts.RowHeadersVisibleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.RowHeaderWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RowHeaderWidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.RowHeaderWidthChanged += h,
                h => dgts.RowHeaderWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.SelectionBackColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectionBackColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.SelectionBackColorChanged += h,
                h => dgts.SelectionBackColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridTableStyle.SelectionForeColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectionForeColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgts.SelectionForeColorChanged += h,
                h => dgts.SelectionForeColorChanged -= h,
                tkn);
    }
#endif
}
