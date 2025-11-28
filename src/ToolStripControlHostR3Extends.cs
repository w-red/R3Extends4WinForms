using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripControlHost"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripControlHostR3Extends
{
    /// <summary><see cref="ToolStripControlHost"/> extension methods.</summary>
    extension(ToolStripControlHost tsch)
    {
        /// <summary><see cref="ToolStripControlHost.Enter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> EnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.Enter += h,
                h => tsch.Enter -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.Leave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.Leave += h,
                h => tsch.Leave -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.GotFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> GotFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.GotFocus += h,
                h => tsch.GotFocus -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.LostFocus"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LostFocusAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.LostFocus += h,
                h => tsch.LostFocus -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.KeyDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyEventArgs> KeyDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => tsch.KeyDown += h,
                h => tsch.KeyDown -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.KeyUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyEventArgs> KeyUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => tsch.KeyUp += h,
                h => tsch.KeyUp -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.KeyPress"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyPressEventArgs> KeyPressAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => tsch.KeyPress += h,
                h => tsch.KeyPress -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.Validated"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ValidatedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsch.Validated += h,
                h => tsch.Validated -= h,
                tkn);

        /// <summary><see cref="ToolStripControlHost.Validating"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<CancelEventArgs> ValidatingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                h => (s, e) => h(e),
                h => tsch.Validating += h,
                h => tsch.Validating -= h,
                tkn);
    }
}
