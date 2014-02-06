using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form.Renderer
{
    /// <summary>
    /// Single renderer is a class used to render forms into a mobile page. It displays a label above or next to each form element.
    /// </summary>
    public partial class Single : qxDotNet.UI.Mobile.Form.Renderer.AbstractRenderer
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.renderer.Single";
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
