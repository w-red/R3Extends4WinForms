using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for WinForms</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class R3Extends4WinForms
    {
        /// <summary><see cref="Form.Load"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> LoadAsObservable(
            this Form frm,
            CancellationToken tkn = default) => 
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Load += h,
                h => frm.Load -= h,
                tkn);

        /// <summary><see cref="Form.FormClosing"/> as <see cref="Observable"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ClosingAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => frm.Load += h,
                h => frm.Load -= h,
                tkn);

        /// <summary><see cref="Form.FormClosed"/> as <see cref="Observable"/></summary>
        /// <param name="frm">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<FormClosedEventArgs> FormClosedAsObservable(
            this Form frm,
            CancellationToken tkn = default) =>
            Observable.FromEvent<FormClosedEventHandler, FormClosedEventArgs>(
                h => (s, e) => h(e),
                h => frm.FormClosed += h,
                h => frm.FormClosed -= h,
                tkn);
    }
}
