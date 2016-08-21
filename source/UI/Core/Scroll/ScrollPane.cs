using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Scroll
{
    /// <summary>
    /// This class represents a scroll able pane. This means that this widget
    /// may contain content which is bigger than the available (inner)
    /// dimensions of this widget. The widget also offer methods to control
    /// the scrolling position. It can only have exactly one child.
    /// 
    /// </summary>
    public partial class ScrollPane : qxDotNet.UI.Core.Widget
    {

        private decimal _scrollX = 0m;
        private decimal _scrollY = 0m;


        /// <summary>
        /// The horizontal scroll position
        /// 
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
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.scroll.ScrollPane";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scrollX", _scrollX, 0m);
            state.SetPropertyValue("scrollY", _scrollY, 0m);

            if (ScrollAnimationEnd != null)
            {
                state.SetEvent("scrollAnimationEnd", false);
            }
            if (Update != null)
            {
                state.SetEvent("update", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "scrollAnimationEnd")
            {
                OnScrollAnimationEnd();
            }
            if (eventName == "update")
            {
                OnUpdate();
            }
        }

        /// <summary>
        /// Raises event 'ScrollAnimationEnd'
        /// </summary>
        protected virtual void OnScrollAnimationEnd()
        {
            if (ScrollAnimationEnd != null)
            {
                ScrollAnimationEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on scroll animation end invoked by 'scroll*' methods.
        /// 
        /// </summary>
        public event EventHandler ScrollAnimationEnd;

        
        /// <summary>
        /// Raises event 'Update'
        /// </summary>
        protected virtual void OnUpdate()
        {
            if (Update != null)
            {
                Update.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on resize of both the container or the content.
        /// 
        /// </summary>
        public event EventHandler Update;

    }
}
