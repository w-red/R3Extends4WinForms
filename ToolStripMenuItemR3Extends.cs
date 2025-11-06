using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripMenuItem"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ToolStripMenuItemR3Extends
    {
        /// <summary><see cref="ToolStripMenuItem.CheckedChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tsmi">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CheckedChangedAsObservable(
            this ToolStripMenuItem tsmi,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsmi.CheckedChanged += h,
                h => tsmi.CheckedChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripMenuItem.CheckStateChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="tsmi">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CheckStateChangedAsObservable(
            this ToolStripMenuItem tsmi,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tsmi.CheckStateChanged += h,
                h => tsmi.CheckStateChanged -= h,
                tkn);
    }
}
