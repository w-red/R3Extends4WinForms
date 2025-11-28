using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="Splitter"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class SplitterR3Extends
{

    extension(Splitter s)
    {
        /// <summary><see cref="Splitter.SplitterMoved"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<SplitterEventArgs> SplitterMovedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<SplitterEventHandler, SplitterEventArgs>(
                h => (s, e) => h(e),
                h => s.SplitterMoved += h,
                h => s.SplitterMoved -= h,
                tkn);

        /// <summary><see cref="Splitter.SplitterMoving"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<SplitterEventArgs> SplitterMovingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<SplitterEventHandler, SplitterEventArgs>(
                h => (s, e) => h(e),
                h => s.SplitterMoving += h,
                h => s.SplitterMoving -= h,
                tkn);
    }
}
