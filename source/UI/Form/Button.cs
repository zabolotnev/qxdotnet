using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A Button widget which supports various states and allows it to be used
    /// via the mouse, touch, pen and the keyboard.
    /// 
    /// If the user presses the button by clicking on it, or the Enter or
    /// Space keys, the button fires an {@link qx.ui.core.MExecutable#execute} event.
    /// 
    /// If the {@link qx.ui.core.MExecutable#command} property is set, the
    /// command is executed as well.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  var button = new qx.ui.form.Button("Hello World");
    /// 
    ///  button.addListener("execute", function(e) {
    ///  alert("Button was clicked");
    ///  }, this);
    /// 
    ///  this.getRoot().add(button);
    /// 
    /// 
    /// This example creates a button with the label "Hello World" and attaches an
    /// event listener to the {@link #execute} event.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Button : qxDotNet.UI.Basic.Atom, qxDotNet.UI.Form.IExecutable
    {

        private qxDotNet.UI.Command.Command _command = null;


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
            return "qx.ui.form.Button";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
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
