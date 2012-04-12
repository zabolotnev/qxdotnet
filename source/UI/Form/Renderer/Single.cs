using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Renderer
{
    /// <summary>
    /// Single column renderer for qx.ui.form.Form.
    /// </summary>
    public partial class Single : qxDotNet.UI.Form.Renderer.AbstractRenderer
    {

        public Single(qxDotNet.UI.Form.Form form) : base(form)
        {
        }


        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.renderer.Single";
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
