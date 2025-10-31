using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="NumericUpDown"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class R3Extends4NumericUpDown
    {
        /// <summary><see cref="NumericUpDown.ValueChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="nud">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ValueChangedAsObservable(
            this NumericUpDown nud,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => nud.ValueChanged += h,
                h => nud.ValueChanged -= h,
                tkn);

        /// <summary><see cref="NumericUpDown.TextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="nud">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TextChangedAsObservable(
            this NumericUpDown nud,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => nud.TextChanged += h,
                h => nud.TextChanged -= h,
                tkn);


        // PaddingChenged cannot compile.
#if false
        /// <summary><see cref="NumericUpDown.PaddingChenged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="nud">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> PaddingChengedAsObservable(
            this NumericUpDown nud,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => nud.PaddingChenged += h,
                h => nud.PaddingChenged -= h,
                tkn);
#endif
    }
}
