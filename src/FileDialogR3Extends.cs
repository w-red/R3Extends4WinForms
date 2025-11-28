using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="FileDialog"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class FileDialogR3Extends
{
    /// <summary><see cref="FileDialog.FileOk"/> as <see cref="Observable"/></summary>
    /// <param name="fd">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<CancelEventArgs> FileOkAsObservable(
        this FileDialog fd,
        CancellationToken tkn = default) =>
        Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
            h => (s, e) => h(e),
            h => fd.FileOk += h,
            h => fd.FileOk -= h,
            tkn);
}
