using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="PictureBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class PictureBoxR3Extends
{
    /// <summary><see cref="PictureBox"/> extension methods.</summary>
    extension(PictureBox pb)
    {
        /// <summary><see cref="PictureBox.LoadCompleted"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<AsyncCompletedEventArgs> LoadCompletedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<AsyncCompletedEventHandler, AsyncCompletedEventArgs>(
                h => (s, e) => h(e),
                h => pb.LoadCompleted += h,
                h => pb.LoadCompleted -= h,
                tkn);

        /// <summary><see cref="PictureBox.LoadProgressChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ProgressChangedEventArgs> LoadProgressChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ProgressChangedEventHandler, ProgressChangedEventArgs>(
                h => (s, e) => h(e),
                h => pb.LoadProgressChanged += h,
                h => pb.LoadProgressChanged -= h,
                tkn);

        /// <summary><see cref="PictureBox.SizeModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SizeModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pb.SizeModeChanged += h,
                h => pb.SizeModeChanged -= h,
                tkn);
    }
}
