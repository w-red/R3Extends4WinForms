using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ComboBox"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ComboBoxR3Extends
{
    /// <summary><see cref="ComboBox"/> extension methods.</summary>
    extension(ComboBox cb)
    {
        /// <summary><see cref="ComboBox.DrawItem"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DrawItemEventArgs> DrawItemAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => cb.DrawItem += h,
                h => cb.DrawItem -= h,
                tkn);

        /// <summary><see cref="ComboBox.DropDownClosed"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DropDownClosedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.DropDownClosed += h,
                h => cb.DropDownClosed -= h,
                tkn);

        /// <summary><see cref="ComboBox.DropDownStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DropDownStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.DropDownStyleChanged += h,
                h => cb.DropDownStyleChanged -= h,
                tkn);

        /// <summary><see cref="ComboBox.DropDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DropDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.DropDown += h,
                h => cb.DropDown -= h,
                tkn);

        /// <summary><see cref="ComboBox.MeasureItem"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MeasureItemEventArgs> MeasureItemAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MeasureItemEventHandler, MeasureItemEventArgs>(
                h => (s, e) => h(e),
                h => cb.MeasureItem += h,
                h => cb.MeasureItem -= h,
                tkn);

        /// <summary><see cref="ComboBox.SelectedIndexChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectedIndexChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.SelectedIndexChanged += h,
                h => cb.SelectedIndexChanged -= h,
                tkn);

        /// <summary><see cref="ComboBox.SelectionChangeCommitted"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectionChangeCommittedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.SelectionChangeCommitted += h,
                h => cb.SelectionChangeCommitted -= h,
                tkn);

        /// <summary><see cref="ComboBox.TextUpdate"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextUpdateAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cb.TextUpdate += h,
                h => cb.TextUpdate -= h,
                tkn);
    }
}
