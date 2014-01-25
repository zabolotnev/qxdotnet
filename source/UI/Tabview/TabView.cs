using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tabview
{
    /// <summary>
    /// A tab view is a multi page view where only one page is visible at each moment. It is possible to switch the pages using the buttons rendered by each page.
    /// </summary>
    public partial class TabView : qxDotNet.UI.Core.Widget, qxDotNet.UI.Core.ISingleSelection
    {

        private qxDotNet.BarPositionEnum _barPosition = BarPositionEnum.top;
        private qxDotNet.UI.Tabview.Page _selection = null;
        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;


        /// <summary>
        /// This property defines on which side of the TabView the bar should be positioned.
        /// </summary>
        public qxDotNet.BarPositionEnum BarPosition
        {
            get
            {
                return _barPosition;
            }
            set
            {
               _barPosition = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Tabview.Page Selection
        {
            get
            {
                return _selection;
            }
            set
            {
               _selection = value;
            }
        }

        /// <summary>
        /// Bottom padding of the content pane
        /// </summary>
        public int ContentPaddingBottom
        {
            get
            {
                return _contentPaddingBottom;
            }
            set
            {
               _contentPaddingBottom = value;
            }
        }

        /// <summary>
        /// Left padding of the content pane
        /// </summary>
        public int ContentPaddingLeft
        {
            get
            {
                return _contentPaddingLeft;
            }
            set
            {
               _contentPaddingLeft = value;
            }
        }

        /// <summary>
        /// Right padding of the content pane
        /// </summary>
        public int ContentPaddingRight
        {
            get
            {
                return _contentPaddingRight;
            }
            set
            {
               _contentPaddingRight = value;
            }
        }

        /// <summary>
        /// Top padding of the content pane
        /// </summary>
        public int ContentPaddingTop
        {
            get
            {
                return _contentPaddingTop;
            }
            set
            {
               _contentPaddingTop = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tabview.TabView";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("barPosition", _barPosition, BarPositionEnum.top);
            state.SetPropertyValue("selection", _selection, null);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);

            state.SetEvent("changeSelection", true, "selection");

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeSelection")
            {
                OnChangeSelection();
            }
        }

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fires after the selection was modified
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
