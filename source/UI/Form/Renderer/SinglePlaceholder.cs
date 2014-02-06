using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Renderer
{
    /// <summary>
    /// Rendere using the placeholder property of {@link qx.ui.form.AbstractField} to visualize the name.
    /// </summary>
    public partial class SinglePlaceholder : qxDotNet.UI.Form.Renderer.Single, qxDotNet.UI.Form.Renderer.IFormRenderer
    {

        public SinglePlaceholder(qxDotNet.UI.Form.Form form)
            : base(form)
        {
        }


        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.renderer.SinglePlaceholder";
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
