using R3;
using System.Windows.Forms;

namespace R3Extends4WinForms;

#if NET7_0_OR_GREATER
/// <summary><see cref="R3"/>'s Extends for <see cref="BindableComponent"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class BindableComponentR3Extends
{
    /// <summary><see cref="BindableComponent.BindingContextChanged"/> as <see cref="Observable"/></summary>
    /// <param name="bc">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<EventArgs> BindingContextChangedAsObservable(
        this BindableComponent bc,
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => bc.BindingContextChanged += h,
            h => bc.BindingContextChanged -= h,
            tkn);
}
#endif
