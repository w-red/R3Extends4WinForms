using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="BindingsCollection"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class BindingsCollectionR3Extends
    {
        /// <summary><see cref="BindingsCollection.CollectionChanged"/> as <see cref="Observable(Of CollectionChangeEventArgs)"/></summary>
        /// <param name="bc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CollectionChangeEventArgs> CollectionChangedAsObservable(
            this BindingsCollection bc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => bc.CollectionChanged += h,
                h => bc.CollectionChanged -= h,
                tkn);

        /// <summary><see cref="BindingsCollection.CollectionChanging"/> as <see cref="Observable(Of CollectionChangeEventArgs)"/></summary>
        /// <param name="bc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CollectionChangeEventArgs> CollectionChangingAsObservable(
            this BindingsCollection bc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => bc.CollectionChanging += h,
                h => bc.CollectionChanging -= h,
                tkn);
    }
}
