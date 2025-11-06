using R3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="TextBoxBase"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class RichTextBoxR3Extends
    {
        /// <summary><see cref="RichTextBox.ContentsResized"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ContentsResizedEventArgs> ContentsResizedAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ContentsResizedEventHandler, ContentsResizedEventArgs>(
                h => (s, e) => h(e),
                h => rtb.ContentsResized += h,
                h => rtb.ContentsResized -= h,
                tkn);

        /// <summary><see cref="RichTextBox.DragDrop"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DragEventArgs> DragDropAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => rtb.DragDrop += h,
                h => rtb.DragDrop -= h,
                tkn);

        /// <summary><see cref="RichTextBox.DragEnter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DragEventArgs> DragEnterAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DragEventHandler, DragEventArgs>(
                h => (s, e) => h(e),
                h => rtb.DragEnter += h,
                h => rtb.DragEnter -= h,
                tkn);

        /// <summary><see cref="RichTextBox.HScroll"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> HScrollAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.HScroll += h,
                h => rtb.HScroll -= h,
                tkn);

        /// <summary><see cref="RichTextBox.ImeChange"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ImeChangeAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.ImeChange += h,
                h => rtb.ImeChange -= h,
                tkn);

        /// <summary><see cref="RichTextBox.LinkClicked"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<LinkClickedEventArgs> LinkClickedAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<LinkClickedEventHandler, LinkClickedEventArgs>(
                h => (s, e) => h(e),
                h => rtb.LinkClicked += h,
                h => rtb.LinkClicked -= h,
                tkn);

        /// <summary><see cref="RichTextBox.Protected"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="rtb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ProtectedAsObservable(
            this RichTextBox rtb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => rtb.Protected += h,
                h => rtb.Protected -= h,
                tkn);

    }
}
