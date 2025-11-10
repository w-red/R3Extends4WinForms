using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ListControl"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ListControlR3Extends
    {
        /// <summary><see cref="ListControl.DataSourceChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DataSourceChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.DataSourceChanged += h,
                h => lc.DataSourceChanged -= h,
                tkn);

        /// <summary><see cref="ListControl.DisplayMemberChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DisplayMemberChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.DisplayMemberChanged += h,
                h => lc.DisplayMemberChanged -= h,
                tkn);

        /// <summary><see cref="ListControl.FormatInfoChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> FormatInfoChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.FormatInfoChanged += h,
                h => lc.FormatInfoChanged -= h,
                tkn);

        /// <summary><see cref="ListControl.FormatStringChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> FormatStringChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.FormatStringChanged += h,
                h => lc.FormatStringChanged -= h,
                tkn);

        /// <summary><see cref="ListControl.FormattingEnabledChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> FormattingEnabledChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.FormattingEnabledChanged += h,
                h => lc.FormattingEnabledChanged -= h,
                tkn);

        /// <summary><see cref="ListControl.Format"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListControlConvertEventArgs> FormatAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ListControlConvertEventHandler, ListControlConvertEventArgs>(
                h => (s, e) => h(e),
                h => lc.Format += h,
                h => lc.Format -= h,
                tkn);

        /// <summary><see cref="ListControl.SelectedValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> SelectedValueChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.SelectedValueChanged += h,
                h => lc.SelectedValueChanged -= h,
                tkn);

        /// <summary><see cref="ListControl.ValueMemberChanged"/> as <see cref="Observable"/></summary>
        /// <param name="lc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ValueMemberChangedAsObservable(
            this ListControl lc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => lc.ValueMemberChanged += h,
                h => lc.ValueMemberChanged -= h,
                tkn);
    }
}
