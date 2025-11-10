using R3;
using System.ComponentModel;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="CurrencyManager"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class CurrencyManagerR3Extends
    {
        /// <summary><see cref="CurrencyManager.ItemChanged"/> as <see cref="Observable"/></summary>
        /// <param name="cm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ItemChangedEventArgs> ItemChangedAsObservable(
            this CurrencyManager cm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ItemChangedEventHandler, ItemChangedEventArgs>(
                h => (s, e) => h(e),
                h => cm.ItemChanged += h,
                h => cm.ItemChanged -= h,
                tkn);

        /// <summary><see cref="CurrencyManager.ListChanged"/> as <see cref="Observable"/></summary>
        /// <param name="cm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<ListChangedEventArgs> ListChangedAsObservable(
            this CurrencyManager cm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<ListChangedEventHandler, ListChangedEventArgs>(
                h => (s, e) => h(e),
                h => cm.ListChanged += h,
                h => cm.ListChanged -= h,
                tkn);

        /// <summary><see cref="CurrencyManager.MetaDataChanged"/> as <see cref="Observable"/></summary>
        /// <param name="cm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> MetaDataChangedAsObservable(
            this CurrencyManager cm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => cm.MetaDataChanged += h,
                h => cm.MetaDataChanged -= h,
                tkn);
    }
}
