using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="LinkLabel"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class LinkLabelR3Extends
    {
        /// <summary><see cref="LinkLabel.LinkClicked"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ll">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<LinkLabelLinkClickedEventArgs> LinkClickedAsObservable(
            this LinkLabel ll,
            CancellationToken tkn = default) =>
            Observable.FromEvent<LinkLabelLinkClickedEventHandler, LinkLabelLinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => ll.LinkClicked += h,
                h => ll.LinkClicked -= h,
                tkn);

        /// <summary><see cref="LinkLabel.TabStopChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="ll">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TabStopChangedAsObservable(
            this LinkLabel ll,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ll.TabStopChanged += h,
                h => ll.TabStopChanged -= h,
                tkn);
    }
}
