using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The Radio button for mobile.  Example    var form = new qx.ui.mobile.form.Form();   var radio1 = new qx.ui.mobile.form.RadioButton();  var radio2 = new qx.ui.mobile.form.RadioButton();  var radio3 = new qx.ui.mobile.form.RadioButton();   var group = new qx.ui.mobile.form.RadioGroup(radio1, radio2, radio3);   form.add(radio1, \Germany\);  form.add(radio2, \UK\);  form.add(radio3, \USA\);   this.getRoot.add(new qx.ui.mobile.form.renderer.Single(form)); 
    /// </summary>
    public partial class RadioButton : qxDotNet.UI.Mobile.Form.Input
    {

        private qxDotNet.UI.Mobile.Form.RadioGroup _group = null;
        private bool? _liveUpdate = false;
//        private _var _value = null;


        /// <summary>
        /// The assigned qx.ui.form.RadioGroup which handles the switching between registered buttons
        /// </summary>
        public qxDotNet.UI.Mobile.Form.RadioGroup Group
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
        /// Whether the {@link #changeValue} event should be fired on every key input. If set to true, the changeValue event is equal to the {@link #input} event.
        /// </summary>
        public bool? LiveUpdate
        {
            get
            {
                return _liveUpdate;
            }
            set
            {
               _liveUpdate = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.RadioButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("group", _group, null);
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }
            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }
            if (Input != null)
            {
                state.SetEvent("input", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeValue")
            {
                OnChangeValue();
            }
            if (eventName == "input")
            {
                OnInput();
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
        /// The event is fired each time the text field looses focus and the text field values has changed.  If you change {@link #liveUpdate} to true, the changeValue event will be fired after every keystroke and not only after every focus loss. In that mode, the changeValue event is equal to the {@link #input} event.  The method {@link qx.event.type.Data#getData} returns the current text value of the field.
        /// </summary>
        public event EventHandler ChangeValue;

        protected virtual void OnInput()
        {
            if (Input != null)
            {
                Input.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired on every keystroke modifying the value of the field.  The method {@link qx.event.type.Data#getData} returns the current value of the text field.
        /// </summary>
        public event EventHandler Input;

    }
}
