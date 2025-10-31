using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="Form"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class R3ExtendsForm
    {
        /// <summary><see cref="Form.Load"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LoadAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Load += h,
                h => frm.Load -= h,
                tkn);

        /// <summary><see cref="Form.Closing"/> as <see cref="Observable"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CancelEventArgs> ClosingAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => frm.Closing += h,
                h => frm.Closing -= h,
                tkn);

        /// <summary><see cref="Form.Closed"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClosedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Closed += h,
                h => frm.Closed -= h,
                tkn);

        /// <summary><see cref="Form.FormClosing"/> as <see cref="Observable"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<FormClosingEventArgs> FormClosingAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<FormClosingEventHandler, FormClosingEventArgs>(
                h => (s, e) => h(e),
                h => frm.FormClosing += h,
                h => frm.FormClosing -= h,
                tkn);

        /// <summary><see cref="Form.FormClosed"/> as <see cref="Observable"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<FormClosedEventArgs> FormClosedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<FormClosedEventHandler, FormClosedEventArgs>(
                h => (s, e) => h(e),
                h => frm.FormClosed += h,
                h => frm.FormClosed -= h,
                tkn);

        /// <summary><see cref="Form.Activated"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ActivatedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Activated += h,
                h => frm.Activated -= h,
                tkn);

        /// <summary><see cref="Form.Deactivate"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DeactivateAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Deactivate += h,
                h => frm.Deactivate -= h,
                tkn);

        /// <summary><see cref="Form.Shown"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ShownAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Shown += h,
                h => frm.Shown -= h,
                tkn);

        /// <summary><see cref="Form.HelpButtonClicked"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CancelEventArgs> HelpButtonClickedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => frm.HelpButtonClicked += h,
                h => frm.HelpButtonClicked -= h,
                tkn);

        /// <summary><see cref="Form.AutoSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoSizeChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.AutoSizeChanged += h,
                h => frm.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="Form.AutoValidateChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoValidateChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.AutoValidateChanged += h,
                h => frm.AutoValidateChanged -= h,
                tkn);

        /// <summary><see cref="Form.DpiChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DpiChangedEventArgs> DpiChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DpiChangedEventHandler, DpiChangedEventArgs>(
                h => (s, e) => h(e),
                h => frm.DpiChanged += h,
                h => frm.DpiChanged -= h,
                tkn);

        /// <summary><see cref="Form.InputLanguageChanging"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<InputLanguageChangingEventArgs> InputLanguageChangingAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<InputLanguageChangingEventHandler, InputLanguageChangingEventArgs>(
                h => (s, e) => h(e),
                h => frm.InputLanguageChanging += h,
                h => frm.InputLanguageChanging -= h,
                tkn);

        /// <summary><see cref="Form.InputLanguageChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<InputLanguageChangedEventArgs> InputLanguageChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<InputLanguageChangedEventHandler, InputLanguageChangedEventArgs>(
                h => (s, e) => h(e),
                h => frm.InputLanguageChanged += h,
                h => frm.InputLanguageChanged -= h,
                tkn);

        /// <summary><see cref="Form.MaximizedBoundsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MaximizedBoundsChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MaximizedBoundsChanged += h,
                h => frm.MaximizedBoundsChanged -= h,
                tkn);

        /// <summary><see cref="Form.MaximumSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MaximumSizeChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MaximumSizeChanged += h,
                h => frm.MaximumSizeChanged -= h,
                tkn);

        /// <summary><see cref="Form.MinimumSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MinimumSizeChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MinimumSizeChanged += h,
                h => frm.MinimumSizeChanged -= h,
                tkn);

        /// <summary><see cref="Form.MdiChildActivate"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MdiChildActivateAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MdiChildActivate += h,
                h => frm.MdiChildActivate -= h,
                tkn);

        /// <summary><see cref="Form.MenuStart"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MenuStartAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MenuStart += h,
                h => frm.MenuStart -= h,
                tkn);

        /// <summary><see cref="Form.MenuComplete"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MenuCompleteAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.MenuComplete += h,
                h => frm.MenuComplete -= h,
                tkn);

        /// <summary><see cref="Form.ResizeBegin"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ResizeBeginAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.ResizeBegin += h,
                h => frm.ResizeBegin -= h,
                tkn);

        /// <summary><see cref="Form.ResizeEnd"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ResizeEndAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.ResizeEnd += h,
                h => frm.ResizeEnd -= h,
                tkn);

        /// <summary><see cref="Form.RightToLeftLayoutChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.RightToLeftLayoutChanged += h,
                h => frm.RightToLeftLayoutChanged -= h,
                tkn);
    }
}
