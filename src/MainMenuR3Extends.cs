using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="MainMenu"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class MainMenuR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    /// <summary><see cref="MainMenu"/> extension methods.</summary>
    extension(MainMenu mm)
    {
        /// <summary><see cref="MainMenu.Collapse"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CollapseAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mm.Collapse += h,
                h => mm.Collapse -= h,
                tkn);
    }
#endif
}
