using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="MenuStrip"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class MenuStripR3Extends
{
    /// <summary><see cref="MenuStrip"/> extension methods.</summary>
    extension(MenuStrip ms)
    {
        /// <summary><see cref="MenuStrip.MenuActivate"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MenuActivateAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ms.MenuActivate += h,
                h => ms.MenuActivate -= h,
                tkn);

        /// <summary><see cref="MenuStrip.MenuDeactivate"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MenuDeactivateAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ms.MenuDeactivate += h,
                h => ms.MenuDeactivate -= h,
                tkn);
    }
}
