using R3;

namespace R3Extends4WinForms
{
#if NET5_0_OR_GREATER
    /// <summary><see cref="R3"/>'s Extends for <see cref="TaskDialogRadioButton"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class TaskDialogRadioButtonR3Extends
    {
        /// <summary><see cref="TaskDialogRadioButton.CheckedChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tdrb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CheckedChangedAsObservable(
            this TaskDialogRadioButton tdrb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdrb.CheckedChanged += h,
                h => tdrb.CheckedChanged -= h,
                tkn);
    }
#endif
}
