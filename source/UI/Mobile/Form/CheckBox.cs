using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The Checkbox is the mobile correspondent of the html checkbox.  Example    var checkBox = new qx.ui.mobile.form.CheckBox();  var title = new qx.ui.mobile.form.Title(\Title\);   checkBox.setModel(\TitleActivated\);  checkBox.bind(\model\, title, \value\);   checkBox.addListener(\changeValue\, function(evt){  this.setModel(evt.getdata() ? \TitleActivated\ : \TitleDeactivated\);  });   this.getRoot.add(checkBox);  this.getRoot.add(title);   This example adds 2 widgets , a checkBox and a Title and binds them together by their model and value properties. When the user taps on the checkbox, its model changes and it is reflected in the Title's value.
    /// </summary>
    public partial class CheckBox : qxDotNet.UI.Mobile.Form.Input
    {

        private bool? _liveUpdate = false;
//        private _var _value = null;


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
            return "qx.ui.mobile.form.CheckBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);

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
