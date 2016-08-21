using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Menu
{
    /// <summary>
    /// The abstract menu button class is used for all type of menu content
    /// for example normal buttons, checkboxes or radiobuttons.
    /// 
    /// </summary>
    public abstract partial class AbstractButton : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IExecutable
    {

        private string _icon = "";
        private string _label = "";
        private qxDotNet.UI.Menu.Menu _menu = null;
        private bool? _showCommandLabel = true;
        private qxDotNet.UI.Command.Command _command = null;


        /// <summary>
        /// The icon to use
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
        /// The label text of the button
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
        /// Whether a sub menu should be shown and which one
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
        /// Indicates whether the label for the command (shortcut) should be visible or not.
        /// 
        /// </summary>
        public bool? ShowCommandLabel
        {
            get
            {
                return _showCommandLabel;
            }
            set
            {
               _showCommandLabel = value;
               OnChangeShowCommandLabel();
            }
        }

        /// <summary>
        /// A command called if the {@link #execute} method is called, e.g. on a
        /// button tap.
        /// 
        /// </summary>
        public qxDotNet.UI.Command.Command Command
        {
            get
            {
                return _command;
            }
            set
            {
               _command = value;
               OnChangeCommand();
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.menu.AbstractButton";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("menu", _menu, null);
            state.SetPropertyValue("showCommandLabel", _showCommandLabel, true);
            state.SetPropertyValue("command", _command, null);

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
        /// Raises event 'ChangeShowCommandLabel'
        /// </summary>
        protected virtual void OnChangeShowCommandLabel()
        {
            if (ChangeShowCommandLabel != null)
            {
                ChangeShowCommandLabel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #showCommandLabel}.
        /// </summary>
        public event EventHandler ChangeShowCommandLabel;

        /// <summary>
        /// Raises event 'ChangeCommand'
        /// </summary>
        protected virtual void OnChangeCommand()
        {
            if (ChangeCommand != null)
            {
                ChangeCommand.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #command}.
        /// </summary>
        public event EventHandler ChangeCommand;

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
        /// Fired if the {@link #execute} method is invoked.
        /// 
        /// </summary>
        public event EventHandler Execute;

    }
}
