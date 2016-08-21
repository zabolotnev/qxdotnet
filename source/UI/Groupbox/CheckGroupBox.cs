using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Groupbox
{
    /// <summary>
    /// A group box, which has a check box near the legend.
    /// 
    /// </summary>
    public partial class CheckGroupBox : qxDotNet.UI.Groupbox.GroupBox, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IModel
    {

//TODO: private _var _command = null;
        private bool? _value = false;
//TODO: private _var _model = null;


        /// <summary>
        /// The value of the groupbox.
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
            return "qx.ui.groupbox.CheckGroupBox";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("value", _value, false);

            state.SetPropertyValue("command", _command, null);

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
        /// Fired when the included checkbox changed its value
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
