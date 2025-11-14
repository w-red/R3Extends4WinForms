using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="ToolTip"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class ToolTipR3Extends
    {
        /// <summary><see cref="ToolTip.Draw"/> as <see cref="Observable"/></summary>
        /// <param name="tt">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DrawToolTipEventArgs> DrawAsObservable(
            this ToolTip tt,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DrawToolTipEventHandler, DrawToolTipEventArgs>(
                h => (s, e) => h(e),
                h => tt.Draw += h,
                h => tt.Draw -= h,
                tkn);

        /// <summary><see cref="ToolTip.Popup"/> as <see cref="Observable"/></summary>
        /// <param name="tt">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<PopupEventArgs> PopupAsObservable(
            this ToolTip tt,
            CancellationToken tkn = default) =>
            Observable.FromEvent<PopupEventHandler, PopupEventArgs>(
                h => (s, e) => h(e),
                h => tt.Popup += h,
                h => tt.Popup -= h,
                tkn);
    }
}
