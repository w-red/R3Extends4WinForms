using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="Component"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ComponentR3Extends
    {
        /// <summary><see cref="Component.Disposed"/> as <see cref="Observable"/></summary>
        /// <param name="c">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DisposedAsObservable(
            this Component c,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => c.Disposed += h,
                h => c.Disposed -= h,
                tkn);
    }
}
