using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ContainerControl"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ContainerControlR3Extends
    {
        /// <summary><see cref="ContainerControl.AutoValidateChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="cc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoValidateChangedAsObservable(
            this ContainerControl cc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cc.AutoValidateChanged += h,
                h => cc.AutoValidateChanged -= h,
                tkn);
    }
}
