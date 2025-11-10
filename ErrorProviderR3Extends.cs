using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ErrorProvider"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ErrorProviderR3Extends
    {
        /// <summary><see cref="ErrorProvider.RightToLeftChanged"/> as <see cref="Observable"/></summary>
        /// <param name="ep">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> RightToLeftChangedAsObservable(
            this ErrorProvider ep,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => ep.RightToLeftChanged += h,
                h => ep.RightToLeftChanged -= h,
                tkn);
    }
}
