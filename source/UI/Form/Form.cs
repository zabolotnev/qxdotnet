using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The form object is responsible for managing form items. For that, it takes advantage of two existing qooxdoo classes. The {@link qx.ui.form.Resetter} is used for resetting and the {@link qx.ui.form.validation.Manager} is used for all validation purposes.  The view code can be found in the used renderer ({@link qx.ui.form.renderer}).
    /// </summary>
    public partial class Form : qxDotNet.Core.Object
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.Form";
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
