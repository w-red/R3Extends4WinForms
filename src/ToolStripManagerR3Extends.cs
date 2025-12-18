using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripManager"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripManagerR3Extends
{
    /// <summary><see cref="ToolStripManager.RendererChanged"/> as <see cref="Observable"/></summary>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    /// <example><code>
    /// ToolStripManagerR3Extends
    ///     .RendererChangedAsObservable()
    ///     .Subscribe(e =&gt;
    ///         {
    ///             Console.WriteLine("RendererChanged event occurred.");
    ///         }
    ///     );
    /// </code></example>
    public static Observable<EventArgs> RendererChangedAsObservable(
        CancellationToken tkn = default) =>
        Observable.FromEvent<EventHandler, EventArgs>(
            h => (s, e) => h(e),
            h => ToolStripManager.RendererChanged += h,
            h => ToolStripManager.RendererChanged -= h,
            tkn);
}
