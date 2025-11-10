using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="TextBox"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class TextBoxR3Extends
    {
        /// <summary><see cref="TextBox.TextAlignChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> TextAlignChangedAsObservable(
            this TextBox tb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tb.TextAlignChanged += h,
                h => tb.TextAlignChanged -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BorderStyleChangedAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.BorderStyleChanged += h,
                h => tbb.BorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.Click"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClickAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.Click += h,
                h => tbb.Click -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.MouseClick"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<MouseEventArgs> MouseClickAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => tbb.MouseClick += h,
                h => tbb.MouseClick -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.HideSelectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> HideSelectionChangedAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.HideSelectionChanged += h,
                h => tbb.HideSelectionChanged -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.ModifiedChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ModifiedChangedAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.ModifiedChanged += h,
                h => tbb.ModifiedChanged -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.MultilineChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MultilineChangedAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.MultilineChanged += h,
                h => tbb.MultilineChanged -= h,
                tkn);

        /// <summary><see cref="TextBoxBase.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tbb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ReadOnlyChangedAsObservable(
            this TextBoxBase tbb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => tbb.ReadOnlyChanged += h,
                h => tbb.ReadOnlyChanged -= h,
                tkn);
    }
}
