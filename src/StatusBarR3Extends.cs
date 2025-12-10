using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="StatusBar"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class StatusBarR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    /// <summary><see cref="StatusBar"/> extension methods.</summary>
    extension(StatusBar sb)
    {
        /// <summary><see cref="StatusBar.DrawItem"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<StatusBarDrawItemEventArgs> DrawItemAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<StatusBarDrawItemEventHandler, StatusBarDrawItemEventArgs>(
                h => (s, e) => h(e),
                h => sb.DrawItem += h,
                h => sb.DrawItem -= h,
                tkn);

        /// <summary><see cref="StatusBar.PanelClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<StatusBarPanelClickEventArgs> PanelClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<StatusBarPanelClickEventHandler, StatusBarPanelClickEventArgs>(
                h => (s, e) => h(e),
                h => sb.PanelClick += h,
                h => sb.PanelClick -= h,
                tkn);
    }
#endif
}
