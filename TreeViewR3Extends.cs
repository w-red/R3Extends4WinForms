using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="TreeView"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class TreeViewR3Extends
    {
        /// <summary><see cref="TreeView.AfterCheck"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewEventArgs> AfterCheckAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterCheck += h,
                h => tv.AfterCheck -= h,
                tkn);

        /// <summary><see cref="TreeView.AfterCollapse"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewEventArgs> AfterCollapseAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterCollapse += h,
                h => tv.AfterCollapse -= h,
                tkn);

        /// <summary><see cref="TreeView.AfterExpand"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewEventArgs> AfterExpandAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterExpand += h,
                h => tv.AfterExpand -= h,
                tkn);

        /// <summary><see cref="TreeView.AfterLabelEdit"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<NodeLabelEditEventArgs> AfterLabelEditAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<NodeLabelEditEventHandler, NodeLabelEditEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterLabelEdit += h,
                h => tv.AfterLabelEdit -= h,
                tkn);

        /// <summary><see cref="TreeView.AfterSelect"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewEventArgs> AfterSelectAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewEventHandler, TreeViewEventArgs>(
                h => (s, e) => h(e),
                h => tv.AfterSelect += h,
                h => tv.AfterSelect -= h,
                tkn);

        /// <summary><see cref="TreeView.BeforeCheck"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewCancelEventArgs> BeforeCheckAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeCheck += h,
                h => tv.BeforeCheck -= h,
                tkn);

        /// <summary><see cref="TreeView.BeforeCollapse"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewCancelEventArgs> BeforeCollapseAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeCollapse += h,
                h => tv.BeforeCollapse -= h,
                tkn);

        /// <summary><see cref="TreeView.BeforeExpand"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewCancelEventArgs> BeforeExpandAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeExpand += h,
                h => tv.BeforeExpand -= h,
                tkn);

        /// <summary><see cref="TreeView.BeforeLabelEdit"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<NodeLabelEditEventArgs> BeforeLabelEditAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<NodeLabelEditEventHandler, NodeLabelEditEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeLabelEdit += h,
                h => tv.BeforeLabelEdit -= h,
                tkn);

        /// <summary><see cref="TreeView.BeforeSelect"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeViewCancelEventArgs> BeforeSelectAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeViewCancelEventHandler, TreeViewCancelEventArgs>(
                h => (s, e) => h(e),
                h => tv.BeforeSelect += h,
                h => tv.BeforeSelect -= h,
                tkn);

        /// <summary><see cref="TreeView.DrawNode"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DrawTreeNodeEventArgs> DrawNodeAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawTreeNodeEventHandler, DrawTreeNodeEventArgs>(
                h => (s, e) => h(e),
                h => tv.DrawNode += h,
                h => tv.DrawNode -= h,
                tkn);

        /// <summary><see cref="TreeView.ItemDrag"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ItemDragEventArgs> ItemDragAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ItemDragEventHandler, ItemDragEventArgs>(
                h => (s, e) => h(e),
                h => tv.ItemDrag += h,
                h => tv.ItemDrag -= h,
                tkn);

        /// <summary><see cref="TreeView.NodeMouseClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeNodeMouseClickEventArgs> NodeMouseClickAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeNodeMouseClickEventHandler, TreeNodeMouseClickEventArgs>(
                h => (s, e) => h(e),
                h => tv.NodeMouseClick += h,
                h => tv.NodeMouseClick -= h,
                tkn);

        /// <summary><see cref="TreeView.NodeMouseDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeNodeMouseClickEventArgs> NodeMouseDoubleClickAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeNodeMouseClickEventHandler, TreeNodeMouseClickEventArgs>(
                h => (s, e) => h(e),
                h => tv.NodeMouseDoubleClick += h,
                h => tv.NodeMouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="TreeView.NodeMouseHover"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TreeNodeMouseHoverEventArgs> NodeMouseHoverAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TreeNodeMouseHoverEventHandler, TreeNodeMouseHoverEventArgs>(
                h => (s, e) => h(e),
                h => tv.NodeMouseHover += h,
                h => tv.NodeMouseHover -= h,
                tkn);

        /// <summary><see cref="TreeView.RightToLeftLayoutChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
            this TreeView tv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tv.RightToLeftLayoutChanged += h,
                h => tv.RightToLeftLayoutChanged -= h,
                tkn);
    }
}
