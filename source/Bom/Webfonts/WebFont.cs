using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Webfonts
{
    /// <summary>
    /// Requests web fonts from {@link qx.bom.webfonts.Manager} and fires events when their loading status is known.
    /// </summary>
    public partial class WebFont : qxDotNet.Bom.Font
    {

//        private _var _sources = null;



        protected internal override string GetTypeName()
        {
            return "qx.bom.webfonts.WebFont";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

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
