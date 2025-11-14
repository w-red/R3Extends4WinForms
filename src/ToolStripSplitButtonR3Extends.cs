using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripSplitButton"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ToolStripSplitButtonR3Extends
    {
        /// <summary><see cref="ToolStripSplitButton.ButtonClick"/> as <see cref="Observable"/></summary>
        /// <param name="tssb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ButtonClickAsObservable(
            this ToolStripSplitButton tssb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tssb.ButtonClick += h,
                h => tssb.ButtonClick -= h,
                tkn);

        /// <summary><see cref="ToolStripSplitButton.ButtonDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tssb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ButtonDoubleClickAsObservable(
            this ToolStripSplitButton tssb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tssb.ButtonDoubleClick += h,
                h => tssb.ButtonDoubleClick -= h,
                tkn);

        /// <summary><see cref="ToolStripSplitButton.DefaultItemChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tssb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DefaultItemChangedAsObservable(
            this ToolStripSplitButton tssb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tssb.DefaultItemChanged += h,
                h => tssb.DefaultItemChanged -= h,
                tkn);
    }
}
