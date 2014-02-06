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

        private decimal _scrollX = 0m;
        private decimal _scrollY = 0m;


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

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.scroll.ScrollPane";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scrollX", _scrollX, 0m);
            state.SetPropertyValue("scrollY", _scrollY, 0m);

            state.SetEvent("scrollAnimationEnd", false);
            if (ScrollX != null)
            {
                state.SetEvent("scrollX", false, "scrollX");
            }
            if (ScrollY != null)
            {
                state.SetEvent("scrollY", false, "scrollY");
            }
            state.SetEvent("update", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "scrollAnimationEnd")
            {
                OnScrollAnimationEnd();
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

        protected virtual void OnScrollAnimationEnd()
        {
            if (ScrollAnimationEnd != null)
            {
                ScrollAnimationEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on scroll animation end invoked by "scroll*"; methods.
        /// </summary>
        public event EventHandler ScrollAnimationEnd;

        protected virtual void OnScrollX()
        {
            if (ScrollXElapsed != null)
            {
                ScrollXElapsed.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #scrollX}.
        /// </summary>
        public event EventHandler ScrollXElapsed;

        protected virtual void OnScrollY()
        {
            if (ScrollYElapsed != null)
            {
                ScrollYElapsed.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #scrollY}.
        /// </summary>
        public event EventHandler ScrollYElapsed;

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
