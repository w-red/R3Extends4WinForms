using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripProgressBar"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripProgressBarR3Extends
{
    /// <summary><see cref="ToolStripProgressBar"/> extension methods.</summary>
    extension(ToolStripProgressBar tspb)
    {
        /// <summary><see cref="ToolStripProgressBar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tspb.RightToLeftLayoutChanged += h,
                h => tspb.RightToLeftLayoutChanged -= h,
                tkn);
    }
}
