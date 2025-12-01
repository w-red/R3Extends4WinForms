using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripComboBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripComboBoxR3Extends
{
    /// <summary><see cref="ToolStripComboBox"/> extension methods.</summary>
    extension(ToolStripComboBox tscb)
    {
        /// <summary><see cref="ToolStripComboBox.DropDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DropDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.DropDown += h,
                h => tscb.DropDown -= h,
                tkn);

        /// <summary><see cref="ToolStripComboBox.DropDownClosed"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DropDownClosedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.DropDownClosed += h,
                h => tscb.DropDownClosed -= h,
                tkn);

        /// <summary><see cref="ToolStripComboBox.DropDownStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DropDownStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.DropDownStyleChanged += h,
                h => tscb.DropDownStyleChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripComboBox.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectedIndexChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.SelectedIndexChanged += h,
                h => tscb.SelectedIndexChanged -= h,
                tkn);

        /// <summary><see cref="ToolStripComboBox.TextUpdate"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextUpdateAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tscb.TextUpdate += h,
                h => tscb.TextUpdate -= h,
                tkn);
    }
}
