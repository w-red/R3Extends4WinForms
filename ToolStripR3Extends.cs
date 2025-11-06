using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ToolStrip"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ToolStripR3Extends
    {
        /// <summary><see cref="ToolStrip.AutoSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoSizeChangedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.AutoSizeChanged += h,
                h => ts.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.BeginDrag"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BeginDragAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.BeginDrag += h,
                h => ts.BeginDrag -= h,
                tkn);

        /// <summary><see cref="ToolStrip.EndDrag"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> EndDragAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.EndDrag += h,
                h => ts.EndDrag -= h,
                tkn);

        /// <summary><see cref="ToolStrip.CausesValidationChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CausesValidationChangedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.CausesValidationChanged += h,
                h => ts.CausesValidationChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.CursorChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CursorChangedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.CursorChanged += h,
                h => ts.CursorChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ForeColorChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ForeColorChangedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.ForeColorChanged += h,
                h => ts.ForeColorChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ItemAdded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ToolStripItemEventArgs> ItemAddedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolStripItemEventHandler, ToolStripItemEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemAdded += h,
                h => ts.ItemAdded -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ItemRemoved"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ToolStripItemEventArgs> ItemRemovedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolStripItemEventHandler, ToolStripItemEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemRemoved += h,
                h => ts.ItemRemoved -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ItemClicked"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ToolStripItemClickedEventArgs> ItemClickedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemClicked += h,
                h => ts.ItemClicked -= h,
                tkn);

        /// <summary><see cref="ToolStrip.LayoutCompleted"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LayoutCompletedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.LayoutCompleted += h,
                h => ts.LayoutCompleted -= h,
                tkn);

        /// <summary><see cref="ToolStrip.LayoutStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LayoutStyleChangedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.LayoutStyleChanged += h,
                h => ts.LayoutStyleChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.PaintGrip"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<PaintEventArgs> PaintGripAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => ts.PaintGrip += h,
                h => ts.PaintGrip -= h,
                tkn);

        /// <summary><see cref="ToolStrip.RendererChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ts">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RendererChangedAsObservable(
            this ToolStrip ts,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.RendererChanged += h,
                h => ts.RendererChanged -= h,
                tkn);
    }
}
