using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A Button widget which supports various states and allows it to be used via the mouse and the keyboard.  If the user presses the button by clicking on it, or the Enter or Space keys, the button fires an {@link qx.ui.core.MExecutable#execute} event.  If the {@link qx.ui.core.MExecutable#command} property is set, the command is executed as well.  Example  Here is a little example of how to use the widget.    var button = new qx.ui.form.Button(\HelloWorld\);   button.addListener(\execute\, function(e) {  alert(\Buttonwasclicked\);  }, this);   this.getRoot.add(button);   This example creates a button with the label "Hello World" and attaches an event listener to the {@link #execute} event.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Button : qxDotNet.UI.Basic.Atom, qxDotNet.UI.Form.IExecutable
    {

        private qxDotNet.UI.Core.Command _command = null;


        /// <summary>
        /// A command called if the {@link #execute} method is called, e.g. on a button click.
        /// </summary>
        public qxDotNet.UI.Core.Command Command
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.Button";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("command", _command, null);

            if (Execute != null)
            {
                state.SetEvent("execute", true);
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

        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the {@link #execute} method is invoked.
        /// </summary>
        public event EventHandler Execute;

    }
}
