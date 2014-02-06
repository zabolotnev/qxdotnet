using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Validation
{
    /// <summary>
    /// This class is responsible for validation in all asynchronous cases and should always be used with {@link qx.ui.form.validation.Manager}.  It acts like a wrapper for asynchronous validation functions. These validation function must be set in the constructor. The form manager will invoke the validation and the validator function will be called with two arguments:   asyncValidator: A reference to the corresponding validator.  value: The value of the assigned input field.  These two parameters are needed to set the validation status of the current validator. {@link #setValid} is responsible for doing that.  Warning: Instances of this class can only be used with one input field at a time. Multi usage is not supported!  Warning: Calling {@link #setValid} synchronously does not work. If you have an synchronous validator, please check {@link qx.ui.form.validation.Manager#add}. If you have both cases, you have to wrap the synchronous call in a timeout to make it asychronous.
    /// </summary>
    public partial class AsyncValidator : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.form.validation.AsyncValidator";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
