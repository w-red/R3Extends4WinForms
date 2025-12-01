using R3;

namespace R3Extends4WinForms;

/// <summary><see cref="R3"/>'s Extends for <see cref="DataGridView"/>.</summary>
/// <remarks>
/// Add extension methods for any events you need.<br />
/// Maybe there are some things that have been expanded by your Framework,<br />
/// so they need to be added.
/// The type must follow the type of each event handler.
/// </remarks>
public static class DataGridViewR3Extends
{
    /// <summary><see cref="DataGridView"/> extension methods.</summary>
    extension(DataGridView dgv)
    {
        /// <summary><see cref="DataGridView.AllowUserToAddRowsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowUserToAddRowsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToAddRowsChanged += h,
                h => dgv.AllowUserToAddRowsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToDeleteRowsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowUserToDeleteRowsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToDeleteRowsChanged += h,
                h => dgv.AllowUserToDeleteRowsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToOrderColumnsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowUserToOrderColumnsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToOrderColumnsChanged += h,
                h => dgv.AllowUserToOrderColumnsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToResizeColumnsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowUserToResizeColumnsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToResizeColumnsChanged += h,
                h => dgv.AllowUserToResizeColumnsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AllowUserToResizeRowsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AllowUserToResizeRowsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AllowUserToResizeRowsChanged += h,
                h => dgv.AllowUserToResizeRowsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AlternatingRowsDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AlternatingRowsDefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AlternatingRowsDefaultCellStyleChanged += h,
                h => dgv.AlternatingRowsDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoGenerateColumnsChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> AutoGenerateColumnsChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoGenerateColumnsChanged += h,
                h => dgv.AutoGenerateColumnsChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoSizeColumnModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewAutoSizeColumnModeEventArgs> AutoSizeColumnModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeColumnModeEventHandler, DataGridViewAutoSizeColumnModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeColumnModeChanged += h,
                h => dgv.AutoSizeColumnModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoSizeColumnsModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewAutoSizeColumnsModeEventArgs> AutoSizeColumnsModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeColumnsModeEventHandler, DataGridViewAutoSizeColumnsModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeColumnsModeChanged += h,
                h => dgv.AutoSizeColumnsModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.AutoSizeRowsModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewAutoSizeModeEventArgs> AutoSizeRowsModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.AutoSizeRowsModeChanged += h,
                h => dgv.AutoSizeRowsModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.BackgroundColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BackgroundColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.BackgroundColorChanged += h,
                h => dgv.BackgroundColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.BorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> BorderStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.BorderStyleChanged += h,
                h => dgv.BorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CancelRowEdit"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<QuestionEventArgs> CancelRowEditAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<QuestionEventHandler, QuestionEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CancelRowEdit += h,
                h => dgv.CancelRowEdit -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellBeginEdit"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellCancelEventArgs> CellBeginEditAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellBeginEdit += h,
                h => dgv.CellBeginEdit -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellBorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CellBorderStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellBorderStyleChanged += h,
                h => dgv.CellBorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellClick += h,
                h => dgv.CellClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContentClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellContentClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContentClick += h,
                h => dgv.CellContentClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContentDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellContentDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContentDoubleClick += h,
                h => dgv.CellContentDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellContextMenuStripChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContextMenuStripChanged += h,
                h => dgv.CellContextMenuStripChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellContextMenuStripNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellContextMenuStripNeededEventArgs> CellContextMenuStripNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellContextMenuStripNeededEventHandler, DataGridViewCellContextMenuStripNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellContextMenuStripNeeded += h,
                h => dgv.CellContextMenuStripNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellDoubleClick += h,
                h => dgv.CellDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellEndEdit"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellEndEditAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellEndEdit += h,
                h => dgv.CellEndEdit -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellEnter += h,
                h => dgv.CellEnter -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellErrorTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellErrorTextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellErrorTextChanged += h,
                h => dgv.CellErrorTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellErrorTextNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellErrorTextNeededEventArgs> CellErrorTextNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellErrorTextNeededEventHandler, DataGridViewCellErrorTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellErrorTextNeeded += h,
                h => dgv.CellErrorTextNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellFormatting"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellFormattingEventArgs> CellFormattingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellFormattingEventHandler, DataGridViewCellFormattingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellFormatting += h,
                h => dgv.CellFormatting -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellLeave += h,
                h => dgv.CellLeave -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> CellMouseClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseClick += h,
                h => dgv.CellMouseClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> CellMouseDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseDoubleClick += h,
                h => dgv.CellMouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseDown"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> CellMouseDownAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseDown += h,
                h => dgv.CellMouseDown -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellMouseEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseEnter += h,
                h => dgv.CellMouseEnter -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellMouseLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseLeave += h,
                h => dgv.CellMouseLeave -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseMove"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> CellMouseMoveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseMove += h,
                h => dgv.CellMouseMove -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellMouseUp"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> CellMouseUpAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellMouseUp += h,
                h => dgv.CellMouseUp -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellPainting"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellPaintingEventArgs> CellPaintingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellPaintingEventHandler, DataGridViewCellPaintingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellPainting += h,
                h => dgv.CellPainting -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellParsing"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellParsingEventArgs> CellParsingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellParsingEventHandler, DataGridViewCellParsingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellParsing += h,
                h => dgv.CellParsing -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellStateChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellStateChangedEventArgs> CellStateChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellStateChangedEventHandler, DataGridViewCellStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStateChanged += h,
                h => dgv.CellStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStyleChanged += h,
                h => dgv.CellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellStyleContentChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellStyleContentChangedEventArgs> CellStyleContentChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellStyleContentChangedEventHandler, DataGridViewCellStyleContentChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellStyleContentChanged += h,
                h => dgv.CellStyleContentChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellToolTipTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellToolTipTextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellToolTipTextChanged += h,
                h => dgv.CellToolTipTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellToolTipTextNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellToolTipTextNeededEventArgs> CellToolTipTextNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellToolTipTextNeededEventHandler, DataGridViewCellToolTipTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellToolTipTextNeeded += h,
                h => dgv.CellToolTipTextNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValidated"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellValidatedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValidated += h,
                h => dgv.CellValidated -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValidating"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellValidatingEventArgs> CellValidatingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellValidatingEventHandler, DataGridViewCellValidatingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValidating += h,
                h => dgv.CellValidating -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValueChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> CellValueChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValueChanged += h,
                h => dgv.CellValueChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValueNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellValueEventArgs> CellValueNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValueNeeded += h,
                h => dgv.CellValueNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.CellValuePushed"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellValueEventArgs> CellValuePushedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellValueEventHandler, DataGridViewCellValueEventArgs>(
                h => (s, e) => h(e),
                h => dgv.CellValuePushed += h,
                h => dgv.CellValuePushed -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnAdded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnAddedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnAdded += h,
                h => dgv.ColumnAdded -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnContextMenuStripChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnContextMenuStripChanged += h,
                h => dgv.ColumnContextMenuStripChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDataPropertyNameChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnDataPropertyNameChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDataPropertyNameChanged += h,
                h => dgv.ColumnDataPropertyNameChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnDefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDefaultCellStyleChanged += h,
                h => dgv.ColumnDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDisplayIndexChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnDisplayIndexChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDisplayIndexChanged += h,
                h => dgv.ColumnDisplayIndexChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDividerDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnDividerDoubleClickEventArgs> ColumnDividerDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnDividerDoubleClickEventHandler, DataGridViewColumnDividerDoubleClickEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDividerDoubleClick += h,
                h => dgv.ColumnDividerDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnDividerWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnDividerWidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnDividerWidthChanged += h,
                h => dgv.ColumnDividerWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeaderCellChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnHeaderCellChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderCellChanged += h,
                h => dgv.ColumnHeaderCellChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeaderMouseClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> ColumnHeaderMouseClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderMouseClick += h,
                h => dgv.ColumnHeaderMouseClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeaderMouseDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> ColumnHeaderMouseDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeaderMouseDoubleClick += h,
                h => dgv.ColumnHeaderMouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersBorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ColumnHeadersBorderStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersBorderStyleChanged += h,
                h => dgv.ColumnHeadersBorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ColumnHeadersDefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersDefaultCellStyleChanged += h,
                h => dgv.ColumnHeadersDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersHeightChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ColumnHeadersHeightChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersHeightChanged += h,
                h => dgv.ColumnHeadersHeightChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnHeadersHeightSizeModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewAutoSizeModeEventArgs> ColumnHeadersHeightSizeModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnHeadersHeightSizeModeChanged += h,
                h => dgv.ColumnHeadersHeightSizeModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnMinimumWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnMinimumWidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnMinimumWidthChanged += h,
                h => dgv.ColumnMinimumWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnNameChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnNameChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnNameChanged += h,
                h => dgv.ColumnNameChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnRemoved"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnRemovedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnRemoved += h,
                h => dgv.ColumnRemoved -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnSortModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnSortModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnSortModeChanged += h,
                h => dgv.ColumnSortModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnStateChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnStateChangedEventArgs> ColumnStateChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnStateChangedEventHandler, DataGridViewColumnStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnStateChanged += h,
                h => dgv.ColumnStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnToolTipTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnToolTipTextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnToolTipTextChanged += h,
                h => dgv.ColumnToolTipTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ColumnWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewColumnEventArgs> ColumnWidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewColumnEventHandler, DataGridViewColumnEventArgs>(
                h => (s, e) => h(e),
                h => dgv.ColumnWidthChanged += h,
                h => dgv.ColumnWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CurrentCellChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CurrentCellChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CurrentCellChanged += h,
                h => dgv.CurrentCellChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.CurrentCellDirtyStateChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> CurrentCellDirtyStateChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.CurrentCellDirtyStateChanged += h,
                h => dgv.CurrentCellDirtyStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataBindingComplete"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewBindingCompleteEventArgs> DataBindingCompleteAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewBindingCompleteEventHandler, DataGridViewBindingCompleteEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataBindingComplete += h,
                h => dgv.DataBindingComplete -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataError"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewDataErrorEventArgs> DataErrorAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewDataErrorEventHandler, DataGridViewDataErrorEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataError += h,
                h => dgv.DataError -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataMemberChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DataMemberChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataMemberChanged += h,
                h => dgv.DataMemberChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.DataSourceChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DataSourceChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DataSourceChanged += h,
                h => dgv.DataSourceChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.DefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> DefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.DefaultCellStyleChanged += h,
                h => dgv.DefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.DefaultValuesNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> DefaultValuesNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.DefaultValuesNeeded += h,
                h => dgv.DefaultValuesNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.EditingControlShowing"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewEditingControlShowingEventArgs> EditingControlShowingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewEditingControlShowingEventHandler, DataGridViewEditingControlShowingEventArgs>(
                h => (s, e) => h(e),
                h => dgv.EditingControlShowing += h,
                h => dgv.EditingControlShowing -= h,
                tkn);

        /// <summary><see cref="DataGridView.EditModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> EditModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.EditModeChanged += h,
                h => dgv.EditModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.FontChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> FontChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.FontChanged += h,
                h => dgv.FontChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.ForeColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ForeColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ForeColorChanged += h,
                h => dgv.ForeColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.GridColorChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> GridColorChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.GridColorChanged += h,
                h => dgv.GridColorChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.MultiSelectChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> MultiSelectChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.MultiSelectChanged += h,
                h => dgv.MultiSelectChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.NewRowNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> NewRowNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.NewRowNeeded += h,
                h => dgv.NewRowNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.ReadOnlyChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> ReadOnlyChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.ReadOnlyChanged += h,
                h => dgv.ReadOnlyChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowContextMenuStripChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowContextMenuStripChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowContextMenuStripChanged += h,
                h => dgv.RowContextMenuStripChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowContextMenuStripNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowContextMenuStripNeededEventArgs> RowContextMenuStripNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowContextMenuStripNeededEventHandler, DataGridViewRowContextMenuStripNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowContextMenuStripNeeded += h,
                h => dgv.RowContextMenuStripNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowDefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDefaultCellStyleChanged += h,
                h => dgv.RowDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowDirtyStateNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<QuestionEventArgs> RowDirtyStateNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<QuestionEventHandler, QuestionEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDirtyStateNeeded += h,
                h => dgv.RowDirtyStateNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowDividerDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowDividerDoubleClickEventArgs> RowDividerDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowDividerDoubleClickEventHandler, DataGridViewRowDividerDoubleClickEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDividerDoubleClick += h,
                h => dgv.RowDividerDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowDividerHeightChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowDividerHeightChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowDividerHeightChanged += h,
                h => dgv.RowDividerHeightChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowEnter"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> RowEnterAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowEnter += h,
                h => dgv.RowEnter -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowErrorTextChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowErrorTextChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowErrorTextChanged += h,
                h => dgv.RowErrorTextChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowErrorTextNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowErrorTextNeededEventArgs> RowErrorTextNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowErrorTextNeededEventHandler, DataGridViewRowErrorTextNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowErrorTextNeeded += h,
                h => dgv.RowErrorTextNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeaderCellChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowHeaderCellChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeaderCellChanged += h,
                h => dgv.RowHeaderCellChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeaderMouseClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> RowHeaderMouseClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeaderMouseClick += h,
                h => dgv.RowHeaderMouseClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeaderMouseDoubleClick"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellMouseEventArgs> RowHeaderMouseDoubleClickAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellMouseEventHandler, DataGridViewCellMouseEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeaderMouseDoubleClick += h,
                h => dgv.RowHeaderMouseDoubleClick -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeadersBorderStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RowHeadersBorderStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersBorderStyleChanged += h,
                h => dgv.RowHeadersBorderStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeadersDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RowHeadersDefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersDefaultCellStyleChanged += h,
                h => dgv.RowHeadersDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeadersWidthChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RowHeadersWidthChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersWidthChanged += h,
                h => dgv.RowHeadersWidthChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeadersWidthSizeModeChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewAutoSizeModeEventArgs> RowHeadersWidthSizeModeChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewAutoSizeModeEventHandler, DataGridViewAutoSizeModeEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeadersWidthSizeModeChanged += h,
                h => dgv.RowHeadersWidthSizeModeChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeightChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowHeightChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeightChanged += h,
                h => dgv.RowHeightChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeightInfoNeeded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowHeightInfoNeededEventArgs> RowHeightInfoNeededAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowHeightInfoNeededEventHandler, DataGridViewRowHeightInfoNeededEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeightInfoNeeded += h,
                h => dgv.RowHeightInfoNeeded -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowHeightInfoPushed"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowHeightInfoPushedEventArgs> RowHeightInfoPushedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowHeightInfoPushedEventHandler, DataGridViewRowHeightInfoPushedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowHeightInfoPushed += h,
                h => dgv.RowHeightInfoPushed -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowLeave"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> RowLeaveAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowLeave += h,
                h => dgv.RowLeave -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowMinimumHeightChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowMinimumHeightChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowMinimumHeightChanged += h,
                h => dgv.RowMinimumHeightChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowPostPaint"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowPostPaintEventArgs> RowPostPaintAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowPostPaintEventHandler, DataGridViewRowPostPaintEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowPostPaint += h,
                h => dgv.RowPostPaint -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowPrePaint"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowPrePaintEventArgs> RowPrePaintAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowPrePaintEventHandler, DataGridViewRowPrePaintEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowPrePaint += h,
                h => dgv.RowPrePaint -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowsAdded"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowsAddedEventArgs> RowsAddedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowsAddedEventHandler, DataGridViewRowsAddedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowsAdded += h,
                h => dgv.RowsAdded -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowsDefaultCellStyleChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> RowsDefaultCellStyleChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowsDefaultCellStyleChanged += h,
                h => dgv.RowsDefaultCellStyleChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowsRemoved"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowsRemovedEventArgs> RowsRemovedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowsRemovedEventHandler, DataGridViewRowsRemovedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowsRemoved += h,
                h => dgv.RowsRemoved -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowStateChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowStateChangedEventArgs> RowStateChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowStateChangedEventHandler, DataGridViewRowStateChangedEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowStateChanged += h,
                h => dgv.RowStateChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowUnshared"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> RowUnsharedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowUnshared += h,
                h => dgv.RowUnshared -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowValidated"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellEventArgs> RowValidatedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellEventHandler, DataGridViewCellEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowValidated += h,
                h => dgv.RowValidated -= h,
                tkn);

        /// <summary><see cref="DataGridView.RowValidating"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewCellCancelEventArgs> RowValidatingAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewCellCancelEventHandler, DataGridViewCellCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.RowValidating += h,
                h => dgv.RowValidating -= h,
                tkn);

        /// <summary><see cref="DataGridView.Scroll"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<ScrollEventArgs> ScrollAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<ScrollEventHandler, ScrollEventArgs>(
                h => (s, e) => h(e),
                h => dgv.Scroll += h,
                h => dgv.Scroll -= h,
                tkn);

        /// <summary><see cref="DataGridView.SelectionChanged"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SelectionChangedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.SelectionChanged += h,
                h => dgv.SelectionChanged -= h,
                tkn);

        /// <summary><see cref="DataGridView.SortCompare"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewSortCompareEventArgs> SortCompareAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewSortCompareEventHandler, DataGridViewSortCompareEventArgs>(
                h => (s, e) => h(e),
                h => dgv.SortCompare += h,
                h => dgv.SortCompare -= h,
                tkn);

        /// <summary><see cref="DataGridView.Sorted"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<EventArgs> SortedAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<EventHandler, EventArgs>(
                h => (s, e) => h(e),
                h => dgv.Sorted += h,
                h => dgv.Sorted -= h,
                tkn);

        /// <summary><see cref="DataGridView.UserAddedRow"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> UserAddedRowAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.UserAddedRow += h,
                h => dgv.UserAddedRow -= h,
                tkn);

        /// <summary><see cref="DataGridView.UserDeletedRow"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowEventArgs> UserDeletedRowAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowEventHandler, DataGridViewRowEventArgs>(
                h => (s, e) => h(e),
                h => dgv.UserDeletedRow += h,
                h => dgv.UserDeletedRow -= h,
                tkn);

        /// <summary><see cref="DataGridView.UserDeletingRow"/> as <see cref="Observable"/></summary>
        /// <param name="tkn">token</param>
        /// <returns>Observable object.</returns>
        public Observable<DataGridViewRowCancelEventArgs> UserDeletingRowAsObservable(
            CancellationToken tkn = default) =>
            Observable.FromEvent<DataGridViewRowCancelEventHandler, DataGridViewRowCancelEventArgs>(
                h => (s, e) => h(e),
                h => dgv.UserDeletingRow += h,
                h => dgv.UserDeletingRow -= h,
                tkn);
    }
}
