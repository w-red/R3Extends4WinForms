using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="PropertyGrid"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class PropertyGridR3Extends
{
    /// <summary><see cref="PropertyGrid"/> extension methods.</summary>
    extension(PropertyGrid pg)
    {
        /// <summary><see cref="PropertyGrid.KeyDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyEventArgs> KeyDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => pg.KeyDown += h,
                h => pg.KeyDown -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.KeyPress"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyPressEventArgs> KeyPressAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyPressEventHandler, KeyPressEventArgs>(
                h => (s, e) => h(e),
                h => pg.KeyPress += h,
                h => pg.KeyPress -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.KeyUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<KeyEventArgs> KeyUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<KeyEventHandler, KeyEventArgs>(
                h => (s, e) => h(e),
                h => pg.KeyUp += h,
                h => pg.KeyUp -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.MouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseDown += h,
                h => pg.MouseDown -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.MouseEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseEnter += h,
                h => pg.MouseEnter -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.MouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MouseLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseLeave += h,
                h => pg.MouseLeave -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.MouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseMoveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseMove += h,
                h => pg.MouseMove -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.MouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<MouseEventArgs> MouseUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<MouseEventHandler, MouseEventArgs>(
                h => (s, e) => h(e),
                h => pg.MouseUp += h,
                h => pg.MouseUp -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.PropertySortChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> PropertySortChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.PropertySortChanged += h,
                h => pg.PropertySortChanged -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.PropertyTabChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<PropertyTabChangedEventArgs> PropertyTabChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<PropertyTabChangedEventHandler, PropertyTabChangedEventArgs>(
                h => (s, e) => h(e),
                h => pg.PropertyTabChanged += h,
                h => pg.PropertyTabChanged -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.PropertyValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<PropertyValueChangedEventArgs> PropertyValueChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<PropertyValueChangedEventHandler, PropertyValueChangedEventArgs>(
                h => (s, e) => h(e),
                h => pg.PropertyValueChanged += h,
                h => pg.PropertyValueChanged -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.SelectedGridItemChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<SelectedGridItemChangedEventArgs> SelectedGridItemChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<SelectedGridItemChangedEventHandler, SelectedGridItemChangedEventArgs>(
                h => (s, e) => h(e),
                h => pg.SelectedGridItemChanged += h,
                h => pg.SelectedGridItemChanged -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.SelectedObjectsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectedObjectsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.SelectedObjectsChanged += h,
                h => pg.SelectedObjectsChanged -= h,
                tkn);

        /// <summary><see cref="PropertyGrid.TextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> TextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => pg.TextChanged += h,
                h => pg.TextChanged -= h,
                tkn);
    }
}
