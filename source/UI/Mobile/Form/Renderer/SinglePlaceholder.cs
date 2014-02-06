using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form.Renderer
{
    /// <summary>
    /// SinglePlaceholder is a class used to render forms into a mobile page. It presents a label into the placeholder of the form elements
    /// </summary>
    public partial class SinglePlaceholder : qxDotNet.UI.Mobile.Form.Renderer.Single
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.renderer.SinglePlaceholder";
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
