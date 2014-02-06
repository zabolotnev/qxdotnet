using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmodel
{
    /// <summary>
    /// A model that contains all meta data about columns, such as width, renderer, visibility and order.
    /// </summary>
    public partial class Basic : qxDotNet.Core.Object
    {

        private qxDotNet.UI.Table.ICellEditorFactory _cellEditorFactory = null;
        private int _columnWidth = 0;
        private qxDotNet.UI.Table.ICellRenderer _dataCellRenderer = null;
        private qxDotNet.UI.Table.IHeaderRenderer _headerCellRenderer = null;


        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Table.ICellEditorFactory CellEditorFactory
        {
            get
            {
                return _cellEditorFactory;
            }
            set
            {
               _cellEditorFactory = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ColumnWidth
        {
            get
            {
                return _columnWidth;
            }
            set
            {
               _columnWidth = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Table.ICellRenderer DataCellRenderer
        {
            get
            {
                return _dataCellRenderer;
            }
            set
            {
               _dataCellRenderer = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Table.IHeaderRenderer HeaderCellRenderer
        {
            get
            {
                return _headerCellRenderer;
            }
            set
            {
               _headerCellRenderer = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.columnmodel.Basic";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("cellEditorFactory", _cellEditorFactory, null);
            state.SetPropertyValue("columnWidth", _columnWidth, 0);
            state.SetPropertyValue("dataCellRenderer", _dataCellRenderer, null);
            state.SetPropertyValue("headerCellRenderer", _headerCellRenderer, null);

            state.SetEvent("headerCellRendererChanged", false);
            state.SetEvent("orderChanged", false);
            state.SetEvent("visibilityChanged", false);
            state.SetEvent("visibilityChangedPre", false);
            state.SetEvent("widthChanged", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "headerCellRendererChanged")
            {
                OnHeaderCellRendererChanged();
            }
            if (eventName == "orderChanged")
            {
                OnOrderChanged();
            }
            if (eventName == "visibilityChanged")
            {
                OnVisibilityChanged();
            }
            if (eventName == "visibilityChangedPre")
            {
                OnVisibilityChangedPre();
            }
            if (eventName == "widthChanged")
            {
                OnWidthChanged();
            }
        }

        protected virtual void OnHeaderCellRendererChanged()
        {
            if (HeaderCellRendererChanged != null)
            {
                HeaderCellRendererChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the cell renderer of a column has changed. The data property of the event is a map having the following attributes:   col: The model index of the column that was moved. 
        /// </summary>
        public event EventHandler HeaderCellRendererChanged;

        protected virtual void OnOrderChanged()
        {
            if (OrderChanged != null)
            {
                OrderChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the column order has changed. The data property of the event is a map having the following attributes:   col: The model index of the column that was moved.  fromOverXPos: The old overall x position of the column.  toOverXPos: The new overall x position of the column. 
        /// </summary>
        public event EventHandler OrderChanged;

        protected virtual void OnVisibilityChanged()
        {
            if (VisibilityChanged != null)
            {
                VisibilityChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the visibility of a column has changed. The data property of the event is a map having the following attributes:   col: The model index of the column the visibility of which has changed.  visible: Whether the column is now visible. 
        /// </summary>
        public event EventHandler VisibilityChanged;

        protected virtual void OnVisibilityChangedPre()
        {
            if (VisibilityChangedPre != null)
            {
                VisibilityChangedPre.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the visibility of a column has changed. This event is equal to "visibilityChanged", but is fired right before.
        /// </summary>
        public event EventHandler VisibilityChangedPre;

        protected virtual void OnWidthChanged()
        {
            if (WidthChanged != null)
            {
                WidthChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the width of a column has changed. The data property of the event is a map having the following attributes:   col: The model index of the column the width of which has changed.  newWidth: The new width of the column in pixels.  oldWidth: The old width of the column in pixels. 
        /// </summary>
        public event EventHandler WidthChanged;

    }
}
