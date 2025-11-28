using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="FontDialog"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class FontDialogR3Extends
{
    /// <summary><see cref="FontDialog"/> extension methods.</summary>
    extension(FontDialog fd)
    {
        /// <summary><see cref="FontDialog.Apply"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ApplyAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => fd.Apply += h,
                h => fd.Apply -= h,
                tkn);
    }
}
