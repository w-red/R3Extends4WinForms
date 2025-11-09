using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="BindingManagerBase"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class BindingManagerBaseR3Extends
    {
        /// <summary><see cref="BindingManagerBase.BindingComplete"/> as <see cref="Observable(Of BindingCompleteEventArgs)"/></summary>
        /// <param name="bmb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<BindingCompleteEventArgs> BindingCompleteAsObservable(
            this BindingManagerBase bmb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => bmb.BindingComplete += h,
                h => bmb.BindingComplete -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.CurrentChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="bmb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CurrentChangedAsObservable(
            this BindingManagerBase bmb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.CurrentChanged += h,
                h => bmb.CurrentChanged -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.CurrentItemChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="bmb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CurrentItemChangedAsObservable(
            this BindingManagerBase bmb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.CurrentItemChanged += h,
                h => bmb.CurrentItemChanged -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.DataError"/> as <see cref="Observable(Of BindingManagerDataErrorEventArgs)"/></summary>
        /// <param name="bmb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<BindingManagerDataErrorEventArgs> DataErrorAsObservable(
            this BindingManagerBase bmb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => bmb.DataError += h,
                h => bmb.DataError -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.PositionChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="bmb">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> PositionChangedAsObservable(
            this BindingManagerBase bmb,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.PositionChanged += h,
                h => bmb.PositionChanged -= h,
                tkn);
    }
}
