using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ListBox"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ListBoxR3Extends
    {
        /// <summary><see cref="ListBox.Click"/> as <see cref="Observable"/></summary>
        /// <param name="lb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClickAsObservable(
            this ListBox lb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lb.Click += h,
                h => lb.Click -= h,
                tkn);

        /// <summary><see cref="ListBox.DrawItem"/> as <see cref="Observable"/></summary>
        /// <param name="lb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DrawItemEventArgs> DrawItemAsObservable(
            this ListBox lb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => lb.DrawItem += h,
                h => lb.DrawItem -= h,
                tkn);

        /// <summary><see cref="ListBox.MeasureItem"/> as <see cref="Observable"/></summary>
        /// <param name="lb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MeasureItemEventArgs> MeasureItemAsObservable(
            this ListBox lb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MeasureItemEventHandler, MeasureItemEventArgs>(
                h => (s, e) => h(e),
                h => lb.MeasureItem += h,
                h => lb.MeasureItem -= h,
                tkn);

        /// <summary><see cref="ListBox.MouseClick"/> as <see cref="Observable"/></summary>
        /// <param name="lb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseClickAsObservable(
            this ListBox lb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => lb.MouseClick += h,
                h => lb.MouseClick -= h,
                tkn);

        /// <summary><see cref="ListBox.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> SelectedIndexChangedAsObservable(
            this ListBox lb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lb.SelectedIndexChanged += h,
                h => lb.SelectedIndexChanged -= h,
                tkn);

        /// <summary><see cref="ListBox.TextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TextChangedAsObservable(
            this ListBox lb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lb.TextChanged += h,
                h => lb.TextChanged -= h,
                tkn);
    }
}
