using R3;
using System.Windows.Forms;

namespace R3Extends4WinForms;

#if !NET7_0_OR_GREATER
#pragma warning disable CS1574 // XML comment has cref attribute 'BindableComponent' that could not be resolved
#endif
/// <summary><see cref="R3"/>'s Extends for <see cref="BindableComponent"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
#if !NET7_0_OR_GREATER
#pragma warning restore CS1574 // XML comment has cref attribute 'BindableComponent' that could not be resolved
#endif
public static class BindableComponentR3Extends
{
#if NET7_0_OR_GREATER
    extension(BindableComponent bc)
    {
        /// <summary><see cref="BindableComponent.BindingContextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BindingContextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => bc.BindingContextChanged += h,
                h => bc.BindingContextChanged -= h,
                tkn);
    }
#endif
}
