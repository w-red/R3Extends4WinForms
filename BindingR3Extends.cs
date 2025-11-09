using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="Binding"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class BindingR3Extends
    {
        /// <summary><see cref="Binding.BindingComplete"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="bg">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<BindingCompleteEventArgs> BindingCompleteAsObservable(
            this Binding bg,
            CancellationToken tkn = default) =>
            Observable.FromEvent<BindingCompleteEventHandler, BindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => bg.BindingComplete += h,
                h => bg.BindingComplete -= h,
                tkn);

        /// <summary><see cref="Binding.Format"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="bg">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ConvertEventArgs> FormatAsObservable(
            this Binding bg,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ConvertEventHandler, ConvertEventArgs>(
                h => (s, e) => h(e),
                h => bg.Format += h,
                h => bg.Format -= h,
                tkn);

        /// <summary><see cref="Binding.Parse"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="bg">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ConvertEventArgs> ParseAsObservable(
            this Binding bg,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ConvertEventHandler, ConvertEventArgs>(
                h => (s, e) => h(e),
                h => bg.Parse += h,
                h => bg.Parse -= h,
                tkn);
    }
}
