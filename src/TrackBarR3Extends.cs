using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="TrackBar"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class TrackBarR3Extends
    {
        /// <summary><see cref="TrackBar.AutoSizeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoSizeChangedAsObservable(
            this TrackBar tb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.AutoSizeChanged += h,
                h => tb.AutoSizeChanged -= h,
                tkn);

        /// <summary><see cref="TrackBar.RightToLeftLayoutChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RightToLeftLayoutChangedAsObservable(
            this TrackBar tb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.RightToLeftLayoutChanged += h,
                h => tb.RightToLeftLayoutChanged -= h,
                tkn);

        /// <summary><see cref="TrackBar.Scroll"/> as <see cref="Observable"/></summary>
        /// <param name="tb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ScrollAsObservable(
            this TrackBar tb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.Scroll += h,
                h => tb.Scroll -= h,
                tkn);

        /// <summary><see cref="TrackBar.ValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ValueChangedAsObservable(
            this TrackBar tb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.ValueChanged += h,
                h => tb.ValueChanged -= h,
                tkn);
    }
}
