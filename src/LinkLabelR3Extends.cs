using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="LinkLabel"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class LinkLabelR3Extends
{
    /// <summary><see cref="LinkLabel"/> extension methods.</summary>
    extension(LinkLabel ll)
    {
        /// <summary><see cref="LinkLabel.LinkClicked"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<LinkLabelLinkClickedEventArgs> LinkClickedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<LinkLabelLinkClickedEventHandler, LinkLabelLinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => ll.LinkClicked += h,
                h => ll.LinkClicked -= h,
                tkn);

        /// <summary><see cref="LinkLabel.TabStopChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TabStopChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ll.TabStopChanged += h,
                h => ll.TabStopChanged -= h,
                tkn);
    }
}
