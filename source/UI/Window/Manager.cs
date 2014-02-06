using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Window
{
    /// <summary>
    /// The default window manager implementation
    /// </summary>
    public partial class Manager : qxDotNet.Core.Object, qxDotNet.UI.Window.IWindowManager
    {

        private qxDotNet.UI.Window.IDesktop _desktop = null;


        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Window.IDesktop Desktop
        {
            get
            {
                return _desktop;
            }
            set
            {
               _desktop = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.window.Manager";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("desktop", _desktop, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
