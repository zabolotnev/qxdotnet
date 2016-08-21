using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmodel
{
    /// <summary>
    /// A model that contains all meta data about columns, such as width, renderer,
    /// visibility and order.
    /// 
    /// </summary>
    public partial class Basic : qxDotNet.Core.Object
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.columnmodel.Basic";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (HeaderCellRendererChanged != null)
            {
                state.SetEvent("headerCellRendererChanged", false);
            }
            if (OrderChanged != null)
            {
                state.SetEvent("orderChanged", false);
            }
            if (VisibilityChanged != null)
            {
                state.SetEvent("visibilityChanged", false);
            }
            if (VisibilityChangedPre != null)
            {
                state.SetEvent("visibilityChangedPre", false);
            }
            if (WidthChanged != null)
            {
                state.SetEvent("widthChanged", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
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

        /// <summary>
        /// Raises event 'HeaderCellRendererChanged'
        /// </summary>
        protected virtual void OnHeaderCellRendererChanged()
        {
            if (HeaderCellRendererChanged != null)
            {
                HeaderCellRendererChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the cell renderer of a column has changed.
        /// The data property of the event is a map having the following attributes:
        /// 
        ///  col: The model index of the column that was moved.
        /// 
        /// 
        /// </summary>
        public event EventHandler HeaderCellRendererChanged;

        /// <summary>
        /// Raises event 'OrderChanged'
        /// </summary>
        protected virtual void OnOrderChanged()
        {
            if (OrderChanged != null)
            {
                OrderChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the column order has changed. The data property of the
        /// event is a map having the following attributes:
        /// 
        ///  col: The model index of the column that was moved.
        ///  fromOverXPos: The old overall x position of the column.
        ///  toOverXPos: The new overall x position of the column.
        /// 
        /// 
        /// </summary>
        public event EventHandler OrderChanged;

        /// <summary>
        /// Raises event 'VisibilityChanged'
        /// </summary>
        protected virtual void OnVisibilityChanged()
        {
            if (VisibilityChanged != null)
            {
                VisibilityChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the visibility of a column has changed. The data property of the
        /// event is a map having the following attributes:
        /// 
        ///  col: The model index of the column the visibility of which has changed.
        ///  visible: Whether the column is now visible.
        /// 
        /// 
        /// </summary>
        public event EventHandler VisibilityChanged;

        /// <summary>
        /// Raises event 'VisibilityChangedPre'
        /// </summary>
        protected virtual void OnVisibilityChangedPre()
        {
            if (VisibilityChangedPre != null)
            {
                VisibilityChangedPre.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the visibility of a column has changed. This event is equal to
        /// "visibilityChanged", but is fired right before.
        /// 
        /// </summary>
        public event EventHandler VisibilityChangedPre;

        /// <summary>
        /// Raises event 'WidthChanged'
        /// </summary>
        protected virtual void OnWidthChanged()
        {
            if (WidthChanged != null)
            {
                WidthChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the width of a column has changed. The data property of the event is
        /// a map having the following attributes:
        /// 
        ///  col: The model index of the column the width of which has changed.
        ///  newWidth: The new width of the column in pixels.
        ///  oldWidth: The old width of the column in pixels.
        /// 
        /// 
        /// </summary>
        public event EventHandler WidthChanged;

    }
}
