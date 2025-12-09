using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="RichTextBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class RichTextBoxR3Extends
{
    /// <summary><see cref="RichTextBox"/> extension methods.</summary>
    extension(RichTextBox rtb)
    {
        /// <summary><see cref="RichTextBox.ContentsResized"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ContentsResizedEventArgs> ContentsResizedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ContentsResizedEventHandler, ContentsResizedEventArgs>(
                h => (s, e) => h(e),
                h => rtb.ContentsResized += h,
                h => rtb.ContentsResized -= h,
                tkn);

        /// <summary><see cref="RichTextBox.DragDrop"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DragEventArgs> DragDropAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => rtb.DragDrop += h,
                h => rtb.DragDrop -= h,
                tkn);

        /// <summary><see cref="RichTextBox.DragEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DragEventArgs> DragEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => rtb.DragEnter += h,
                h => rtb.DragEnter -= h,
                tkn);

        /// <summary><see cref="RichTextBox.HScroll"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> HScrollAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.HScroll += h,
                h => rtb.HScroll -= h,
                tkn);

        /// <summary><see cref="RichTextBox.ImeChange"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ImeChangeAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.ImeChange += h,
                h => rtb.ImeChange -= h,
                tkn);

        /// <summary><see cref="RichTextBox.LinkClicked"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<LinkClickedEventArgs> LinkClickedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<LinkClickedEventHandler, LinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => rtb.LinkClicked += h,
                h => rtb.LinkClicked -= h,
                tkn);

        /// <summary><see cref="RichTextBox.Protected"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ProtectedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.Protected += h,
                h => rtb.Protected -= h,
                tkn);

        /// <summary><see cref="RichTextBox.SelectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectionChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.SelectionChanged += h,
                h => rtb.SelectionChanged -= h,
                tkn);

        /// <summary><see cref="RichTextBox.VScroll"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> VScrollAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.VScroll += h,
                h => rtb.VScroll -= h,
                tkn);
    }
}
