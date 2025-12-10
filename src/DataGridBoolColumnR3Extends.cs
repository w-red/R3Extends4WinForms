using R3;

namespace R3Extends4WinForms;

#if NETCOREAPP3_1_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="DataGridBoolColumn"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if NETCOREAPP3_1_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute that could not be resolved
#endif
public static class DataGridBoolColumnR3Extends
{
#if !NETCOREAPP3_1_OR_GREATER
    extension(DataGridBoolColumn dgbc)
    {
        /// <summary><see cref="DataGridBoolColumn.AllowNullChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowNullChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgbc.AllowNullChanged += h,
                h => dgbc.AllowNullChanged -= h,
                tkn);

        /// <summary><see cref="DataGridBoolColumn.FalseValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> FalseValueChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgbc.FalseValueChanged += h,
                h => dgbc.FalseValueChanged -= h,
                tkn);

        /// <summary><see cref="DataGridBoolColumn.TrueValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TrueValueChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgbc.TrueValueChanged += h,
                h => dgbc.TrueValueChanged -= h,
                tkn);
    }
#endif
}
