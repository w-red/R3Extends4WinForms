using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="DomainUpDown"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class DomainUpDownR3Extends
    {
        /// <summary><see cref="DomainUpDown.SelectedItemChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dud">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> SelectedItemChangedAsObservable(
            this DomainUpDown dud,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dud.SelectedItemChanged += h,
                h => dud.SelectedItemChanged -= h,
                tkn);
    }
}
