using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Core
{
    /// <summary>
    /// EXPERIMENTAL!  The Pane provides a window of a larger virtual grid.  The actual rendering is performed by one or several layers ({@link ILayer}. The pane computes, which cells of the virtual area is visible and instructs the layers to render these cells.
    /// </summary>
    public partial class Pane : qxDotNet.UI.Core.Widget
    {

        private int _scrollX = 0;
        private int _scrollY = 0;


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


        public override string GetTypeName()
        {
            return "qx.ui.virtual.core.Pane";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scrollX", _scrollX, 0);
            state.SetPropertyValue("scrollY", _scrollY, 0);

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
            if (DoScrollX != null)
            {
                state.SetEvent("scrollX", false);
            }
            if (DoScrollY != null)
            {
                state.SetEvent("scrollY", false);
            }
            if (Update != null)
            {
                state.SetEvent("update", false);
            }

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
            if (eventName == "scrollX")
            {
                OnScrollX();
            }
            if (eventName == "scrollY")
            {
                OnScrollY();
            }
            if (eventName == "update")
            {
                OnUpdate();
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
        /// Fired if a cell is clicked.
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
        /// Fired if a cell is right-clicked.
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
        /// Fired if a cell is double-clicked.
        /// </summary>
        public event EventHandler CellDblclick;

        protected virtual void OnScrollX()
        {
            if (DoScrollX != null)
            {
                DoScrollX.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the pane is scrolled horizontally.
        /// </summary>
        public event EventHandler DoScrollX;

        protected virtual void OnScrollY()
        {
            if (DoScrollY != null)
            {
                DoScrollY.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the pane is scrolled vertically.
        /// </summary>
        public event EventHandler DoScrollY;

        protected virtual void OnUpdate()
        {
            if (Update != null)
            {
                Update.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on resize of either the container or the (virtual) content.
        /// </summary>
        public event EventHandler Update;

    }
}
