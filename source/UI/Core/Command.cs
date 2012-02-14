using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// Commands can be used to globally define keyboard shortcuts. They could also be used to assign an execution of a command sequence to multiple widgets. It is possible to use the same Command in a MenuButton and ToolBarButton for example.
    /// </summary>
    public partial class Command : qxDotNet.Core.Object
    {

        private bool? _enabled = true;
        private string _icon = "";
        private string _label = "";
        private qxDotNet.UI.Menu.Menu _menu = null;
        private string _shortcut = "";
        private string _toolTipText = "";
//        private _var _value = null;


        /// <summary>
        /// whether the command should be respected/enabled
        /// </summary>
        public bool? Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
               _enabled = value;
               OnChangeEnabled();
            }
        }

        /// <summary>
        /// The icon, which will be set in all connected widgets (if available)
        /// </summary>
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
               _icon = value;
               OnChangeIcon();
            }
        }

        /// <summary>
        /// The label, which will be set in all connected widgets (if available)
        /// </summary>
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
               _label = value;
               OnChangeLabel();
            }
        }

        /// <summary>
        /// The menu, which will be set in all connected widgets (if available)
        /// </summary>
        public qxDotNet.UI.Menu.Menu Menu
        {
            get
            {
                return _menu;
            }
            set
            {
               _menu = value;
               OnChangeMenu();
            }
        }

        /// <summary>
        /// The command shortcut as a string
        /// </summary>
        public string Shortcut
        {
            get
            {
                return _shortcut;
            }
            set
            {
               _shortcut = value;
            }
        }

        /// <summary>
        /// The tooltip text, which will be set in all connected widgets (if available)
        /// </summary>
        public string ToolTipText
        {
            get
            {
                return _toolTipText;
            }
            set
            {
               _toolTipText = value;
               OnChangeToolTipText();
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.core.Command";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("enabled", _enabled, true);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("menu", _menu, null);
            state.SetPropertyValue("shortcut", _shortcut, "");
            state.SetPropertyValue("toolTipText", _toolTipText, "");

            if (Execute != null)
            {
                state.SetEvent("execute", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

        protected virtual void OnChangeEnabled()
        {
            if (ChangeEnabled != null)
            {
                ChangeEnabled.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #enabled}.
        /// </summary>
        public event EventHandler ChangeEnabled;

        protected virtual void OnChangeIcon()
        {
            if (ChangeIcon != null)
            {
                ChangeIcon.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #icon}.
        /// </summary>
        public event EventHandler ChangeIcon;

        protected virtual void OnChangeLabel()
        {
            if (ChangeLabel != null)
            {
                ChangeLabel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #label}.
        /// </summary>
        public event EventHandler ChangeLabel;

        protected virtual void OnChangeMenu()
        {
            if (ChangeMenu != null)
            {
                ChangeMenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #menu}.
        /// </summary>
        public event EventHandler ChangeMenu;

        protected virtual void OnChangeToolTipText()
        {
            if (ChangeToolTipText != null)
            {
                ChangeToolTipText.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #toolTipText}.
        /// </summary>
        public event EventHandler ChangeToolTipText;

        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #value}.
        /// </summary>
        public event EventHandler ChangeValue;

        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the command is executed. Sets the &#8220;data&#8221; property of the event to the object that issued the command.
        /// </summary>
        public event EventHandler Execute;

    }
}
