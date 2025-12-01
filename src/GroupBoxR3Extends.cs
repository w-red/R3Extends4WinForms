using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="GroupBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class GroupBoxR3Extends
{
    /// <summary><see cref="GroupBox"/> extension methods.</summary>
    extension(GroupBox gb)
    {
        /// <summary><see cref="GroupBox.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AutoSizeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.AutoSizeChanged += h,
                h => gb.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="GroupBox.Click"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.Click += h,
                h => gb.Click -= h,
                tkn);

        /// <summary><see cref="GroupBox.DoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.DoubleClick += h,
                h => gb.DoubleClick -= h,
                tkn);

        /// <summary><see cref="GroupBox.KeyDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyEventArgs> KeyDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => gb.KeyDown += h,
                h => gb.KeyDown -= h,
                tkn);

        /// <summary><see cref="GroupBox.KeyUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyEventArgs> KeyUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => gb.KeyUp += h,
                h => gb.KeyUp -= h,
                tkn);

        /// <summary><see cref="GroupBox.KeyPress"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyPressEventArgs> KeyPressAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => gb.KeyPress += h,
                h => gb.KeyPress -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseClick += h,
                h => gb.MouseClick -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseDoubleClick += h,
                h => gb.MouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseDown += h,
                h => gb.MouseDown -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseUp += h,
                h => gb.MouseUp -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseEnter += h,
                h => gb.MouseEnter -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseLeave += h,
                h => gb.MouseLeave -= h,
                tkn);

        /// <summary><see cref="GroupBox.MouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseMoveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => gb.MouseMove += h,
                h => gb.MouseMove -= h,
                tkn);

        /// <summary><see cref="GroupBox.TabStopChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TabStopChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => gb.TabStopChanged += h,
                h => gb.TabStopChanged -= h,
                tkn);
    }
}
