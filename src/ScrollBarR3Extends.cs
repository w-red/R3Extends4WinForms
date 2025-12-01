using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ScrollBar"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ScrollBarR3Extends
{
    /// <summary><see cref="ScrollBar"/> extension methods.</summary>
    extension(ScrollBar sb)
    {
        /// <summary><see cref="ScrollBar.Scroll"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ScrollEventArgs> ScrollAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>(
                h => (s, e) => h(e),
                h => sb.Scroll += h,
                h => sb.Scroll -= h,
                tkn);

        /// <summary><see cref="ScrollBar.ValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ValueChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => sb.ValueChanged += h,
                h => sb.ValueChanged -= h,
                tkn);
    }
}
