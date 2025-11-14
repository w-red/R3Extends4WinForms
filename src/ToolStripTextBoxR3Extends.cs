using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripTextBox"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ToolStripTextBoxR3Extends
    {
        /// <summary><see cref="ToolStripTextBox.AcceptsTabChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tstb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AcceptsTabChangedAsObservable(
            this ToolStripTextBox tstb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.AcceptsTabChanged += h,
                h => tstb.AcceptsTabChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripTextBox.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tstb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BorderStyleChangedAsObservable(
            this ToolStripTextBox tstb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.BorderStyleChanged += h,
                h => tstb.BorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripTextBox.HideSelectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tstb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> HideSelectionChangedAsObservable(
            this ToolStripTextBox tstb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.HideSelectionChanged += h,
                h => tstb.HideSelectionChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripTextBox.ModifiedChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tstb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ModifiedChangedAsObservable(
            this ToolStripTextBox tstb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.ModifiedChanged += h,
                h => tstb.ModifiedChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripTextBox.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tstb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ReadOnlyChangedAsObservable(
            this ToolStripTextBox tstb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.ReadOnlyChanged += h,
                h => tstb.ReadOnlyChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripTextBox.TextBoxTextAlignChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tstb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TextBoxTextAlignChangedAsObservable(
            this ToolStripTextBox tstb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tstb.TextBoxTextAlignChanged += h,
                h => tstb.TextBoxTextAlignChanged -= h,
                tkn);
    }
}
