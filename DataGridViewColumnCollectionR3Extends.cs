using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="DataGridViewColumnCollection"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class DataGridViewColumnCollectionR3Extends
    {
        /// <summary><see cref="DataGridViewColumnCollection.CollectionChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgvcc">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<CollectionChangeEventArgs> CollectionChangedAsObservable(
            this DataGridViewColumnCollection dgvcc,
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => dgvcc.CollectionChanged += h,
                h => dgvcc.CollectionChanged -= h,
                tkn);
    }
}
