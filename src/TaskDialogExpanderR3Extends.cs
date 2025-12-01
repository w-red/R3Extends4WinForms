using R3;

namespace R3Extends4WinForms;

#if !NET5_0_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute 'BindableComponent' that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="TaskDialogExpander"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if !NET5_0_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute 'BindableComponent' that could not be resolved
#endif
public static class TaskDialogExpanderR3Extends
{
#if NET5_0_OR_GREATER
    /// <summary>Extension methods for <see cref="TaskDialogExpander"/>.</summary>
    extension(TaskDialogExpander tde)
    {
        /// <summary><see cref="TaskDialogExpander.ExpandedChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ExpandedChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tde.ExpandedChanged += h,
                h => tde.ExpandedChanged -= h,
                tkn);
    }
#endif
}
