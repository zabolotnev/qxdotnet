using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Menu
{
    /// <summary>
    /// Renders a special checkbox button inside a menu. The button behaves like
    /// a normal {@link qx.ui.form.CheckBox} and shows a check icon when
    /// checked; normally shows no icon when not checked (depends on the theme).
    /// 
    /// </summary>
    public partial class CheckBox : qxDotNet.UI.Menu.AbstractButton, qxDotNet.UI.Form.IBooleanForm
    {

        private bool? _value = false;


        /// <summary>
        /// Whether the button is checked
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.menu.CheckBox";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("value", _value, false);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

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

    }
}
