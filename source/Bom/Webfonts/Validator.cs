using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Webfonts
{
    /// <summary>
    /// Checks whether a given font is available on the document and fires events accordingly.
    /// </summary>
    public partial class Validator : qxDotNet.Core.Object
    {

//        private _var _fontFamily = null;
        private int _timeout = 5000;


        /// <summary>
        /// Time in milliseconds from the beginning of the check until it is assumed that a font is not available
        /// </summary>
        public int Timeout
        {
            get
            {
                return _timeout;
            }
            set
            {
               _timeout = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.webfonts.Validator";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("timeout", _timeout, 5000);

            if (ChangeStatus != null)
            {
                state.SetEvent("changeStatus", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeStatus")
            {
                OnChangeStatus();
            }
        }

        protected virtual void OnChangeStatus()
        {
            if (ChangeStatus != null)
            {
                ChangeStatus.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the status of a web font has been determined. The event data is a map with the keys "family" (the font-family name) and "valid" (Boolean).
        /// </summary>
        public event EventHandler ChangeStatus;

    }
}
