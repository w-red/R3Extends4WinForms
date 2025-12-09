using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="GridColumnStylesCollection"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class GridColumnStylesCollectionR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(GridColumnStylesCollection gcsc)
    {
        /// <summary><see cref="GridColumnStylesCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<CollectionChangeEventArgs> CollectionChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => gcsc.CollectionChanged += h,
                h => gcsc.CollectionChanged -= h,
                tkn);
    }
#endif
}
