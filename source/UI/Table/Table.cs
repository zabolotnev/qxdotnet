using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table
{
    /// <summary>
    /// Table
    /// 
    /// A detailed description can be found in the package description
    /// {@link qx.ui.table}.
    /// 
    /// </summary>
    public partial class Table : qxDotNet.UI.Core.Widget
    {

//TODO: private _var _additionalStatusBarText = null;
        private bool? _alwaysUpdateCells = false;
        private bool? _columnVisibilityButtonVisible = true;
        private bool? _contextMenuFromDataCellsOnly = true;
        private qxDotNet.UI.Table.IRowRenderer _dataRowRenderer = null;
        private bool? _focusCellOnPointerMove = false;
        private bool? _forceLineHeight = true;
        private int _headerCellHeight = 16;
        private bool? _headerCellsVisible = true;
//TODO: private _var _initiallyHiddenColumns = null;
        private bool? _keepFirstVisibleRowComplete = true;
//TODO: private _var _metaColumnCounts = null;
        private bool? _resetSelectionOnHeaderTap = true;
        private bool? _rowFocusChangeModifiesSelection = true;
        private decimal _rowHeight = 20m;
        private qxDotNet.UI.Table.Selection.Model _selectionModel = null;
        private bool? _showCellFocusIndicator = true;
        private bool? _statusBarVisible = true;
        private qxDotNet.UI.Table.ITableModel _tableModel = null;
        private float _dragScrollSlowDownFactor = 0.1f;
        private int _dragScrollThresholdX = 30;
        private int _dragScrollThresholdY = 30;


        /// <summary>
        /// Whether the table cells should be updated when only the selection or the
        /// focus changed. This slows down the table update but allows to react on a
        /// changed selection or a changed focus in a cell renderer.
        /// 
        /// </summary>
        public bool? AlwaysUpdateCells
        {
            get
            {
                return _alwaysUpdateCells;
            }
            set
            {
               _alwaysUpdateCells = value;
            }
        }

        /// <summary>
        /// Whether to show the column visibility button
        /// 
        /// </summary>
        public bool? ColumnVisibilityButtonVisible
        {
            get
            {
                return _columnVisibilityButtonVisible;
            }
            set
            {
               _columnVisibilityButtonVisible = value;
            }
        }

        /// <summary>
        /// By default, the "cellContextmenu" event is fired only when a data cell
        /// is right-clicked. It is not fired when a right-click occurs in the
        /// empty area of the table below the last data row. By turning on this
        /// property, "cellContextMenu" events will also be generated when a
        /// right-click occurs in that empty area. In such a case, row identifier
        /// in the event data will be null, so event handlers can check (row ===
        /// null) to handle this case.
        /// 
        /// </summary>
        public bool? ContextMenuFromDataCellsOnly
        {
            get
            {
                return _contextMenuFromDataCellsOnly;
            }
            set
            {
               _contextMenuFromDataCellsOnly = value;
            }
        }

        /// <summary>
        /// The renderer to use for styling the rows.
        /// 
        /// </summary>
        public qxDotNet.UI.Table.IRowRenderer DataRowRenderer
        {
            get
            {
                return _dataRowRenderer;
            }
            set
            {
               _dataRowRenderer = value;
               OnChangeDataRowRenderer();
            }
        }

        /// <summary>
        /// Whether the focus should moved when the pointer is moved over a cell. If false
        /// the focus is only moved on pointer taps.
        /// 
        /// </summary>
        public bool? FocusCellOnPointerMove
        {
            get
            {
                return _focusCellOnPointerMove;
            }
            set
            {
               _focusCellOnPointerMove = value;
            }
        }

        /// <summary>
        /// Force line height to match row height. May be disabled if cell
        /// renderers being used wish to render multiple lines of data within a
        /// cell. (With the default setting, all but the first of multiple lines
        /// of data will not be visible.)
        /// 
        /// </summary>
        public bool? ForceLineHeight
        {
            get
            {
                return _forceLineHeight;
            }
            set
            {
               _forceLineHeight = value;
            }
        }

        /// <summary>
        /// The height of the header cells.
        /// 
        /// </summary>
        public int HeaderCellHeight
        {
            get
            {
                return _headerCellHeight;
            }
            set
            {
               _headerCellHeight = value;
               OnChangeHeaderCellHeight();
            }
        }

        /// <summary>
        /// Whether the header cells are visible. When setting this to false,
        ///  you'll likely also want to set the {#columnVisibilityButtonVisible}
        ///  property to false as well, to entirely remove the header row.
        /// 
        /// </summary>
        public bool? HeaderCellsVisible
        {
            get
            {
                return _headerCellsVisible;
            }
            set
            {
               _headerCellsVisible = value;
            }
        }

        /// <summary>
        /// Whether the table should keep the first visible row complete. If set to false,
        /// the first row may be rendered partial, depending on the vertical scroll value.
        /// 
        /// </summary>
        public bool? KeepFirstVisibleRowComplete
        {
            get
            {
                return _keepFirstVisibleRowComplete;
            }
            set
            {
               _keepFirstVisibleRowComplete = value;
            }
        }

        /// <summary>
        /// Whether to reset the selection when a header cell is tapped. Since
        /// most data models do not have provisions to retain a selection after
        /// sorting, the default is to reset the selection in this case. Some data
        /// models, however, do have the capability to retain the selection, so
        /// when using those, this property should be set to false.
        /// 
        /// </summary>
        public bool? ResetSelectionOnHeaderTap
        {
            get
            {
                return _resetSelectionOnHeaderTap;
            }
            set
            {
               _resetSelectionOnHeaderTap = value;
            }
        }

        /// <summary>
        /// Whether row focus change by keyboard also modifies selection
        /// 
        /// </summary>
        public bool? RowFocusChangeModifiesSelection
        {
            get
            {
                return _rowFocusChangeModifiesSelection;
            }
            set
            {
               _rowFocusChangeModifiesSelection = value;
            }
        }

        /// <summary>
        /// The height of the table rows.
        /// 
        /// </summary>
        public decimal RowHeight
        {
            get
            {
                return _rowHeight;
            }
            set
            {
               _rowHeight = value;
               OnChangeRowHeight();
            }
        }

        /// <summary>
        /// The selection model.
        /// 
        /// </summary>
        public qxDotNet.UI.Table.Selection.Model SelectionModel
        {
            get
            {
                return _selectionModel;
            }
            set
            {
                _selectionModel = value;
                if (_selectionModel != null)
                {
                    _selectionModel._mapper = this;
                }
                OnChangeSelectionModel();
            }
        }

        /// <summary>
        /// Whether the cell focus indicator should be shown
        /// 
        /// </summary>
        public bool? ShowCellFocusIndicator
        {
            get
            {
                return _showCellFocusIndicator;
            }
            set
            {
               _showCellFocusIndicator = value;
            }
        }

        /// <summary>
        /// Whether to show the status bar
        /// 
        /// </summary>
        public bool? StatusBarVisible
        {
            get
            {
                return _statusBarVisible;
            }
            set
            {
               _statusBarVisible = value;
            }
        }

        /// <summary>
        /// The table model.
        /// 
        /// </summary>
        internal qxDotNet.UI.Table.ITableModel TableModel
        {
            get
            {
                return _tableModel;
            }
            set
            {
               _tableModel = value;
               OnChangeTableModel();
            }
        }

        /// <summary>
        /// The factor for slowing down the scrolling.
        /// 
        /// </summary>
        public float DragScrollSlowDownFactor
        {
            get
            {
                return _dragScrollSlowDownFactor;
            }
            set
            {
               _dragScrollSlowDownFactor = value;
            }
        }

        /// <summary>
        /// The threshold for the x-axis (in pixel) to activate scrolling at the edges.
        /// 
        /// </summary>
        public int DragScrollThresholdX
        {
            get
            {
                return _dragScrollThresholdX;
            }
            set
            {
               _dragScrollThresholdX = value;
            }
        }

        /// <summary>
        /// The threshold for the y-axis (in pixel) to activate scrolling at the edges.
        /// 
        /// </summary>
        public int DragScrollThresholdY
        {
            get
            {
                return _dragScrollThresholdY;
            }
            set
            {
               _dragScrollThresholdY = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.Table";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("alwaysUpdateCells", _alwaysUpdateCells, false);
            state.SetPropertyValue("columnVisibilityButtonVisible", _columnVisibilityButtonVisible, true);
            state.SetPropertyValue("contextMenuFromDataCellsOnly", _contextMenuFromDataCellsOnly, true);
            state.SetPropertyValue("dataRowRenderer", _dataRowRenderer, null);
            state.SetPropertyValue("focusCellOnPointerMove", _focusCellOnPointerMove, false);
            state.SetPropertyValue("forceLineHeight", _forceLineHeight, true);
            state.SetPropertyValue("headerCellHeight", _headerCellHeight, 16);
            state.SetPropertyValue("headerCellsVisible", _headerCellsVisible, true);
            state.SetPropertyValue("keepFirstVisibleRowComplete", _keepFirstVisibleRowComplete, true);
            state.SetPropertyValue("resetSelectionOnHeaderTap", _resetSelectionOnHeaderTap, true);
            state.SetPropertyValue("rowFocusChangeModifiesSelection", _rowFocusChangeModifiesSelection, true);
            state.SetPropertyValue("rowHeight", _rowHeight, 20m);
            state.SetPropertyValue("selectionModel", _selectionModel, null);
            state.SetPropertyValue("showCellFocusIndicator", _showCellFocusIndicator, true);
            state.SetPropertyValue("statusBarVisible", _statusBarVisible, true);
            state.SetPropertyValue("tableModel", _tableModel, null);
            state.SetPropertyValue("dragScrollSlowDownFactor", _dragScrollSlowDownFactor, 0.1f);
            state.SetPropertyValue("dragScrollThresholdX", _dragScrollThresholdX, 30);
            state.SetPropertyValue("dragScrollThresholdY", _dragScrollThresholdY, 30);

            if (CellContextmenu != null)
            {
                state.SetEvent("cellContextmenu", false);
            }
            if (CellDbltap != null)
            {
                state.SetEvent("cellDbltap", true);
            }
            if (CellTap != null)
            {
                state.SetEvent("cellTap", false);
            }
            if (ColumnVisibilityMenuCreateEnd != null)
            {
                state.SetEvent("columnVisibilityMenuCreateEnd", false);
            }
            if (ColumnVisibilityMenuCreateStart != null)
            {
                state.SetEvent("columnVisibilityMenuCreateStart", false);
            }
            if (DataEdited != null)
            {
                state.SetEvent("dataEdited", true);
            }
            if (TableWidthChanged != null)
            {
                state.SetEvent("tableWidthChanged", false);
            }
            if (VerticalScrollBarChanged != null)
            {
                state.SetEvent("verticalScrollBarChanged", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "cellContextmenu")
            {
                OnCellContextmenu();
            }
            if (eventName == "cellDbltap")
            {
                OnCellDbltap();
            }
            if (eventName == "cellTap")
            {
                OnCellTap();
            }
            if (eventName == "columnVisibilityMenuCreateEnd")
            {
                OnColumnVisibilityMenuCreateEnd();
            }
            if (eventName == "columnVisibilityMenuCreateStart")
            {
                OnColumnVisibilityMenuCreateStart();
            }
            if (eventName == "dataEdited")
            {
                OnDataEdited();
            }
            if (eventName == "tableWidthChanged")
            {
                OnTableWidthChanged();
            }
            if (eventName == "verticalScrollBarChanged")
            {
                OnVerticalScrollBarChanged();
            }
        }

        /// <summary>
        /// Raises event 'CellContextmenu'
        /// </summary>
        protected virtual void OnCellContextmenu()
        {
            if (CellContextmenu != null)
            {
                CellContextmenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when the context menu is needed in a data cell
        /// 
        /// </summary>
        public event EventHandler CellContextmenu;

        /// <summary>
        /// Raises event 'CellDbltap'
        /// </summary>
        protected virtual void OnCellDbltap()
        {
            if (CellDbltap != null)
            {
                CellDbltap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when a data cell has been tapped.
        /// 
        /// </summary>
        public event EventHandler CellDbltap;

        /// <summary>
        /// Raises event 'CellTap'
        /// </summary>
        protected virtual void OnCellTap()
        {
            if (CellTap != null)
            {
                CellTap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when a data cell has been tapped.
        /// 
        /// </summary>
        public event EventHandler CellTap;

        /// <summary>
        /// Raises event 'ChangeDataRowRenderer'
        /// </summary>
        protected virtual void OnChangeDataRowRenderer()
        {
            if (ChangeDataRowRenderer != null)
            {
                ChangeDataRowRenderer.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #dataRowRenderer}.
        /// </summary>
        public event EventHandler ChangeDataRowRenderer;

        /// <summary>
        /// Raises event 'ChangeHeaderCellHeight'
        /// </summary>
        protected virtual void OnChangeHeaderCellHeight()
        {
            if (ChangeHeaderCellHeight != null)
            {
                ChangeHeaderCellHeight.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #headerCellHeight}.
        /// </summary>
        public event EventHandler ChangeHeaderCellHeight;

        /// <summary>
        /// Raises event 'ChangeRowHeight'
        /// </summary>
        protected virtual void OnChangeRowHeight()
        {
            if (ChangeRowHeight != null)
            {
                ChangeRowHeight.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #rowHeight}.
        /// </summary>
        public event EventHandler ChangeRowHeight;

        /// <summary>
        /// Raises event 'ChangeSelectionModel'
        /// </summary>
        protected virtual void OnChangeSelectionModel()
        {
            if (ChangeSelectionModel != null)
            {
                ChangeSelectionModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #selectionModel}.
        /// </summary>
        public event EventHandler ChangeSelectionModel;

        /// <summary>
        /// Raises event 'ChangeTableModel'
        /// </summary>
        protected virtual void OnChangeTableModel()
        {
            if (ChangeTableModel != null)
            {
                ChangeTableModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #tableModel}.
        /// </summary>
        public event EventHandler ChangeTableModel;

        /// <summary>
        /// Raises event 'ColumnVisibilityMenuCreateEnd'
        /// </summary>
        protected virtual void OnColumnVisibilityMenuCreateEnd()
        {
            if (ColumnVisibilityMenuCreateEnd != null)
            {
                ColumnVisibilityMenuCreateEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched after adding the column list to the column visibility menu.
        /// The event data is a map with two properties: table and menu. Listeners
        /// may add additional items to the menu, which appear at the bottom of the
        /// menu.
        /// 
        /// </summary>
        public event EventHandler ColumnVisibilityMenuCreateEnd;

        /// <summary>
        /// Raises event 'ColumnVisibilityMenuCreateStart'
        /// </summary>
        protected virtual void OnColumnVisibilityMenuCreateStart()
        {
            if (ColumnVisibilityMenuCreateStart != null)
            {
                ColumnVisibilityMenuCreateStart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched before adding the column list to the column visibility menu.
        /// The event data is a map with two properties: table and menu. Listeners
        /// may add additional items to the menu, which appear at the top of the
        /// menu.
        /// 
        /// </summary>
        public event EventHandler ColumnVisibilityMenuCreateStart;

        /// <summary>
        /// Raises event 'DataEdited'
        /// </summary>
        protected virtual void OnDataEdited()
        {
            if (DataEdited != null)
            {
                DataEdited.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched after a cell editor is flushed.
        /// 
        /// The data is a map containing this properties:
        /// 
        ///  row
        ///  col
        ///  value
        ///  oldValue
        /// 
        /// 
        /// </summary>
        public event EventHandler DataEdited;

        /// <summary>
        /// Raises event 'TableWidthChanged'
        /// </summary>
        protected virtual void OnTableWidthChanged()
        {
            if (TableWidthChanged != null)
            {
                TableWidthChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when the width of the table has changed.
        /// 
        /// </summary>
        public event EventHandler TableWidthChanged;

        /// <summary>
        /// Raises event 'VerticalScrollBarChanged'
        /// </summary>
        protected virtual void OnVerticalScrollBarChanged()
        {
            if (VerticalScrollBarChanged != null)
            {
                VerticalScrollBarChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when updating scrollbars discovers that a vertical scrollbar
        /// is needed when it previously was not, or vice versa. The data is a
        /// boolean indicating whether a vertical scrollbar is now being used.
        /// 
        /// </summary>
        public event EventHandler VerticalScrollBarChanged;

    }
}
