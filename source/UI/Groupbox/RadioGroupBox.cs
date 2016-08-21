using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Groupbox
{
    /// <summary>
    /// A group box, which has a radio button near the legend.
    /// 
    /// </summary>
    public partial class RadioGroupBox : qxDotNet.UI.Groupbox.GroupBox, qxDotNet.UI.Form.IRadioItem, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IModel
    {

//TODO: private _var _command = null;
        private qxDotNet.UI.Form.RadioGroup _group = null;
        private bool? _value = false;
//TODO: private _var _model = null;


        /// <summary>
        /// Returns the radio group
        /// 
        /// Sets the radio group to use
        /// 
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
        /// The value of the groupbox
        /// 
        /// Configures the value of the groupbox.
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
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.groupbox.RadioGroupBox";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("group", _group, null);
            state.SetPropertyValue("value", _value, false);

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }
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
            if (eventName == "changeValue")
            {
                OnChangeValue();
            }
            if (eventName == "execute")
            {
                OnExecute();
            }
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
        /// Fired when the included radiobutton changed its value
        /// 
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
        /// Fired if the {@link #execute} method is invoked.
        /// 
        /// </summary>
        public event EventHandler Execute;

        /// <summary>
        /// Raises event 'ChangeModel'
        /// </summary>
        protected virtual void OnChangeModel()
        {
            if (ChangeModel != null)
            {
                ChangeModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #model}.
        /// </summary>
        public event EventHandler ChangeModel;

    }
}
