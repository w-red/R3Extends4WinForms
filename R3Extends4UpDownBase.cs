using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="UpDownBase"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class R3Extends4UpDownBase
    {
        /// <summary><see cref="UpDownBase.AutoSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoSizeChangedAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.AutoSizeChanged += h,
                h => udb.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="UpDownBase.BackgroundImageChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BackgroundImageChangedAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.BackgroundImageChanged += h,
                h => udb.BackgroundImageChanged -= h,
                tkn);

        /// <summary><see cref="UpDownBase.BackgroundImageLayoutChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BackgroundImageLayoutChangedAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.BackgroundImageLayoutChanged += h,
                h => udb.BackgroundImageLayoutChanged -= h,
                tkn);

        /// <summary><see cref="UpDownBase.MouseEnter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseEnterAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseEnter += h,
                h => udb.MouseEnter -= h,
                tkn);

        /// <summary><see cref="UpDownBase.MouseLeave"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseLeaveAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseLeave += h,
                h => udb.MouseLeave -= h,
                tkn);

        /// <summary><see cref="UpDownBase.MouseHover"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MouseHoverAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseHover += h,
                h => udb.MouseHover -= h,
                tkn);

        /// <summary><see cref="UpDownBase.MouseMove"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="udb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseMoveAsObservable(
            this UpDownBase udb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => udb.MouseMove += h,
                h => udb.MouseMove -= h,
                tkn);
    }
}
