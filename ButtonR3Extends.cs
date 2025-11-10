using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="Button"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ButtonR3Extends
    {
        /// <summary><see cref="Button.DoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="b">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DoubleClickAsObservable(
            this Button b,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => b.DoubleClick += h,
                h => b.DoubleClick -= h,
                tkn);

        /// <summary><see cref="Button.MouseDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="b">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseDoubleClickAsObservable(
            this Button b,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => b.MouseDoubleClick += h,
                h => b.MouseDoubleClick -= h,
                tkn);
    }
}
