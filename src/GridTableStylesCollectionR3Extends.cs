using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="GridTableStylesCollection"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class GridTableStylesCollectionR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(GridTableStylesCollection gtsc)
    {
        /// <summary><see cref="GridTableStylesCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<CollectionChangeEventArgs> CollectionChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => gtsc.CollectionChanged += h,
                h => gtsc.CollectionChanged -= h,
                tkn);
    }
#endif
}
