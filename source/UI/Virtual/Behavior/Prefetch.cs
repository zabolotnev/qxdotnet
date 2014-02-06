using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Behavior
{
    /// <summary>
    /// Behavior to support pre-rendering of invisible areas of a virtual scroller. If applied to a scroller it will start a timer and increase the rendered area of the scroller after a certain period of time. Subsequent scrolling will not have to render this pre-computed area again.  EXPERIMENTAL!
    /// </summary>
    public partial class Prefetch : qxDotNet.Core.Object
    {

        private int _interval = 200;
        private qxDotNet.UI.Virtual.Core.Scroller _scroller = null;


        /// <summary>
        /// Polling interval
        /// </summary>
        public int Interval
        {
            get
            {
                return _interval;
            }
            set
            {
               _interval = value;
            }
        }

        /// <summary>
        /// The scroller to prefetch
        /// </summary>
        public qxDotNet.UI.Virtual.Core.Scroller Scroller
        {
            get
            {
                return _scroller;
            }
            set
            {
               _scroller = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.behavior.Prefetch";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("interval", _interval, 200);
            state.SetPropertyValue("scroller", _scroller, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
