using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripContentPanel"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class ToolStripContentPanelR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    /// <summary><see cref="ToolStripContentPanel"/> extension methods.</summary>
    extension(ToolStripContentPanel tscp)
    {
        /// <summary><see cref="ToolStripContentPanel.Load"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> LoadAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscp.Load += h,
                h => tscp.Load -= h,
                tkn);

        /// <summary><see cref="ToolStripContentPanel.RendererChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RendererChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscp.RendererChanged += h,
                h => tscp.RendererChanged -= h,
                tkn);
    }
#endif
}
