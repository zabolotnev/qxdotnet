using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Scroll
{
    /// <summary>
    /// This class represents a scroll able pane. This means that this widget may contain content which is bigger than the available (inner) dimensions of this widget. The widget also offer methods to control the scrolling position. It can only have exactly one child.
    /// </summary>
    public partial class ScrollPane : qxDotNet.UI.Core.Widget
    {

        private decimal _scrollX = 0;
        private decimal _scrollY = 0;


        /// <summary>
        /// The horizontal scroll position
        /// </summary>
        public decimal ScrollX
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
        /// The vertical scroll position
        /// </summary>
        public decimal ScrollY
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
            return "qx.ui.core.scroll.ScrollPane";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scrollX", _scrollX, 0);
            state.SetPropertyValue("scrollY", _scrollY, 0);

            if (DoScrollX != null)
            {
                state.SetEvent("scrollX", false, "scrollX");
            }
            if (DoScrollY != null)
            {
                state.SetEvent("scrollY", false, "scrollY");
            }
            if (Update != null)
            {
                state.SetEvent("update", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
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

        protected virtual void OnScrollX()
        {
            if (DoScrollX != null)
            {
                DoScrollX.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #scrollX}.
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
        /// Fired on change of the property {@link #scrollY}.
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
        /// Fired on resize of both the container or the content.
        /// </summary>
        public event EventHandler Update;

    }
}
