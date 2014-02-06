using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Root
{
    /// <summary>
    /// Shared implementation for all root widgets.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.UI.Core.Widget
    {

        private string _globalCursor = "";
        private bool? _nativeHelp = false;
        private string _blockerColor = null;
        private decimal _blockerOpacity = 1;
        private qxDotNet.UI.Window.Window _activeWindow = null;
        private qxDotNet.UI.Window.IWindowManager _windowManager = null;


        /// <summary>
        /// Sets the global cursor style  The name of the cursor to show when the mouse pointer is over the widget.  This is any valid CSS2 cursor name defined by W3C.  The following values are possible:  default  crosshair  pointer (hand is the ie name and will mapped to pointer in non-ie).  move  n-resize  ne-resize  e-resize  se-resize  s-resize  sw-resize  w-resize  nw-resize  text  wait  help   url([file]) = self defined cursor, file should be an ANI- or CUR-type    Please note that in the current implementation this has no effect in IE.
        /// </summary>
        public string GlobalCursor
        {
            get
            {
                return _globalCursor;
            }
            set
            {
               _globalCursor = value;
               OnChangeGlobalCursor();
            }
        }

        /// <summary>
        /// If the user presses F1 in IE by default the onhelp event is fired and IE";s help window is opened. Setting this property to false prevents this behavior.
        /// </summary>
        public bool? NativeHelp
        {
            get
            {
                return _nativeHelp;
            }
            set
            {
               _nativeHelp = value;
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


        protected internal override string GetTypeName()
        {
            return "qx.ui.root.Abstract";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("globalCursor", _globalCursor, "");
            state.SetPropertyValue("nativeHelp", _nativeHelp, false);
            state.SetPropertyValue("blockerColor", _blockerColor, null);
            state.SetPropertyValue("blockerOpacity", _blockerOpacity, 1);
            state.SetPropertyValue("activeWindow", _activeWindow, null);
            state.SetPropertyValue("windowManager", _windowManager, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeGlobalCursor()
        {
            if (ChangeGlobalCursor != null)
            {
                ChangeGlobalCursor.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #globalCursor}.
        /// </summary>
        public event EventHandler ChangeGlobalCursor;

    }
}
