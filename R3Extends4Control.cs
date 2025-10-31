using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="Control"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class R3Extends4Control
    {
        /// <summary><see cref="Control.BackColorChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BackColorChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BackColorChanged += h,
                h => ctrl.BackColorChanged -= h,
                tkn);

        /// <summary><see cref="Control.ForeColorChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ForeColorChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ForeColorChanged += h,
                h => ctrl.ForeColorChanged -= h,
                tkn);

        /// <summary><see cref="Control.SystemColorsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> SystemColorsChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.SystemColorsChanged += h,
                h => ctrl.SystemColorsChanged -= h,
                tkn);

        /// <summary><see cref="Control.BackgroundImageChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BackgroundImageChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BackgroundImageChanged += h,
                h => ctrl.BackgroundImageChanged -= h,
                tkn);

        /// <summary><see cref="Control.BackgroundImageLayoutChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BackgroundImageLayoutChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BackgroundImageLayoutChanged += h,
                h => ctrl.BackgroundImageLayoutChanged -= h,
                tkn);

        /// <summary><see cref="Control.BindingContextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BindingContextChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.BindingContextChanged += h,
                h => ctrl.BindingContextChanged -= h,
                tkn);

        /// <summary><see cref="Control.CausesValidationChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CausesValidationChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.CausesValidationChanged += h,
                h => ctrl.CausesValidationChanged -= h,
                tkn);

        /// <summary><see cref="Control.ChangeUICues"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<UICuesEventArgs> ChangeUICuesAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<UICuesEventHandler, UICuesEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ChangeUICues += h,
                h => ctrl.ChangeUICues -= h,
                tkn);

        /// <summary><see cref="Control.ClientSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClientSizeChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ClientSizeChanged += h,
                h => ctrl.ClientSizeChanged -= h,
                tkn);

        /// <summary><see cref="Control.ContextMenuStripChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ContextMenuStripChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ContextMenuStripChanged += h,
                h => ctrl.ContextMenuStripChanged -= h,
                tkn);

        /// <summary><see cref="Control.ControlAdded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ControlEventArgs> ControlAddedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ControlEventHandler, ControlEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ControlAdded += h,
                h => ctrl.ControlAdded -= h,
                tkn);

        /// <summary><see cref="Control.ControlRemoved"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ControlEventArgs> ControlRemovedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ControlEventHandler, ControlEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ControlRemoved += h,
                h => ctrl.ControlRemoved -= h,
                tkn);

        /// <summary><see cref="Control.CursorChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CursorChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.CursorChanged += h,
                h => ctrl.CursorChanged -= h,
                tkn);

        /// <summary><see cref="Control.DataContextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DataContextChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DataContextChanged += h,
                h => ctrl.DataContextChanged -= h,
                tkn);

        /// <summary><see cref="Control.DockChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DockChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DockChanged += h,
                h => ctrl.DockChanged -= h,
                tkn);

        /// <summary><see cref="Control.DpiChangedAfterParent"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DpiChangedAfterParentAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DpiChangedAfterParent += h,
                h => ctrl.DpiChangedAfterParent -= h,
                tkn);

        /// <summary><see cref="Control.DpiChangedBeforeParent"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DpiChangedBeforeParentAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DpiChangedBeforeParent += h,
                h => ctrl.DpiChangedBeforeParent -= h,
                tkn);

        /// <summary><see cref="Control.DragDrop"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DragEventArgs> DragDropAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragDrop += h,
                h => ctrl.DragDrop -= h,
                tkn);

        /// <summary><see cref="Control.DragEnter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DragEventArgs> DragEnterAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragEnter += h,
                h => ctrl.DragEnter -= h,
                tkn);

        /// <summary><see cref="Control.DragOver"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DragEventArgs> DragOverAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragOver += h,
                h => ctrl.DragOver -= h,
                tkn);

        /// <summary><see cref="Control.DragLeave"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DragLeaveAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DragLeave += h,
                h => ctrl.DragLeave -= h,
                tkn);

        /// <summary><see cref="Control.GiveFeedback"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<GiveFeedbackEventArgs> GiveFeedbackAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<GiveFeedbackEventHandler, GiveFeedbackEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.GiveFeedback += h,
                h => ctrl.GiveFeedback -= h,
                tkn);

        /// <summary><see cref="Control.EnabledChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> EnabledChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.EnabledChanged += h,
                h => ctrl.EnabledChanged -= h,
                tkn);

        /// <summary><see cref="Control.FontChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> FontChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.FontChanged += h,
                h => ctrl.FontChanged -= h,
                tkn);

        /// <summary><see cref="Control.Click"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClickAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Click += h,
                h => ctrl.Click -= h,
                tkn);

        /// <summary><see cref="Control.DoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DoubleClickAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.DoubleClick += h,
                h => ctrl.DoubleClick -= h,
                tkn);

        /// <summary><see cref="Control.Enter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> EnterAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Enter += h,
                h => ctrl.Enter -= h,
                tkn);

        /// <summary><see cref="Control.Leave"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LeaveAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Leave += h,
                h => ctrl.Leave -= h,
                tkn);

        /// <summary><see cref="Control.GotFocus"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> GotFocusAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.GotFocus += h,
                h => ctrl.GotFocus -= h,
                tkn);

        /// <summary><see cref="Control.LostFocus"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LostFocusAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.LostFocus += h,
                h => ctrl.LostFocus -= h,
                tkn);

        /// <summary><see cref="Control.HandleCreated"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> HandleCreatedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.HandleCreated += h,
                h => ctrl.HandleCreated -= h,
                tkn);

        /// <summary><see cref="Control.HandleDestroyed"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> HandleDestroyedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.HandleDestroyed += h,
                h => ctrl.HandleDestroyed -= h,
                tkn);

        /// <summary><see cref="Control.HelpRequested"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<HelpEventArgs> HelpRequestedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<HelpEventHandler, HelpEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.HelpRequested += h,
                h => ctrl.HelpRequested -= h,
                tkn);

        /// <summary><see cref="Control.ImeModeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ImeModeChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ImeModeChanged += h,
                h => ctrl.ImeModeChanged -= h,
                tkn);

        /// <summary><see cref="Control.RightToLeftChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RightToLeftChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.RightToLeftChanged += h,
                h => ctrl.RightToLeftChanged -= h,
                tkn);

        /// <summary><see cref="Control.Invalidated"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<InvalidateEventArgs> InvalidatedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<InvalidateEventHandler, InvalidateEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Invalidated += h,
                h => ctrl.Invalidated -= h,
                tkn);

        /// <summary><see cref="Control.KeyDown"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<KeyEventArgs> KeyDownAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.KeyDown += h,
                h => ctrl.KeyDown -= h,
                tkn);

        /// <summary><see cref="Control.PreviewKeyDown"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<PreviewKeyDownEventArgs> PreviewKeyDownAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<PreviewKeyDownEventHandler, PreviewKeyDownEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.PreviewKeyDown += h,
                h => ctrl.PreviewKeyDown -= h,
                tkn);

        /// <summary><see cref="Control.QueryAccessibilityHelp"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<QueryAccessibilityHelpEventArgs> QueryAccessibilityHelpAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<QueryAccessibilityHelpEventHandler, QueryAccessibilityHelpEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.QueryAccessibilityHelp += h,
                h => ctrl.QueryAccessibilityHelp -= h,
                tkn);

        /// <summary><see cref="Control.QueryContinueDrag"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<QueryContinueDragEventArgs> QueryContinueDragAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<QueryContinueDragEventHandler, QueryContinueDragEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.QueryContinueDrag += h,
                h => ctrl.QueryContinueDrag -= h,
                tkn);

        /// <summary><see cref="Control.RegionChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RegionChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.RegionChanged += h,
                h => ctrl.RegionChanged -= h,
                tkn);

        /// <summary><see cref="Control.Resize"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ResizeAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Resize += h,
                h => ctrl.Resize -= h,
                tkn);

        /// <summary><see cref="Control.SizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> SizeChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.SizeChanged += h,
                h => ctrl.SizeChanged -= h,
                tkn);

        /// <summary><see cref="Control.StyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> StyleChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.StyleChanged += h,
                h => ctrl.StyleChanged -= h,
                tkn);

        /// <summary><see cref="Control.KeyUp"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<KeyEventArgs> KeyUpAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.KeyUp += h,
                h => ctrl.KeyUp -= h,
                tkn);

        /// <summary><see cref="Control.KeyPress"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<KeyPressEventArgs> KeyPressAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.KeyPress += h,
                h => ctrl.KeyPress -= h,
                tkn);

        /// <summary><see cref="Control.ParentChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ParentChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.ParentChanged += h,
                h => ctrl.ParentChanged -= h,
                tkn);

        /// <summary><see cref="Control.Layout"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<LayoutEventArgs> LayoutAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<LayoutEventHandler, LayoutEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Layout += h,
                h => ctrl.Layout -= h,
                tkn);

        /// <summary><see cref="Control.LocationChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LocationChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.LocationChanged += h,
                h => ctrl.LocationChanged -= h,
                tkn);

        /// <summary><see cref="Control.MarginChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MarginChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MarginChanged += h,
                h => ctrl.MarginChanged -= h,
                tkn);

        /// <summary><see cref="Control.PaddingChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> PaddingChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.PaddingChanged += h,
                h => ctrl.PaddingChanged -= h,
                tkn);

        /// <summary><see cref="Control.Paint"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<PaintEventArgs> PaintAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<PaintEventHandler, PaintEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Paint += h,
                h => ctrl.Paint -= h,
                tkn);

        /// <summary><see cref="Control.TabIndexChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TabIndexChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.TabIndexChanged += h,
                h => ctrl.TabIndexChanged -= h,
                tkn);

        /// <summary><see cref="Control.TabStopChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TabStopChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.TabStopChanged += h,
                h => ctrl.TabStopChanged -= h,
                tkn);

        /// <summary><see cref="Control.TextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TextChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.TextChanged += h,
                h => ctrl.TextChanged -= h,
                tkn);

        /// <summary><see cref="Control.Validated"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ValidatedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Validated += h,
                h => ctrl.Validated -= h,
                tkn);

        /// <summary><see cref="Control.Validating"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CancelEventArgs> ValidatingAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Validating += h,
                h => ctrl.Validating -= h,
                tkn);

        /// <summary><see cref="Control.VisibleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> VisibleChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.VisibleChanged += h,
                h => ctrl.VisibleChanged -= h,
                tkn);

        /// <summary><see cref="Control.MouseCaptureChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseCaptureChangedAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseCaptureChanged += h,
                h => ctrl.MouseCaptureChanged -= h,
                tkn);

        /// <summary><see cref="Control.MouseClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseClickAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseClick += h,
                h => ctrl.MouseClick -= h,
                tkn);

        /// <summary><see cref="Control.MouseDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseDoubleClickAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseDoubleClick += h,
                h => ctrl.MouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="Control.MouseDown"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseDownAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseDown += h,
                h => ctrl.MouseDown -= h,
                tkn);

        /// <summary><see cref="Control.MouseUp"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseUpAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseUp += h,
                h => ctrl.MouseUp -= h,
                tkn);

        /// <summary><see cref="Control.MouseWheel"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseWheelAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseWheel += h,
                h => ctrl.MouseWheel -= h,
                tkn);

        /// <summary><see cref="Control.MouseMove"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseMoveAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseMove += h,
                h => ctrl.MouseMove -= h,
                tkn);

        /// <summary><see cref="Control.MouseHover"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseHoverAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseHover += h,
                h => ctrl.MouseHover -= h,
                tkn);

        /// <summary><see cref="Control.MouseEnter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseEnterAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseEnter += h,
                h => ctrl.MouseEnter -= h,
                tkn);

        /// <summary><see cref="Control.MouseLeave"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseLeaveAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.MouseLeave += h,
                h => ctrl.MouseLeave -= h,
                tkn);

        /// <summary><see cref="Control.Move"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ctrl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MoveAsObservable(
            this Control ctrl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ctrl.Move += h,
                h => ctrl.Move -= h,
                tkn);
    }
}
