using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Embed
{
    /// <summary>
    /// Abstract base class for iframe widgets.
    /// </summary>
    public partial class AbstractIframe : qxDotNet.UI.Core.Widget
    {

        private string _frameName = "";
        private string _source = "about:blank";


        /// <summary>
        /// Name of the iframe.
        /// </summary>
        public string FrameName
        {
            get
            {
                return _frameName;
            }
            set
            {
               _frameName = value;
            }
        }

        /// <summary>
        /// Source URL of the iframe.
        /// </summary>
        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
               _source = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.embed.AbstractIframe";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("frameName", _frameName, "");
            state.SetPropertyValue("source", _source, "about:blank");

            if (Load != null)
            {
                state.SetEvent("load", false);
            }
            if (Navigate != null)
            {
                state.SetEvent("navigate", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "load")
            {
                OnLoad();
            }
            if (eventName == "navigate")
            {
                OnNavigate();
            }
        }

        protected virtual void OnLoad()
        {
            if (Load != null)
            {
                Load.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The "load" event is fired after the iframe content has successfully been loaded.
        /// </summary>
        public event EventHandler Load;

        protected virtual void OnNavigate()
        {
            if (Navigate != null)
            {
                Navigate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The "navigate" event is fired whenever the location of the iframe changes.  Useful to track user navigation and internally used to keep the source property in sync. Only works when the destination source is of same origin than the page embedding the iframe.
        /// </summary>
        public event EventHandler Navigate;

    }
}
