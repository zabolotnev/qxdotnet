using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Control
{
    /// <summary>
    /// A date chooser is a small calendar including a navigation bar to switch the shown month. It includes a column for the calendar week and shows one month. Selecting a date is as easy as clicking on it.  To be conform with all form widgets, the {@link qx.ui.form.IForm} interface is implemented.  The following example creates and adds a date chooser to the root element. A listener alerts the user if a new date is selected.   var chooser = new qx.ui.control.DateChooser(); this.getRoot().add(chooser, { left : 20, top: 20});  chooser.addListener(\changeValue\, function(e) {  alert(e.getData()); });   Additionally to a selection event an execute event is available which is fired by doubleclick or taping the space / enter key. With this event you can for example save the selection and close the date chooser.
    /// </summary>
    public partial class DateChooser : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IExecutable, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IDateForm
    {

        private int _shownMonth = 0;
        private int _shownYear = 0;
        private DateTime? _value = null;
        private qxDotNet.UI.Core.Command _command = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// The currently shown month. 0 = january, 1 = february, and so on.
        /// </summary>
        public int ShownMonth
        {
            get
            {
                return _shownMonth;
            }
            set
            {
               _shownMonth = value;
               OnChangeShownMonth();
            }
        }

        /// <summary>
        /// The currently shown year.
        /// </summary>
        public int ShownYear
        {
            get
            {
                return _shownYear;
            }
            set
            {
               _shownYear = value;
               OnChangeShownYear();
            }
        }

        /// <summary>
        /// The date value of the widget.
        /// </summary>
        public DateTime? Value
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
        /// Message which is shown in an invalid tooltip.
        /// </summary>
        public string InvalidMessage
        {
            get
            {
                return _invalidMessage;
            }
            set
            {
               _invalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is required.
        /// </summary>
        public bool? Required
        {
            get
            {
                return _required;
            }
            set
            {
               _required = value;
               OnChangeRequired();
            }
        }

        /// <summary>
        /// Message which is shown in an invalid tooltip if the {@link #required} is set to true.
        /// </summary>
        public string RequiredInvalidMessage
        {
            get
            {
                return _requiredInvalidMessage;
            }
            set
            {
               _requiredInvalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid state will be set.
        /// </summary>
        public bool? Valid
        {
            get
            {
                return _valid;
            }
            set
            {
               _valid = value;
               OnChangeValid();
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.control.DateChooser";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("shownMonth", _shownMonth, 0);
            state.SetPropertyValue("shownYear", _shownYear, 0);
            state.SetPropertyValue("value", _value, null);
            state.SetPropertyValue("command", _command, null);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

            state.SetEvent("execute", false, "value");

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

        protected virtual void OnChangeShownMonth()
        {
            if (ChangeShownMonth != null)
            {
                ChangeShownMonth.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #shownMonth}.
        /// </summary>
        public event EventHandler ChangeShownMonth;

        protected virtual void OnChangeShownYear()
        {
            if (ChangeShownYear != null)
            {
                ChangeShownYear.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #shownYear}.
        /// </summary>
        public event EventHandler ChangeShownYear;

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

        protected virtual void OnChangeInvalidMessage()
        {
            if (ChangeInvalidMessage != null)
            {
                ChangeInvalidMessage.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #invalidMessage}.
        /// </summary>
        public event EventHandler ChangeInvalidMessage;

        protected virtual void OnChangeRequired()
        {
            if (ChangeRequired != null)
            {
                ChangeRequired.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #required}.
        /// </summary>
        public event EventHandler ChangeRequired;

        protected virtual void OnChangeValid()
        {
            if (ChangeValid != null)
            {
                ChangeValid.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #valid}.
        /// </summary>
        public event EventHandler ChangeValid;

    }
}
