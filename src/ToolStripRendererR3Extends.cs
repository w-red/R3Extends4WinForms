using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="ToolStripRenderer"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class ToolStripRendererR3Extends
{
    /// <summary><see cref="ToolStripRenderer.RenderArrow"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripArrowRenderEventArgs> RenderArrowAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripArrowRenderEventHandler, ToolStripArrowRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderArrow += h,
            h => tsr.RenderArrow -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderButtonBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderButtonBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderButtonBackground += h,
            h => tsr.RenderButtonBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderDropDownButtonBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderDropDownButtonBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderDropDownButtonBackground += h,
            h => tsr.RenderDropDownButtonBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderGrip"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripGripRenderEventArgs> RenderGripAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripGripRenderEventHandler, ToolStripGripRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderGrip += h,
            h => tsr.RenderGrip -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderImageMargin"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripRenderEventArgs> RenderImageMarginAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderImageMargin += h,
            h => tsr.RenderImageMargin -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderItemBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderItemBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderItemBackground += h,
            h => tsr.RenderItemBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderItemCheck"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemImageRenderEventArgs> RenderItemCheckAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemImageRenderEventHandler, ToolStripItemImageRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderItemCheck += h,
            h => tsr.RenderItemCheck -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderItemImage"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemImageRenderEventArgs> RenderItemImageAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemImageRenderEventHandler, ToolStripItemImageRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderItemImage += h,
            h => tsr.RenderItemImage -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderItemText"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemTextRenderEventArgs> RenderItemTextAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemTextRenderEventHandler, ToolStripItemTextRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderItemText += h,
            h => tsr.RenderItemText -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderLabelBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderLabelBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderLabelBackground += h,
            h => tsr.RenderLabelBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderMenuItemBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderMenuItemBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderMenuItemBackground += h,
            h => tsr.RenderMenuItemBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderOverflowButtonBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderOverflowButtonBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderOverflowButtonBackground += h,
            h => tsr.RenderOverflowButtonBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderSeparator"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripSeparatorRenderEventArgs> RenderSeparatorAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripSeparatorRenderEventHandler, ToolStripSeparatorRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderSeparator += h,
            h => tsr.RenderSeparator -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderSplitButtonBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderSplitButtonBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderSplitButtonBackground += h,
            h => tsr.RenderSplitButtonBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderStatusStripSizingGrip"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripRenderEventArgs> RenderStatusStripSizingGripAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderStatusStripSizingGrip += h,
            h => tsr.RenderStatusStripSizingGrip -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderToolStripBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripRenderEventArgs> RenderToolStripBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderToolStripBackground += h,
            h => tsr.RenderToolStripBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderToolStripBorder"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripRenderEventArgs> RenderToolStripBorderAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripRenderEventHandler, ToolStripRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderToolStripBorder += h,
            h => tsr.RenderToolStripBorder -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderToolStripContentPanelBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripContentPanelRenderEventArgs> RenderToolStripContentPanelBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripContentPanelRenderEventHandler, ToolStripContentPanelRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderToolStripContentPanelBackground += h,
            h => tsr.RenderToolStripContentPanelBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderToolStripPanelBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripPanelRenderEventArgs> RenderToolStripPanelBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripPanelRenderEventHandler, ToolStripPanelRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderToolStripPanelBackground += h,
            h => tsr.RenderToolStripPanelBackground -= h,
            tkn);

    /// <summary><see cref="ToolStripRenderer.RenderToolStripStatusLabelBackground"/> as <see cref="Observable"/></summary>
    /// <param name="tsr">target</param>
    /// <param name="tkn">token</param>
    /// <returns>Observable object.</returns>
    public static Observable<ToolStripItemRenderEventArgs> RenderToolStripStatusLabelBackgroundAsObservable(
        this ToolStripRenderer tsr,
        CancellationToken tkn = default) =>
        Observable.FromEvent<ToolStripItemRenderEventHandler, ToolStripItemRenderEventArgs>(
            h => (s, e) => h(e),
            h => tsr.RenderToolStripStatusLabelBackground += h,
            h => tsr.RenderToolStripStatusLabelBackground -= h,
            tkn);
}
