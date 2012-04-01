using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table
{
    /// <summary>
    /// Table  A detailed description can be found in the package description {@link qx.ui.table}.
    /// </summary>
    public partial class Table : qxDotNet.UI.Core.Widget
    {

//        private _var _additionalStatusBarText = null;
        private bool? _alwaysUpdateCells = false;
        private bool? _columnVisibilityButtonVisible = true;
        private bool? _contextMenuFromDataCellsOnly = true;
        private qxDotNet.UI.Table.IRowRenderer _dataRowRenderer = null;
        private bool? _focusCellOnMouseMove = false;
        private bool? _forceLineHeight = true;
        private int _headerCellHeight = 16;
        private bool? _headerCellsVisible = true;
//        private _var _initiallyHiddenColumns = null;
        private bool? _keepFirstVisibleRowComplete = true;
//        private _var _metaColumnCounts = null;
        private bool? _resetSelectionOnHeaderClick = true;
        private bool? _rowFocusChangeModifiesSelection = true;
        private decimal _rowHeight = 20m;
        private qxDotNet.UI.Table.Selection.Model _selectionModel = null;
        private bool? _showCellFocusIndicator = true;
        private bool? _statusBarVisible = true;

        /// <summary>
        /// Whether the table cells should be updated when only the selection or the focus changed. This slows down the table update but allows to react on a changed selection or a changed focus in a cell renderer.
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
        /// By default, the &#8220;cellContextmenu&#8221; event is fired only when a data cell is right-clicked. It is not fired when a right-click occurs in the empty area of the table below the last data row. By turning on this property, &#8220;cellContextMenu&#8221; events will also be generated when a right-click occurs in that empty area. In such a case, row identifier in the event data will be null, so event handlers can check (row === null) to handle this case.
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
        /// Whether the focus should moved when the mouse is moved over a cell. If false the focus is only moved on mouse clicks.
        /// </summary>
        public bool? FocusCellOnMouseMove
        {
            get
            {
                return _focusCellOnMouseMove;
            }
            set
            {
               _focusCellOnMouseMove = value;
            }
        }

        /// <summary>
        /// Force line height to match row height. May be disabled if cell renderers being used wish to render multiple lines of data within a cell. (With the default setting, all but the first of multiple lines of data will not be visible.)
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
        /// Whether the header cells are visible. When setting this to false,  you&#8217;ll likely also want to set the {#columnVisibilityButtonVisible}  property to false as well, to entirely remove the header row.
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
        /// Whether the table should keep the first visible row complete. If set to false, the first row may be rendered partial, depending on the vertical scroll value.
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
        /// Whether to reset the selection when a header cell is clicked. Since most data models do not have provisions to retain a selection after sorting, the default is to reset the selection in this case. Some data models, however, do have the capability to retain the selection, so when using those, this property should be set to false.
        /// </summary>
        public bool? ResetSelectionOnHeaderClick
        {
            get
            {
                return _resetSelectionOnHeaderClick;
            }
            set
            {
               _resetSelectionOnHeaderClick = value;
            }
        }

        /// <summary>
        /// Whether row focus change by keyboard also modifies selection
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
               OnChangeSelectionModel();
            }
        }

        /// <summary>
        /// Whether the cell focus indicator should be shown
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.Table";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("alwaysUpdateCells", _alwaysUpdateCells, false);
            state.SetPropertyValue("columnVisibilityButtonVisible", _columnVisibilityButtonVisible, true);
            state.SetPropertyValue("contextMenuFromDataCellsOnly", _contextMenuFromDataCellsOnly, true);
            state.SetPropertyValue("dataRowRenderer", _dataRowRenderer, null);
            state.SetPropertyValue("focusCellOnMouseMove", _focusCellOnMouseMove, false);
            state.SetPropertyValue("forceLineHeight", _forceLineHeight, true);
            state.SetPropertyValue("headerCellHeight", _headerCellHeight, 16);
            state.SetPropertyValue("headerCellsVisible", _headerCellsVisible, true);
            state.SetPropertyValue("keepFirstVisibleRowComplete", _keepFirstVisibleRowComplete, true);
            state.SetPropertyValue("resetSelectionOnHeaderClick", _resetSelectionOnHeaderClick, true);
            state.SetPropertyValue("rowFocusChangeModifiesSelection", _rowFocusChangeModifiesSelection, true);
            state.SetPropertyValue("rowHeight", _rowHeight, 20m);
            state.SetPropertyValue("selectionModel", _selectionModel, null);
            state.SetPropertyValue("showCellFocusIndicator", _showCellFocusIndicator, true);
            state.SetPropertyValue("statusBarVisible", _statusBarVisible, true);
            state.SetPropertyValue("tableModel", _model, null);

            if (CellClick != null)
            {
                state.SetEvent("cellClick", false);
            }
            if (CellContextmenu != null)
            {
                state.SetEvent("cellContextmenu", false);
            }
            if (CellDblclick != null)
            {
                state.SetEvent("cellDblclick", false);
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
                state.SetEvent("dataEdited", false);
            }
            if (TableWidthChanged != null)
            {
                state.SetEvent("tableWidthChanged", false);
            }
            if (VerticalScrollBarChanged != null)
            {
                state.SetEvent("verticalScrollBarChanged", false);
            }

            state.SetEvent("cellDblclick", true);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "cellClick")
            {
                OnCellClick();
            }
            if (eventName == "cellContextmenu")
            {
                OnCellContextmenu();
            }
            if (eventName == "cellDblclick")
            {
                OnCellDblclick();
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

        protected virtual void OnCellClick()
        {
            if (CellClick != null)
            {
                CellClick.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when a data cell has been clicked.
        /// </summary>
        public event EventHandler CellClick;

        protected virtual void OnCellContextmenu()
        {
            if (CellContextmenu != null)
            {
                CellContextmenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when the context menu is needed in a data cell
        /// </summary>
        public event EventHandler CellContextmenu;

        protected virtual void OnCellDblclick()
        {
            if (CellDblclick != null)
            {
                CellDblclick.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when a data cell has been clicked.
        /// </summary>
        public event EventHandler CellDblclick;

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

        protected virtual void OnColumnVisibilityMenuCreateEnd()
        {
            if (ColumnVisibilityMenuCreateEnd != null)
            {
                ColumnVisibilityMenuCreateEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched after adding the column list to the column visibility menu. The event data is a map with two properties: table and menu. Listeners may add additional items to the menu, which appear at the bottom of the menu.
        /// </summary>
        public event EventHandler ColumnVisibilityMenuCreateEnd;

        protected virtual void OnColumnVisibilityMenuCreateStart()
        {
            if (ColumnVisibilityMenuCreateStart != null)
            {
                ColumnVisibilityMenuCreateStart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched before adding the column list to the column visibility menu. The event data is a map with two properties: table and menu. Listeners may add additional items to the menu, which appear at the top of the menu.
        /// </summary>
        public event EventHandler ColumnVisibilityMenuCreateStart;

        protected virtual void OnDataEdited()
        {
            if (DataEdited != null)
            {
                DataEdited.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched after a cell editor is flushed.  The data is a map containing this properties:   row  col  value  oldValue 
        /// </summary>
        public event EventHandler DataEdited;

        protected virtual void OnTableWidthChanged()
        {
            if (TableWidthChanged != null)
            {
                TableWidthChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when the width of the table has changed.
        /// </summary>
        public event EventHandler TableWidthChanged;

        protected virtual void OnVerticalScrollBarChanged()
        {
            if (VerticalScrollBarChanged != null)
            {
                VerticalScrollBarChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when updating scrollbars discovers that a vertical scrollbar is needed when it previously was not, or vice versa. The data is a boolean indicating whether a vertical scrollbar is now being used.
        /// </summary>
        public event EventHandler VerticalScrollBarChanged;

    }
}
