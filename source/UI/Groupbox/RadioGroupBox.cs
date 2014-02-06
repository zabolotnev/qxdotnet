using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Groupbox
{
    /// <summary>
    /// A group box, which has a radio button near the legend.
    /// </summary>
    public partial class RadioGroupBox : qxDotNet.UI.Groupbox.GroupBox, qxDotNet.UI.Form.IRadioItem, qxDotNet.UI.Form.IExecutable, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IModel
    {

//        private _var _command = null;
        private qxDotNet.UI.Form.RadioGroup _group = null;
        private bool? _value = false;
//        private _var _model = null;


        /// <summary>
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.groupbox.RadioGroupBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("group", _group, null);
            state.SetPropertyValue("value", _value, false);

            state.SetEvent("changeValue", false, "value");
            state.SetEvent("execute", true);

        }

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

        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the included radiobutton changed its value
        /// </summary>
        public event EventHandler ChangeValue;

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
