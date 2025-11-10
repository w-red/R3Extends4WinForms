using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="AutoCompleteStringCollection"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class AutoCompleteStringCollectionR3Extends
    {
        /// <summary><see cref="AutoCompleteStringCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="acsc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CollectionChangeEventArgs> CollectionChangedAsObservable(
            this AutoCompleteStringCollection acsc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => acsc.CollectionChanged += h,
                h => acsc.CollectionChanged -= h,
                tkn);
    }
}
