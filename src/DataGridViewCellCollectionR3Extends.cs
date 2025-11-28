using R3;
using System.ComponentModel;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="DataGridViewCellCollection"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class DataGridViewCellCollectionR3Extends
{
    /// <summary><see cref="DataGridViewCellCollection"/> extension methods.</summary>
    extension(DataGridViewCellCollection dgvcc)
    {
        /// <summary><see cref="DataGridViewCellCollection.CollectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<CollectionChangeEventArgs> CollectionChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<CollectionChangeEventHandler, CollectionChangeEventArgs>(
                h => (s, e) => h(e),
                h => dgvcc.CollectionChanged += h,
                h => dgvcc.CollectionChanged -= h,
                tkn);
    }
}
