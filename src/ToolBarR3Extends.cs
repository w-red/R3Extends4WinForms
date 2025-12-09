using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="ToolBar"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class ToolBarR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    /// <summary><see cref="ToolBar"/> extension methods.</summary>
    extension(ToolBar tb)
    {
        /// <summary><see cref="ToolBar.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AutoSizeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.AutoSizeChanged += h,
                h => tb.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="ToolBar.ButtonClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ToolBarButtonClickEventArgs> ButtonClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolBarButtonClickEventHandler, ToolBarButtonClickEventArgs>(
                h => (s, e) => h(e),
                h => tb.ButtonClick += h,
                h => tb.ButtonClick -= h,
                tkn);

        /// <summary><see cref="ToolBar.ButtonDropDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ToolBarButtonClickEventArgs> ButtonDropDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ToolBarButtonClickEventHandler, ToolBarButtonClickEventArgs>(
                h => (s, e) => h(e),
                h => tb.ButtonDropDown += h,
                h => tb.ButtonDropDown -= h,
                tkn);
    }
#endif
}
