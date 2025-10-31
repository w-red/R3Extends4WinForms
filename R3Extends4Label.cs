using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="Label"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class R3Extends4Label
    {
        /// <summary><see cref="Label.TextAlignChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="lbl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TextAlignChangedAsObservable(
            this Label lbl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lbl.TextAlignChanged += h,
                h => lbl.TextAlignChanged -= h,
                tkn);

        /// <summary><see cref="Label.AutoSizeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="lbl">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoSizeChangedAsObservable(
            this Label lbl,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lbl.AutoSizeChanged += h,
                h => lbl.AutoSizeChanged -= h,
                tkn);
    }
}
