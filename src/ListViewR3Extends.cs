using R3;
using System.Windows.Forms;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ListView"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ListViewR3Extends
    {
        /// <summary><see cref="ListView.BeforeLabelEdit"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<LabelEditEventArgs> BeforeLabelEditAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<LabelEditEventHandler, LabelEditEventArgs>(
                h => (s, e) => h(e),
                h => lv.BeforeLabelEdit += h,
                h => lv.BeforeLabelEdit -= h,
                tkn);

        /// <summary><see cref="ListView.AfterLabelEdit"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<LabelEditEventArgs> AfterLabelEditAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<LabelEditEventHandler, LabelEditEventArgs>(
                h => (s, e) => h(e),
                h => lv.AfterLabelEdit += h,
                h => lv.AfterLabelEdit -= h,
                tkn);

        /// <summary><see cref="ListView.SearchForVirtualItem"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<SearchForVirtualItemEventArgs> SearchForVirtualItemAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<SearchForVirtualItemEventHandler, SearchForVirtualItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.SearchForVirtualItem += h,
                h => lv.SearchForVirtualItem -= h,
                tkn);

        /// <summary><see cref="ListView.CacheVirtualItems"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CacheVirtualItemsEventArgs> CacheVirtualItemsAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CacheVirtualItemsEventHandler, CacheVirtualItemsEventArgs>(
                h => (s, e) => h(e),
                h => lv.CacheVirtualItems += h,
                h => lv.CacheVirtualItems -= h,
                tkn);

        /// <summary><see cref="ListView.RetrieveVirtualItem"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<RetrieveVirtualItemEventArgs> RetrieveVirtualItemAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<RetrieveVirtualItemEventHandler, RetrieveVirtualItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.RetrieveVirtualItem += h,
                h => lv.RetrieveVirtualItem -= h,
                tkn);

        /// <summary><see cref="ListView.ColumnClick"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ColumnClickEventArgs> ColumnClickAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ColumnClickEventHandler, ColumnClickEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnClick += h,
                h => lv.ColumnClick -= h,
                tkn);

        /// <summary><see cref="ListView.ColumnReordered"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ColumnReorderedEventArgs> ColumnReorderedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ColumnReorderedEventHandler, ColumnReorderedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnReordered += h,
                h => lv.ColumnReordered -= h,
                tkn);

        /// <summary><see cref="ListView.ColumnWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ColumnWidthChangedEventArgs> ColumnWidthChangedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ColumnWidthChangedEventHandler, ColumnWidthChangedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnWidthChanged += h,
                h => lv.ColumnWidthChanged -= h,
                tkn);

        /// <summary><see cref="ListView.ColumnWidthChanging"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ColumnWidthChangingEventArgs> ColumnWidthChangingAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ColumnWidthChangingEventHandler, ColumnWidthChangingEventArgs>(
                h => (s, e) => h(e),
                h => lv.ColumnWidthChanging += h,
                h => lv.ColumnWidthChanging -= h,
                tkn);

        /// <summary><see cref="ListView.DrawColumnHeader"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DrawListViewColumnHeaderEventArgs> DrawColumnHeaderAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawListViewColumnHeaderEventHandler, DrawListViewColumnHeaderEventArgs>(
                h => (s, e) => h(e),
                h => lv.DrawColumnHeader += h,
                h => lv.DrawColumnHeader -= h,
                tkn);

        /// <summary><see cref="ListView.DrawItem"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DrawListViewItemEventArgs> DrawItemAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawListViewItemEventHandler, DrawListViewItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.DrawItem += h,
                h => lv.DrawItem -= h,
                tkn);

        /// <summary><see cref="ListView.DrawSubItem"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DrawListViewSubItemEventArgs> DrawSubItemAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawListViewSubItemEventHandler, DrawListViewSubItemEventArgs>(
                h => (s, e) => h(e),
                h => lv.DrawSubItem += h,
                h => lv.DrawSubItem -= h,
                tkn);

#if NET5_0_OR_GREATER
        /// <summary><see cref="ListView.GroupCollapsedStateChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListViewGroupEventArgs> GroupCollapsedStateChangedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler<ListViewGroupEventArgs>, ListViewGroupEventArgs>(
                h => (s, e) => h(e),
                h => lv.GroupCollapsedStateChanged += h,
                h => lv.GroupCollapsedStateChanged -= h,
                tkn);

        /// <summary><see cref="ListView.GroupTaskLinkClick"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListViewGroupEventArgs> GroupTaskLinkClickAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler<ListViewGroupEventArgs>, ListViewGroupEventArgs>(
                h => (s, e) => h(e),
                h => lv.GroupTaskLinkClick += h,
                h => lv.GroupTaskLinkClick -= h,
                tkn);
#endif

        /// <summary><see cref="ListView.ItemActivate"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ItemActivateAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemActivate += h,
                h => lv.ItemActivate -= h,
                tkn);

        /// <summary><see cref="ListView.ItemChecked"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ItemCheckedEventArgs> ItemCheckedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ItemCheckedEventHandler, ItemCheckedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemChecked += h,
                h => lv.ItemChecked -= h,
                tkn);

        /// <summary><see cref="ListView.ItemCheck"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ItemCheckEventArgs> ItemCheckAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ItemCheckEventHandler, ItemCheckEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemCheck += h,
                h => lv.ItemCheck -= h,
                tkn);

        /// <summary><see cref="ListView.ItemDrag"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ItemDragEventArgs> ItemDragAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ItemDragEventHandler, ItemDragEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemDrag += h,
                h => lv.ItemDrag -= h,
                tkn);

        /// <summary><see cref="ListView.ItemMouseHover"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListViewItemMouseHoverEventArgs> ItemMouseHoverAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ListViewItemMouseHoverEventHandler, ListViewItemMouseHoverEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemMouseHover += h,
                h => lv.ItemMouseHover -= h,
                tkn);

        /// <summary><see cref="ListView.ItemSelectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListViewItemSelectionChangedEventArgs> ItemSelectionChangedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ListViewItemSelectionChangedEventHandler, ListViewItemSelectionChangedEventArgs>(
                h => (s, e) => h(e),
                h => lv.ItemSelectionChanged += h,
                h => lv.ItemSelectionChanged -= h,
                tkn);

        /// <summary><see cref="ListView.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lv.RightToLeftLayoutChanged += h,
                h => lv.RightToLeftLayoutChanged -= h,
                tkn);

        /// <summary><see cref="ListView.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> SelectedIndexChangedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lv.SelectedIndexChanged += h,
                h => lv.SelectedIndexChanged -= h,
                tkn);

        /// <summary><see cref="ListView.VirtualItemsSelectionRangeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListViewVirtualItemsSelectionRangeChangedEventArgs> VirtualItemsSelectionRangeChangedAsObservable(
            this ListView lv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ListViewVirtualItemsSelectionRangeChangedEventHandler, ListViewVirtualItemsSelectionRangeChangedEventArgs>(
                h => (s, e) => h(e),
                h => lv.VirtualItemsSelectionRangeChanged += h,
                h => lv.VirtualItemsSelectionRangeChanged -= h,
                tkn);
    }
}
