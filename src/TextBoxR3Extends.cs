using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="TextBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class TextBoxR3Extends
{
    /// <summary><see cref="TextBox"/> extension methods.</summary>
    extension(TextBox tb)
    {
        /// <summary><see cref="TextBox.TextAlignChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextAlignChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.TextAlignChanged += h,
                h => tb.TextAlignChanged -= h,
                tkn);
    }
}
