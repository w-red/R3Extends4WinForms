using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStrip"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripR3Extends
{
    /// <summary><see cref="ToolStrip"/> extension methods.</summary>
    extension(ToolStrip ts)
    {
        /// <summary><see cref="ToolStrip.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AutoSizeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.AutoSizeChanged += h,
                h => ts.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.BeginDrag"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BeginDragAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.BeginDrag += h,
                h => ts.BeginDrag -= h,
                tkn);

        /// <summary><see cref="ToolStrip.EndDrag"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> EndDragAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.EndDrag += h,
                h => ts.EndDrag -= h,
                tkn);

        /// <summary><see cref="ToolStrip.CausesValidationChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CausesValidationChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.CausesValidationChanged += h,
                h => ts.CausesValidationChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.CursorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CursorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.CursorChanged += h,
                h => ts.CursorChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ForeColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ForeColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.ForeColorChanged += h,
                h => ts.ForeColorChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ItemAdded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ToolStripItemEventArgs> ItemAddedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolStripItemEventHandler, ToolStripItemEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemAdded += h,
                h => ts.ItemAdded -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ItemRemoved"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ToolStripItemEventArgs> ItemRemovedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolStripItemEventHandler, ToolStripItemEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemRemoved += h,
                h => ts.ItemRemoved -= h,
                tkn);

        /// <summary><see cref="ToolStrip.ItemClicked"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ToolStripItemClickedEventArgs> ItemClickedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolStripItemClickedEventHandler, ToolStripItemClickedEventArgs>(
                h => (s, e) => h(e),
                h => ts.ItemClicked += h,
                h => ts.ItemClicked -= h,
                tkn);

        /// <summary><see cref="ToolStrip.LayoutCompleted"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LayoutCompletedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.LayoutCompleted += h,
                h => ts.LayoutCompleted -= h,
                tkn);

        /// <summary><see cref="ToolStrip.LayoutStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LayoutStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.LayoutStyleChanged += h,
                h => ts.LayoutStyleChanged -= h,
                tkn);

        /// <summary><see cref="ToolStrip.PaintGrip"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<PaintEventArgs> PaintGripAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => ts.PaintGrip += h,
                h => ts.PaintGrip -= h,
                tkn);

        /// <summary><see cref="ToolStrip.RendererChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RendererChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ts.RendererChanged += h,
                h => ts.RendererChanged -= h,
                tkn);
    }
}
