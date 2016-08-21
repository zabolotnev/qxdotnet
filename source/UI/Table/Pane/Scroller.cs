using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Pane
{
    /// <summary>
    /// Shows a whole meta column. This includes a {@link Header},
    /// a {@link Pane} and the needed scroll bars. This class handles the
    /// virtual scrolling and does all the pointer event handling.
    /// 
    /// </summary>
    public partial class Scroller : qxDotNet.UI.Core.Widget
    {

        private bool? _contextMenuFromDataCellsOnly = true;
        private bool? _focusCellOnPointerMove = false;
        private bool? _horizontalScrollBarVisible = false;
        private bool? _liveResize = false;
        private bool? _resetSelectionOnHeaderTap = true;
        private int _scrollTimeout = 100;
        private bool? _selectBeforeFocus = false;
        private bool? _showCellFocusIndicator = true;
        private qxDotNet.UI.Table.Pane.Model _tablePaneModel = null;
        private bool? _verticalScrollBarVisible = false;
        private int _scrollX = 0;
        private qxDotNet.UI.Core.Widget _topRightWidget = null;


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
        /// Whether to show the horizontal scroll bar
        /// 
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
        /// Whether column resize should be live. If false, during resize only a line is
        /// shown and the real resize happens when the user releases the pointer button.
        /// 
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
        /// Interval time (in milliseconds) for the table update timer.
        /// Setting this to 0 clears the timer.
        /// 
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
        /// Whether to handle selections via the selection manager before setting the
        /// focus. The traditional behavior is to handle selections after setting the
        /// focus, but setting the focus means redrawing portions of the table, and
        /// some subclasses may want to modify the data to be displayed based on the
        /// selection.
        /// 
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
        /// The table pane model.
        /// 
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
        /// 
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
        /// Get the current position of the vertical scroll bar.
        /// 
        /// Set the current position of the vertical scroll bar.
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
        /// Get the top right widget
        /// 
        /// Sets the widget that should be shown in the top right corner.
        /// 
        /// The widget will not be disposed, when this table scroller is disposed. So the
        /// caller has to dispose it.
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.pane.Scroller";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("contextMenuFromDataCellsOnly", _contextMenuFromDataCellsOnly, true);
            state.SetPropertyValue("focusCellOnPointerMove", _focusCellOnPointerMove, false);
            state.SetPropertyValue("horizontalScrollBarVisible", _horizontalScrollBarVisible, false);
            state.SetPropertyValue("liveResize", _liveResize, false);
            state.SetPropertyValue("resetSelectionOnHeaderTap", _resetSelectionOnHeaderTap, true);
            state.SetPropertyValue("scrollTimeout", _scrollTimeout, 100);
            state.SetPropertyValue("selectBeforeFocus", _selectBeforeFocus, false);
            state.SetPropertyValue("showCellFocusIndicator", _showCellFocusIndicator, true);
            state.SetPropertyValue("tablePaneModel", _tablePaneModel, null);
            state.SetPropertyValue("verticalScrollBarVisible", _verticalScrollBarVisible, false);
            state.SetPropertyValue("scrollX", _scrollX, 0);
            state.SetPropertyValue("topRightWidget", _topRightWidget, null);

            if (BeforeSort != null)
            {
                state.SetEvent("beforeSort", false);
            }
            if (CellContextmenu != null)
            {
                state.SetEvent("cellContextmenu", false);
            }
            if (CellDbltap != null)
            {
                state.SetEvent("cellDbltap", false);
            }
            if (CellTap != null)
            {
                state.SetEvent("cellTap", false);
            }
            if (ChangeScrollX != null)
            {
                state.SetEvent("changeScrollX", false);
            }
            if (ChangeScrollY != null)
            {
                state.SetEvent("changeScrollY", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "beforeSort")
            {
                OnBeforeSort();
            }
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
            if (eventName == "changeScrollX")
            {
                OnChangeScrollX();
            }
            if (eventName == "changeScrollY")
            {
                OnChangeScrollY();
            }
        }

        /// <summary>
        /// Raises event 'BeforeSort'
        /// </summary>
        protected virtual void OnBeforeSort()
        {
            if (BeforeSort != null)
            {
                BeforeSort.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched when a sortable header was tapped
        /// 
        /// </summary>
        public event EventHandler BeforeSort;

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
        /// See {@link qx.ui.table.Table#cellContextmenu}.
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
        /// See {@link qx.ui.table.Table#cellDbltap}.
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
        /// See {@link qx.ui.table.Table#cellTap}.
        /// 
        /// </summary>
        public event EventHandler CellTap;

        /// <summary>
        /// Raises event 'ChangeHorizontalScrollBarVisible'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeScrollX'
        /// </summary>
        protected virtual void OnChangeScrollX()
        {
            if (ChangeScrollX != null)
            {
                ChangeScrollX.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched if the pane is scrolled vertically
        /// 
        /// </summary>
        public event EventHandler ChangeScrollX;

        /// <summary>
        /// Raises event 'ChangeScrollY'
        /// </summary>
        protected virtual void OnChangeScrollY()
        {
            if (ChangeScrollY != null)
            {
                ChangeScrollY.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Dispatched if the pane is scolled horizontally
        /// 
        /// </summary>
        public event EventHandler ChangeScrollY;

        /// <summary>
        /// Raises event 'ChangeTablePaneModel'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeVerticalScrollBarVisible'
        /// </summary>
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
