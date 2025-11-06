using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="CheckedListBox"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class CheckedListBoxR3Extends
    {
        /// <summary><see cref="CheckedListBox.Click"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="clb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClickAsObservable(
            this CheckedListBox clb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => clb.Click += h,
                h => clb.Click -= h,
                tkn);

        /// <summary><see cref="CheckedListBox.ItemCheck"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="clb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ItemCheckEventArgs> ItemCheckAsObservable(
            this CheckedListBox clb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ItemCheckEventHandler, ItemCheckEventArgs>(
                h => (s, e) => h(e),
                h => clb.ItemCheck += h,
                h => clb.ItemCheck -= h,
                tkn);

        /// <summary><see cref="CheckedListBox.MouseClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="clb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseClickAsObservable(
            this CheckedListBox clb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => clb.MouseClick += h,
                h => clb.MouseClick -= h,
                tkn);
    }
}
