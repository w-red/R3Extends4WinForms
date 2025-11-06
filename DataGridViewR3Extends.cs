using R3;

namespace R3Extends4WinForms
{
    /// <summary><see cref="R3"/>'s Extends for <see cref="DataGridView"/>.</summary>
    /// <remarks>
    /// Add extension methods for any events you need.<br />
    /// Maybe there are some things that have been expanded by your Framework,<br />
    /// so they need to be added.
    /// The type must follow the type of each event handler.
    /// </remarks>
    public static class DataGridViewR3Extends
    {
        /// <summary><see cref="DataGridView.AllowUserToAddRowsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AllowUserToAddRowsChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToAddRowsChanged += h,
                h => dgv.AllowUserToAddRowsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToDeleteRowsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AllowUserToDeleteRowsChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToDeleteRowsChanged += h,
                h => dgv.AllowUserToDeleteRowsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToOrderColumnsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AllowUserToOrderColumnsChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToOrderColumnsChanged += h,
                h => dgv.AllowUserToOrderColumnsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToResizeColumnsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AllowUserToResizeColumnsChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToResizeColumnsChanged += h,
                h => dgv.AllowUserToResizeColumnsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToResizeRowsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AllowUserToResizeRowsChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToResizeRowsChanged += h,
                h => dgv.AllowUserToResizeRowsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AlternatingRowsDefaultCellStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AlternatingRowsDefaultCellStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AlternatingRowsDefaultCellStyleChanged += h,
                h => dgv.AlternatingRowsDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoGenerateColumnsChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> AutoGenerateColumnsChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoGenerateColumnsChanged += h,
                h => dgv.AutoGenerateColumnsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoSizeColumnModeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewAutoSizeColumnModeEventArgs> AutoSizeColumnModeChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeColumnModeEventHandler, DataGridViewAutoSizeColumnModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeColumnModeChanged += h,
                h => dgv.AutoSizeColumnModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoSizeColumnsModeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewAutoSizeColumnsModeEventArgs> AutoSizeColumnsModeChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeColumnsModeEventHandler, DataGridViewAutoSizeColumnsModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeColumnsModeChanged += h,
                h => dgv.AutoSizeColumnsModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoSizeRowsModeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewAutoSizeModeEventArgs> AutoSizeRowsModeChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeRowsModeChanged += h,
                h => dgv.AutoSizeRowsModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.BackgroundColorChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BackgroundColorChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.BackgroundColorChanged += h,
                h => dgv.BackgroundColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.BorderStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> BorderStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.BorderStyleChanged += h,
                h => dgv.BorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CancelRowEdit"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<QuestionEventArgs> CancelRowEditAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<QuestionEventHandler, QuestionEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CancelRowEdit += h,
                h => dgv.CancelRowEdit -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellBeginEdit"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellCancelEventArgs> CellBeginEditAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellBeginEdit += h,
                h => dgv.CellBeginEdit -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellBorderStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CellBorderStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellBorderStyleChanged += h,
                h => dgv.CellBorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellClick += h,
                h => dgv.CellClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContentClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellContentClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContentClick += h,
                h => dgv.CellContentClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContentDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellContentDoubleClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContentDoubleClick += h,
                h => dgv.CellContentDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContextMenuStripChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellContextMenuStripChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContextMenuStripChanged += h,
                h => dgv.CellContextMenuStripChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContextMenuStripNeeded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellContextMenuStripNeededEventArgs> CellContextMenuStripNeededAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellContextMenuStripNeededEventHandler, DataGridViewCellContextMenuStripNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContextMenuStripNeeded += h,
                h => dgv.CellContextMenuStripNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellDoubleClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellDoubleClick += h,
                h => dgv.CellDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellEndEdit"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellEndEditAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellEndEdit += h,
                h => dgv.CellEndEdit -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellEnter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellEnterAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellEnter += h,
                h => dgv.CellEnter -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellErrorTextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellErrorTextChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellErrorTextChanged += h,
                h => dgv.CellErrorTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellErrorTextNeeded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellErrorTextNeededEventArgs> CellErrorTextNeededAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellErrorTextNeededEventHandler, DataGridViewCellErrorTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellErrorTextNeeded += h,
                h => dgv.CellErrorTextNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellFormatting"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellFormattingEventArgs> CellFormattingAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellFormattingEventHandler, DataGridViewCellFormattingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellFormatting += h,
                h => dgv.CellFormatting -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellLeave"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellLeaveAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellLeave += h,
                h => dgv.CellLeave -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> CellMouseClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseClick += h,
                h => dgv.CellMouseClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> CellMouseDoubleClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseDoubleClick += h,
                h => dgv.CellMouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseDown"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> CellMouseDownAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseDown += h,
                h => dgv.CellMouseDown -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseEnter"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellMouseEnterAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseEnter += h,
                h => dgv.CellMouseEnter -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseLeave"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellMouseLeaveAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseLeave += h,
                h => dgv.CellMouseLeave -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseMove"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> CellMouseMoveAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseMove += h,
                h => dgv.CellMouseMove -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseUp"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> CellMouseUpAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseUp += h,
                h => dgv.CellMouseUp -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellPainting"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellPaintingEventArgs> CellPaintingAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellPaintingEventHandler, DataGridViewCellPaintingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellPainting += h,
                h => dgv.CellPainting -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellParsing"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellParsingEventArgs> CellParsingAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellParsingEventHandler, DataGridViewCellParsingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellParsing += h,
                h => dgv.CellParsing -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellStateChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellStateChangedEventArgs> CellStateChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellStateChangedEventHandler, DataGridViewCellStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStateChanged += h,
                h => dgv.CellStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStyleChanged += h,
                h => dgv.CellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellStyleContentChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellStyleContentChangedEventArgs> CellStyleContentChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellStyleContentChangedEventHandler, DataGridViewCellStyleContentChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStyleContentChanged += h,
                h => dgv.CellStyleContentChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellToolTipTextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellToolTipTextChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellToolTipTextChanged += h,
                h => dgv.CellToolTipTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellToolTipTextNeeded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellToolTipTextNeededEventArgs> CellToolTipTextNeededAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellToolTipTextNeededEventHandler, DataGridViewCellToolTipTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellToolTipTextNeeded += h,
                h => dgv.CellToolTipTextNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValidated"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellValidatedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValidated += h,
                h => dgv.CellValidated -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValidating"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellValidatingEventArgs> CellValidatingAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellValidatingEventHandler, DataGridViewCellValidatingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValidating += h,
                h => dgv.CellValidating -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValueChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellEventArgs> CellValueChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValueChanged += h,
                h => dgv.CellValueChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValueNeeded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellValueEventArgs> CellValueNeededAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValueNeeded += h,
                h => dgv.CellValueNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValuePushed"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellValueEventArgs> CellValuePushedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValuePushed += h,
                h => dgv.CellValuePushed -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnAdded"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnAddedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnAdded += h,
                h => dgv.ColumnAdded -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnContextMenuStripChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnContextMenuStripChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnContextMenuStripChanged += h,
                h => dgv.ColumnContextMenuStripChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDataPropertyNameChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnDataPropertyNameChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDataPropertyNameChanged += h,
                h => dgv.ColumnDataPropertyNameChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDefaultCellStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnDefaultCellStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDefaultCellStyleChanged += h,
                h => dgv.ColumnDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDisplayIndexChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnDisplayIndexChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDisplayIndexChanged += h,
                h => dgv.ColumnDisplayIndexChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDividerDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnDividerDoubleClickEventArgs> ColumnDividerDoubleClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnDividerDoubleClickEventHandler, DataGridViewColumnDividerDoubleClickEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDividerDoubleClick += h,
                h => dgv.ColumnDividerDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDividerWidthChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnDividerWidthChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDividerWidthChanged += h,
                h => dgv.ColumnDividerWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeaderCellChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnHeaderCellChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderCellChanged += h,
                h => dgv.ColumnHeaderCellChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeaderMouseClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> ColumnHeaderMouseClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderMouseClick += h,
                h => dgv.ColumnHeaderMouseClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeaderMouseDoubleClick"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewCellMouseEventArgs> ColumnHeaderMouseDoubleClickAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderMouseDoubleClick += h,
                h => dgv.ColumnHeaderMouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersBorderStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ColumnHeadersBorderStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersBorderStyleChanged += h,
                h => dgv.ColumnHeadersBorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersDefaultCellStyleChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ColumnHeadersDefaultCellStyleChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersDefaultCellStyleChanged += h,
                h => dgv.ColumnHeadersDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersHeightChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> ColumnHeadersHeightChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersHeightChanged += h,
                h => dgv.ColumnHeadersHeightChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersHeightSizeModeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewAutoSizeModeEventArgs> ColumnHeadersHeightSizeModeChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersHeightSizeModeChanged += h,
                h => dgv.ColumnHeadersHeightSizeModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnMinimumWidthChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnMinimumWidthChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnMinimumWidthChanged += h,
                h => dgv.ColumnMinimumWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnNameChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnNameChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnNameChanged += h,
                h => dgv.ColumnNameChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnRemoved"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnRemovedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnRemoved += h,
                h => dgv.ColumnRemoved -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnSortModeChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnSortModeChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnSortModeChanged += h,
                h => dgv.ColumnSortModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnStateChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnStateChangedEventArgs> ColumnStateChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnStateChangedEventHandler, DataGridViewColumnStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnStateChanged += h,
                h => dgv.ColumnStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnToolTipTextChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnToolTipTextChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnToolTipTextChanged += h,
                h => dgv.ColumnToolTipTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnWidthChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewColumnEventArgs> ColumnWidthChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnWidthChanged += h,
                h => dgv.ColumnWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CurrentCellChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CurrentCellChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CurrentCellChanged += h,
                h => dgv.CurrentCellChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CurrentCellDirtyStateChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> CurrentCellDirtyStateChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CurrentCellDirtyStateChanged += h,
                h => dgv.CurrentCellDirtyStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataBindingComplete"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewBindingCompleteEventArgs> DataBindingCompleteAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewBindingCompleteEventHandler, DataGridViewBindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataBindingComplete += h,
                h => dgv.DataBindingComplete -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataError"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<DataGridViewDataErrorEventArgs> DataErrorAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewDataErrorEventHandler, DataGridViewDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataError += h,
                h => dgv.DataError -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataMemberChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DataMemberChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataMemberChanged += h,
                h => dgv.DataMemberChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataSourceChanged"/> as <see cref="Observable(Of EventArgs)"/></summary>
        /// <param name="dgv">target</param>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public static Observable<EventArgs> DataSourceChangedAsObservable(
            this DataGridView dgv,
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataSourceChanged += h,
                h => dgv.DataSourceChanged -= h,
                tkn);
    }
}
