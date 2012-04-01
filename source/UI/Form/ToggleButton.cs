using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A toggle Button widget  If the user presses the button by clicking on it pressing the enter or space key, the button toggles between the pressed an not pressed states. There is no execute event, only a {@link qx.ui.form.ToggleButton#changeValue} event.
    /// </summary>
    public partial class ToggleButton : qxDotNet.UI.Basic.Atom, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IExecutable, qxDotNet.UI.Form.IRadioItem
    {

        private qxDotNet.UI.Form.RadioGroup _group = null;
        private bool? _triState = null;
        private bool? _value = false;
        private qxDotNet.UI.Core.Command _command = null;


        /// <summary>
        /// The assigned qx.ui.form.RadioGroup which handles the switching between registered buttons.
        /// </summary>
        public qxDotNet.UI.Form.RadioGroup Group
        {
            get
            {
                return _group;
            }
            set
            {
               _group = value;
            }
        }

        /// <summary>
        /// Whether the button has a third state. Use this for tri-state checkboxes.  When enabled, the value null of the property value stands for &#8220;undetermined&#8221;, while true is mapped to &#8220;enabled&#8221; and false to &#8220;disabled&#8221; as usual. Note that the value property is set to false initially.
        /// </summary>
        public bool? TriState
        {
            get
            {
                return _triState;
            }
            set
            {
               _triState = value;
            }
        }

        /// <summary>
        /// The value of the widget. True, if the widget is checked.
        /// </summary>
        public bool? Value
        {
            get
            {
                return _value;
            }
            set
            {
               _value = value;
               OnChangeValue();
            }
        }

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
            return "qx.ui.form.ToggleButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("group", _group, null);
            state.SetPropertyValue("triState", _triState, null);
            state.SetPropertyValue("value", _value, false);
            state.SetPropertyValue("command", _command, null);

            if (Execute != null)
            {
                state.SetEvent("execute", false);
            }

            state.SetEvent("execute", true, "value");

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

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
