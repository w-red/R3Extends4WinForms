using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripContentPanel"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripContentPanelR3Extends
{
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
}
