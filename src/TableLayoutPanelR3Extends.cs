using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="TableLayoutPanel"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class TableLayoutPanelR3Extends
    {
        /// <summary><see cref="TableLayoutPanel.CellPaint"/> as <see cref="Observable"/></summary>
        /// <param name="tlp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TableLayoutCellPaintEventArgs> CellPaintAsObservable(
            this TableLayoutPanel tlp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<TableLayoutCellPaintEventHandler, TableLayoutCellPaintEventArgs>(
                h => (s, e) => h(e),
                h => tlp.CellPaint += h,
                h => tlp.CellPaint -= h,
                tkn);
    }
}
