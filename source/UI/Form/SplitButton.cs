using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A button which acts as a normal button and shows a menu on one
    /// of the sides to open something like a history list.
    /// 
    /// </summary>
    public partial class SplitButton : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IExecutable
    {

        private string _icon = "";
        private string _label = "";
        private qxDotNet.UI.Menu.Menu _menu = null;
        private qxDotNet.ShowEnum _show = ShowEnum.both;
        private qxDotNet.UI.Command.Command _command = null;


        /// <summary>
        /// Any URI String supported by qx.ui.basic.Image to display an icon
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
            }
        }

        /// <summary>
        /// The label/caption/text of the qx.ui.basic.Atom instance
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
            }
        }

        /// <summary>
        /// The menu instance to show when tapping on the button
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
        /// Configure the visibility of the sub elements/widgets.
        /// Possible values: both, text, icon
        /// 
        /// </summary>
        public qxDotNet.ShowEnum Show
        {
            get
            {
                return _show;
            }
            set
            {
               _show = value;
               OnChangeShow();
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
            return "qx.ui.form.SplitButton";
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
            state.SetPropertyValue("show", _show, ShowEnum.both);
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
        /// Raises event 'ChangeShow'
        /// </summary>
        protected virtual void OnChangeShow()
        {
            if (ChangeShow != null)
            {
                ChangeShow.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #show}.
        /// </summary>
        public event EventHandler ChangeShow;

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
