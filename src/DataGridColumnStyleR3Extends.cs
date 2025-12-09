using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="DataGridColumnStyle"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class DataGridColumnStyleR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGridColumnStyle dgcs)
    {
        /// <summary><see cref="DataGridColumnStyle.AlignmentChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AlignmentChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.AlignmentChanged += h,
                h => dgcs.AlignmentChanged -= h,
                tkn);

        /// <summary><see cref="DataGridColumnStyle.FontChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> FontChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.FontChanged += h,
                h => dgcs.FontChanged -= h,
                tkn);

        /// <summary><see cref="DataGridColumnStyle.HeaderTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> HeaderTextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.HeaderTextChanged += h,
                h => dgcs.HeaderTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridColumnStyle.MappingNameChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MappingNameChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.MappingNameChanged += h,
                h => dgcs.MappingNameChanged -= h,
                tkn);

        /// <summary><see cref="DataGridColumnStyle.NullTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> NullTextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.NullTextChanged += h,
                h => dgcs.NullTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridColumnStyle.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ReadOnlyChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.ReadOnlyChanged += h,
                h => dgcs.ReadOnlyChanged -= h,
                tkn);

        /// <summary><see cref="DataGridColumnStyle.WidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> WidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgcs.WidthChanged += h,
                h => dgcs.WidthChanged -= h,
                tkn);
    }
#endif
}
