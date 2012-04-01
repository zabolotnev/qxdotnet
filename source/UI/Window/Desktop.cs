using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Window
{
    /// <summary>
    /// The desktop is a widget, which can act as container for windows. It can be used to define a clipping region for internal windows e.g. to create an MDI like application.
    /// </summary>
    public partial class Desktop : qxDotNet.UI.Core.Widget, qxDotNet.UI.Window.IDesktop
    {

        private qxDotNet.UI.Window.Window _activeWindow = null;
        private qxDotNet.UI.Window.IWindowManager _windowManager = null;
        private string _blockerColor = null;
        private decimal _blockerOpacity = 1m;


        /// <summary>
        /// The currently active window
        /// </summary>
        public qxDotNet.UI.Window.Window ActiveWindow
        {
            get
            {
                return _activeWindow;
            }
            set
            {
               _activeWindow = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Window.IWindowManager WindowManager
        {
            get
            {
                return _windowManager;
            }
            set
            {
               _windowManager = value;
            }
        }

        /// <summary>
        /// Color of the blocker
        /// </summary>
        public string BlockerColor
        {
            get
            {
                return _blockerColor;
            }
            set
            {
               _blockerColor = value;
            }
        }

        /// <summary>
        /// Opacity of the blocker
        /// </summary>
        public decimal BlockerOpacity
        {
            get
            {
                return _blockerOpacity;
            }
            set
            {
               _blockerOpacity = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.window.Desktop";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("activeWindow", _activeWindow, null);
            state.SetPropertyValue("windowManager", _windowManager, null);
            state.SetPropertyValue("blockerColor", _blockerColor, null);
            state.SetPropertyValue("blockerOpacity", _blockerOpacity, 1m);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
