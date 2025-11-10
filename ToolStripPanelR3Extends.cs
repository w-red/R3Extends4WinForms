using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripPanel"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ToolStripPanelR3Extends
    {
        /// <summary><see cref="ToolStripPanel.AutoSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tsp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoSizeChangedAsObservable(
            this ToolStripPanel tsp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsp.AutoSizeChanged += h,
                h => tsp.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripPanel.RendererChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tsp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RendererChangedAsObservable(
            this ToolStripPanel tsp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsp.RendererChanged += h,
                h => tsp.RendererChanged -= h,
                tkn);
    }
}
