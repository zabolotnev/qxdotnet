using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Pane
{
    /// <summary>
    /// Shows a whole meta column. This includes a {@link Header}, a {@link Pane} and the needed scroll bars. This class handles the virtual scrolling and does all the mouse event handling.
    /// </summary>
    public partial class Scroller : qxDotNet.UI.Core.Widget
    {

        private bool? _contextMenuFromDataCellsOnly = true;
        private bool? _focusCellOnMouseMove = false;
        private bool? _horizontalScrollBarVisible = false;
        private bool? _liveResize = false;
        private bool? _resetSelectionOnHeaderClick = true;
        private int _scrollTimeout = 100;
        private bool? _selectBeforeFocus = false;
        private bool? _showCellFocusIndicator = true;
        private qxDotNet.UI.Table.Pane.Model _tablePaneModel = null;
        private bool? _verticalScrollBarVisible = false;
        private int _scrollX = 0;
        private int _scrollY = 0;
        private qxDotNet.UI.Core.Widget _topRightWidget = null;


        /// <summary>
        /// By default, the "cellContextmenu" event is fired only when a data cell is right-clicked. It is not fired when a right-click occurs in the empty area of the table below the last data row. By turning on this property, "cellContextMenu" events will also be generated when a right-click occurs in that empty area. In such a case, row identifier in the event data will be null, so event handlers can check (row === null) to handle this case.
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
        /// Whether to show the horizontal scroll bar
        /// </summary>
        public bool? HorizontalScrollBarVisible
        {
            get
            {
                return _horizontalScrollBarVisible;
            }
            set
            {
               _horizontalScrollBarVisible = value;
               OnChangeHorizontalScrollBarVisible();
            }
        }

        /// <summary>
        /// Whether column resize should be live. If false, during resize only a line is shown and the real resize happens when the user releases the mouse button.
        /// </summary>
        public bool? LiveResize
        {
            get
            {
                return _liveResize;
            }
            set
            {
               _liveResize = value;
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
        /// Interval time (in milliseconds) for the table update timer. Setting this to 0 clears the timer.
        /// </summary>
        public int ScrollTimeout
        {
            get
            {
                return _scrollTimeout;
            }
            set
            {
               _scrollTimeout = value;
            }
        }

        /// <summary>
        /// Whether to handle selections via the selection manager before setting the focus. The traditional behavior is to handle selections after setting the focus, but setting the focus means redrawing portions of the table, and some subclasses may want to modify the data to be displayed based on the selection.
        /// </summary>
        public bool? SelectBeforeFocus
        {
            get
            {
                return _selectBeforeFocus;
            }
            set
            {
               _selectBeforeFocus = value;
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
        /// The table pane model.
        /// </summary>
        public qxDotNet.UI.Table.Pane.Model TablePaneModel
        {
            get
            {
                return _tablePaneModel;
            }
            set
            {
               _tablePaneModel = value;
               OnChangeTablePaneModel();
            }
        }

        /// <summary>
        /// Whether to show the vertical scroll bar
        /// </summary>
        public bool? VerticalScrollBarVisible
        {
            get
            {
                return _verticalScrollBarVisible;
            }
            set
            {
               _verticalScrollBarVisible = value;
               OnChangeVerticalScrollBarVisible();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ScrollX
        {
            get
            {
                return _scrollX;
            }
            set
            {
               _scrollX = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ScrollY
        {
            get
            {
                return _scrollY;
            }
            set
            {
               _scrollY = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Core.Widget TopRightWidget
        {
            get
            {
                return _topRightWidget;
            }
            set
            {
               _topRightWidget = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.pane.Scroller";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("contextMenuFromDataCellsOnly", _contextMenuFromDataCellsOnly, true);
            state.SetPropertyValue("focusCellOnMouseMove", _focusCellOnMouseMove, false);
            state.SetPropertyValue("horizontalScrollBarVisible", _horizontalScrollBarVisible, false);
            state.SetPropertyValue("liveResize", _liveResize, false);
            state.SetPropertyValue("resetSelectionOnHeaderClick", _resetSelectionOnHeaderClick, true);
            state.SetPropertyValue("scrollTimeout", _scrollTimeout, 100);
            state.SetPropertyValue("selectBeforeFocus", _selectBeforeFocus, false);
            state.SetPropertyValue("showCellFocusIndicator", _showCellFocusIndicator, true);
            state.SetPropertyValue("tablePaneModel", _tablePaneModel, null);
            state.SetPropertyValue("verticalScrollBarVisible", _verticalScrollBarVisible, false);
            state.SetPropertyValue("scrollX", _scrollX, 0);
            state.SetPropertyValue("scrollY", _scrollY, 0);
            state.SetPropertyValue("topRightWidget", _topRightWidget, null);

            state.SetEvent("beforeSort", false);
            state.SetEvent("cellClick", false);
            state.SetEvent("cellContextmenu", false);
            state.SetEvent("cellDblclick", false);
            state.SetEvent("changeScrollX", false);
            state.SetEvent("changeScrollY", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "beforeSort")
            {
                OnBeforeSort();
            }
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
            if (eventName == "changeScrollX")
            {
                OnChangeScrollX();
            }
            if (eventName == "changeScrollY")
            {
                OnChangeScrollY();
            }
        }

        protected virtual void OnBeforeSort()
        {
            if (BeforeSort != null)
            {
                BeforeSort.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when a sortable header was clicked
        /// </summary>
        public event EventHandler BeforeSort;

        protected virtual void OnCellClick()
        {
            if (CellClick != null)
            {
                CellClick.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// See {@link qx.ui.table.Table#cellClick}.
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
        /// See {@link qx.ui.table.Table#cellContextmenu}.
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
        /// See {@link qx.ui.table.Table#cellDblclick}.
        /// </summary>
        public event EventHandler CellDblclick;

        protected virtual void OnChangeHorizontalScrollBarVisible()
        {
            if (ChangeHorizontalScrollBarVisible != null)
            {
                ChangeHorizontalScrollBarVisible.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #horizontalScrollBarVisible}.
        /// </summary>
        public event EventHandler ChangeHorizontalScrollBarVisible;

        protected virtual void OnChangeScrollX()
        {
            if (ChangeScrollX != null)
            {
                ChangeScrollX.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched if the pane is scrolled vertically
        /// </summary>
        public event EventHandler ChangeScrollX;

        protected virtual void OnChangeScrollY()
        {
            if (ChangeScrollY != null)
            {
                ChangeScrollY.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched if the pane is scolled horizontally
        /// </summary>
        public event EventHandler ChangeScrollY;

        protected virtual void OnChangeTablePaneModel()
        {
            if (ChangeTablePaneModel != null)
            {
                ChangeTablePaneModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #tablePaneModel}.
        /// </summary>
        public event EventHandler ChangeTablePaneModel;

        protected virtual void OnChangeVerticalScrollBarVisible()
        {
            if (ChangeVerticalScrollBarVisible != null)
            {
                ChangeVerticalScrollBarVisible.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #verticalScrollBarVisible}.
        /// </summary>
        public event EventHandler ChangeVerticalScrollBarVisible;

    }
}
