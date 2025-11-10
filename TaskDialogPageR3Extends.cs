using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="TaskDialogPage"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class TaskDialogPageR3Extends
    {
        /// <summary><see cref="TaskDialogPage.Created"/> as <see cref="Observable"/></summary>
        /// <param name="tdp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CreatedAsObservable(
            this TaskDialogPage tdp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.Created += h,
                h => tdp.Created -= h,
                tkn);

        /// <summary><see cref="TaskDialogPage.Destroyed"/> as <see cref="Observable"/></summary>
        /// <param name="tdp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DestroyedAsObservable(
            this TaskDialogPage tdp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.Destroyed += h,
                h => tdp.Destroyed -= h,
                tkn);

        /// <summary><see cref="TaskDialogPage.HelpRequest"/> as <see cref="Observable"/></summary>
        /// <param name="tdp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> HelpRequestAsObservable(
            this TaskDialogPage tdp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.HelpRequest += h,
                h => tdp.HelpRequest -= h,
                tkn);

        /// <summary><see cref="TaskDialogPage.LinkClicked"/> as <see cref="Observable"/></summary>
        /// <param name="tdp">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<TaskDialogLinkClickedEventArgs> LinkClickedAsObservable(
            this TaskDialogPage tdp,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler<TaskDialogLinkClickedEventArgs>, TaskDialogLinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => tdp.LinkClicked += h,
                h => tdp.LinkClicked -= h,
                tkn);
    }
}
