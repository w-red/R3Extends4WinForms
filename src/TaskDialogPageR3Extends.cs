using R3;

namespace R3Extends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute 'TaskDialogPage' that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="TaskDialogPage"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute 'TaskDialogPage' that could not be resolved
#endif
public static class TaskDialogPageR3Extends
{
#if NET5_0_OR_GREATER

    extension(TaskDialogPage tdp)
    {
        /// <summary><see cref="TaskDialogPage.Created"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CreatedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.Created += h,
                h => tdp.Created -= h,
                tkn);

        /// <summary><see cref="TaskDialogPage.Destroyed"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DestroyedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.Destroyed += h,
                h => tdp.Destroyed -= h,
                tkn);

        /// <summary><see cref="TaskDialogPage.HelpRequest"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> HelpRequestAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tdp.HelpRequest += h,
                h => tdp.HelpRequest -= h,
                tkn);

#if NET8_0_OR_GREATER
        /// <summary><see cref="TaskDialogPage.LinkClicked"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<TaskDialogLinkClickedEventArgs> LinkClickedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler<TaskDialogLinkClickedEventArgs>, TaskDialogLinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => tdp.LinkClicked += h,
                h => tdp.LinkClicked -= h,
                tkn);
#endif
    }
#endif
}
