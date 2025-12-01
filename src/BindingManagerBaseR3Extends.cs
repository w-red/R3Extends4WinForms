using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="BindingManagerBase"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class BindingManagerBaseR3Extends
{
    /// <summary><see cref="BindingManagerBase"/> extension methods.</summary>
    extension(BindingManagerBase bmb)
    {
        /// <summary><see cref="BindingManagerBase.BindingComplete"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<BindingCompleteEventArgs> BindingCompleteAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => bmb.BindingComplete += h,
                h => bmb.BindingComplete -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.CurrentChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CurrentChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.CurrentChanged += h,
                h => bmb.CurrentChanged -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.CurrentItemChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CurrentItemChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.CurrentItemChanged += h,
                h => bmb.CurrentItemChanged -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.DataError"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<BindingManagerDataErrorEventArgs> DataErrorAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<BindingManagerDataErrorEventHandler, BindingManagerDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => bmb.DataError += h,
                h => bmb.DataError -= h,
                tkn);

        /// <summary><see cref="BindingManagerBase.PositionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> PositionChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bmb.PositionChanged += h,
                h => bmb.PositionChanged -= h,
                tkn);
    }
}
