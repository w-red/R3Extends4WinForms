using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ApplicationContext"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ApplicationContextR3Extends
{
    /// <summary>Extensions for <see cref="ApplicationContext"/>.</summary>
    extension(ApplicationContext ac)
    {
        /// <summary><see cref="ApplicationContext.ThreadExit"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ThreadExitAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ac.ThreadExit += h,
                h => ac.ThreadExit -= h,
                tkn);
    }
}
