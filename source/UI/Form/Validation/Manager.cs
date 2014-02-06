using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Validation
{
    /// <summary>
    /// This validation manager is responsible for validation of forms.
    /// </summary>
    public partial class Manager : qxDotNet.Core.Object
    {

//        private _var _context = null;
        private string _invalidMessage = "";
        private string _requiredFieldMessage = "";
//        private _var _validator = null;


        /// <summary>
        /// The invalid message should store the message why the form validation failed. It will be added to the array returned by {@link #getInvalidMessages}.
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
            }
        }

        /// <summary>
        /// This message will be shown if a required field is empty and no individual {@link qx.ui.form.MForm#requiredInvalidMessage} is given.
        /// </summary>
        public string RequiredFieldMessage
        {
            get
            {
                return _requiredFieldMessage;
            }
            set
            {
               _requiredFieldMessage = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.form.validation.Manager";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("requiredFieldMessage", _requiredFieldMessage, "");

            if (ChangeValid != null)
            {
                state.SetEvent("changeValid", false);
            }
            if (Complete != null)
            {
                state.SetEvent("complete", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeValid")
            {
                OnChangeValid();
            }
            if (eventName == "complete")
            {
                OnComplete();
            }
        }

        protected virtual void OnChangeValid()
        {
            if (ChangeValid != null)
            {
                ChangeValid.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Change event for the valid state.
        /// </summary>
        public event EventHandler ChangeValid;

        protected virtual void OnComplete()
        {
            if (Complete != null)
            {
                Complete.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Signals that the validation is done. This is not needed on synchronous validation (validation is done right after the call) but very important in the case an asynchronous validator will be used.
        /// </summary>
        public event EventHandler Complete;

    }
}
