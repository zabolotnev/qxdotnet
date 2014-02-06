using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form.Renderer
{
    /// <summary>
    /// AbstractRenderer is an abstract class used to encapsulate behaviours of how a form can be rendered into a mobile page. Its subclasses can extend it and override {@link #addItems} and {@link #addButton} methods in order to customize the way the form gets into the DOM.
    /// </summary>
    public abstract partial class AbstractRenderer : qxDotNet.UI.Mobile.Core.Widget, qxDotNet.UI.Form.Renderer.IFormRenderer
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.renderer.AbstractRenderer";
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
