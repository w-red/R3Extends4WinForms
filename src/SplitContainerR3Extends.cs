using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="SplitContainer"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class SplitContainerR3Extends
{
    /// <summary><see cref="SplitContainer"/> extension methods.</summary>
    extension(SplitContainer sc)
    {
        /// <summary><see cref="SplitContainer.BackgroundImageChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BackgroundImageChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => sc.BackgroundImageChanged += h,
                h => sc.BackgroundImageChanged -= h,
                tkn);

        /// <summary><see cref="SplitContainer.SplitterMoved"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<SplitterEventArgs> SplitterMovedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<SplitterEventHandler, SplitterEventArgs>(
                h => (s, e) => h(e),
                h => sc.SplitterMoved += h,
                h => sc.SplitterMoved -= h,
                tkn);

        /// <summary><see cref="SplitContainer.SplitterMoving"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<SplitterCancelEventArgs> SplitterMovingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<SplitterCancelEventHandler, SplitterCancelEventArgs>(
                h => (s, e) => h(e),
                h => sc.SplitterMoving += h,
                h => sc.SplitterMoving -= h,
                tkn);
    }
}
