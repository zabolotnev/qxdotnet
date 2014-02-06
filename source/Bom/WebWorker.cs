using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom
{
    /// <summary>
    /// EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION  Web Workers allows us to run JavaScript in parallel on a web page, without blocking the user interface. A &#8216;worker' is just another script file that will be loaded and executed in the background.  For more information see: http://www.w3.org/TR/workers/
    /// </summary>
    public partial class WebWorker : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.bom.WebWorker";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Error != null)
            {
                state.SetEvent("error", false);
            }
            if (Message != null)
            {
                state.SetEvent("message", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "error")
            {
                OnError();
            }
            if (eventName == "message")
            {
                OnMessage();
            }
        }

        protected virtual void OnError()
        {
            if (Error != null)
            {
                Error.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when an error occurs
        /// </summary>
        public event EventHandler Error;

        protected virtual void OnMessage()
        {
            if (Message != null)
            {
                Message.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when worker sends a message
        /// </summary>
        public event EventHandler Message;

    }
}
