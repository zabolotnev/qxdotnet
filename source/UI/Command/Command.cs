using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Command
{
    /// <summary>
    /// Commands can be used to globally define keyboard shortcuts. They could
    /// also be used to assign an execution of a command sequence to multiple
    /// widgets. It is possible to use the same Command in a MenuButton and
    /// ToolBarButton for example.
    /// 
    /// </summary>
    public partial class Command : qxDotNet.Core.Object
    {

        private bool? _active = true;
        private bool? _enabled = true;
        private string _icon = "";
        private string _label = "";
        private qxDotNet.UI.Menu.Menu _menu = null;
        private string _shortcut = "";
        private string _toolTipText = "";
//TODO: private _var _value = null;


        /// <summary>
        /// Whether the command should be activated. If 'false' execute event
        /// wouldn't fire. This proprty will be used by command groups when
        /// activating/deactivating all commands of the group.
        /// 
        /// </summary>
        public bool? Active
        {
            get
            {
                return _active;
            }
            set
            {
               _active = value;
               OnChangeActive();
            }
        }

        /// <summary>
        /// Whether the command should be respected/enabled. If 'false' execute event
        /// wouldn't fire. If value of property {@link qx.ui.command.Command#active}
        /// is 'false', enabled value can be set but has no effect until
        /// {@link qx.ui.command.Command#active} will be set to 'true'.
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// The tooltip text, which will be set in all connected
        /// widgets (if available)
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.command.Command";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("active", _active, true);
            state.SetPropertyValue("enabled", _enabled, true);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("menu", _menu, null);
            state.SetPropertyValue("shortcut", _shortcut, "");
            state.SetPropertyValue("toolTipText", _toolTipText, "");

            if (Execute != null)
            {
                state.SetEvent("execute", true);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

        /// <summary>
        /// Raises event 'ChangeActive'
        /// </summary>
        protected virtual void OnChangeActive()
        {
            if (ChangeActive != null)
            {
                ChangeActive.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #active}.
        /// </summary>
        public event EventHandler ChangeActive;

        /// <summary>
        /// Raises event 'ChangeEnabled'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeIcon'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeLabel'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeMenu'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeToolTipText'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeValue'
        /// </summary>
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

        /// <summary>
        /// Raises event 'Execute'
        /// </summary>
        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the command is executed. Sets the "data" property of the
        /// event to the object that issued the command.
        /// 
        /// </summary>
        public event EventHandler Execute;

    }
}
