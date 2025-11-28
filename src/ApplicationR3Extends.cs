using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="Application"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ApplicationR3Extends
{
    /// <summary>Extensions for <see cref="Application"/>.</summary>
    extension(Application app)
    {
        /// <summary><see cref="Application.ApplicationExit"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ApplicationExitAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.ApplicationExit += h,
                h => Application.ApplicationExit -= h,
                tkn);

        /// <summary><see cref="Application.EnterThreadModal"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> EnterThreadModalAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.EnterThreadModal += h,
                h => Application.EnterThreadModal -= h,
                tkn);

        /// <summary><see cref="Application.Idle"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> IdleAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.Idle += h,
                h => Application.Idle -= h,
                tkn);

        /// <summary><see cref="Application.LeaveThreadModal"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LeaveThreadModalAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.LeaveThreadModal += h,
                h => Application.LeaveThreadModal -= h,
                tkn);

        /// <summary><see cref="Application.ThreadException"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ThreadExceptionEventArgs> ThreadExceptionAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ThreadExceptionEventHandler, ThreadExceptionEventArgs>(
                h => (s, e) => h(e),
                h => Application.ThreadException += h,
                h => Application.ThreadException -= h,
                tkn);

        /// <summary><see cref="Application.ThreadExit"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ThreadExitAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => Application.ThreadExit += h,
                h => Application.ThreadExit -= h,
                tkn);
    }
}
