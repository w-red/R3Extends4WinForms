using R3;
using System.Windows.Forms;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="MenuItem"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class MenuItemR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    /// <summary><see cref="MenuItem"/> extension methods.</summary>
    extension(MenuItem mi)
    {
        /// <summary><see cref="MenuItem.Click"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mi.Click += h,
                h => mi.Click -= h,
                tkn);

        /// <summary><see cref="MenuItem.DrawItem"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DrawItemEventArgs> DrawItemAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawItemEventHandler, DrawItemEventArgs>(
                h => (s, e) => h(e),
                h => mi.DrawItem += h,
                h => mi.DrawItem -= h,
                tkn);

        /// <summary><see cref="MenuItem.MeasureItem"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MeasureItemEventArgs> MeasureItemAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MeasureItemEventHandler, MeasureItemEventArgs>(
                h => (s, e) => h(e),
                h => mi.MeasureItem += h,
                h => mi.MeasureItem -= h,
                tkn);

        /// <summary><see cref="MenuItem.Popup"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> PopupAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mi.Popup += h,
                h => mi.Popup -= h,
                tkn);

        /// <summary><see cref="MenuItem.Select"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => mi.Select += h,
                h => mi.Select -= h,
                tkn);
    }
#endif
}
