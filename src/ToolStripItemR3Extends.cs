using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripItem"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripItemR3Extends
{
    /// <summary>Extension methods for <see cref="ToolStripItem"/>.</summary>
    extension(ToolStripItem tsi)
    {
        /// <summary><see cref="ToolStripItem.AvailableChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AvailableChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.AvailableChanged += h,
                h => tsi.AvailableChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.BackColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BackColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.BackColorChanged += h,
                h => tsi.BackColorChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.ForeColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ForeColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.ForeColorChanged += h,
                h => tsi.ForeColorChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.Click"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.Click += h,
                h => tsi.Click -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.DoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.DoubleClick += h,
                h => tsi.DoubleClick -= h,
                tkn);

#if NET7_0_OR_GREATER
        /// <summary><see cref="ToolStripItem.CommandCanExecuteChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CommandCanExecuteChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.CommandCanExecuteChanged += h,
                h => tsi.CommandCanExecuteChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.CommandChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CommandChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.CommandChanged += h,
                h => tsi.CommandChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.CommandParameterChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CommandParameterChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.CommandParameterChanged += h,
                h => tsi.CommandParameterChanged -= h,
                tkn);
#endif

        /// <summary><see cref="ToolStripItem.DisplayStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DisplayStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.DisplayStyleChanged += h,
                h => tsi.DisplayStyleChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.DragDrop"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DragEventArgs> DragDropAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragDrop += h,
                h => tsi.DragDrop -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.DragEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DragEventArgs> DragEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragEnter += h,
                h => tsi.DragEnter -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.DragLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DragLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragLeave += h,
                h => tsi.DragLeave -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.DragOver"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DragEventArgs> DragOverAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.DragOver += h,
                h => tsi.DragOver -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.EnabledChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> EnabledChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.EnabledChanged += h,
                h => tsi.EnabledChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.GiveFeedback"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<GiveFeedbackEventArgs> GiveFeedbackAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                h => (s, e) => h(e),
                h => tsi.GiveFeedback += h,
                h => tsi.GiveFeedback -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.LocationChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LocationChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.LocationChanged += h,
                h => tsi.LocationChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.MouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseDown += h,
                h => tsi.MouseDown -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.MouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseUp += h,
                h => tsi.MouseUp -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.MouseEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseEnter += h,
                h => tsi.MouseEnter -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.MouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseLeave += h,
                h => tsi.MouseLeave -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.MouseHover"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseHoverAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseHover += h,
                h => tsi.MouseHover -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.MouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseMoveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tsi.MouseMove += h,
                h => tsi.MouseMove -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.OwnerChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> OwnerChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.OwnerChanged += h,
                h => tsi.OwnerChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.Paint"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<PaintEventArgs> PaintAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => tsi.Paint += h,
                h => tsi.Paint -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.QueryAccessibilityHelp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                h => (s, e) => h(e),
                h => tsi.QueryAccessibilityHelp += h,
                h => tsi.QueryAccessibilityHelp -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.QueryContinueDrag"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<QueryContinueDragEventArgs> QueryContinueDragAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                h => (s, e) => h(e),
                h => tsi.QueryContinueDrag += h,
                h => tsi.QueryContinueDrag -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.RightToLeftChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RightToLeftChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.RightToLeftChanged += h,
                h => tsi.RightToLeftChanged -= h,
                tkn);

#if NET9_0_OR_GREATER
        /// <summary><see cref="ToolStripItem.SelectedChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectedChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.SelectedChanged += h,
                h => tsi.SelectedChanged -= h,
                tkn);
#endif

        /// <summary><see cref="ToolStripItem.TextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.TextChanged += h,
                h => tsi.TextChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripItem.VisibleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> VisibleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsi.VisibleChanged += h,
                h => tsi.VisibleChanged -= h,
                tkn);
    }
}
