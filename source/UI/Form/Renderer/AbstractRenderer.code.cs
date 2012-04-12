using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Renderer
{

    public abstract partial class AbstractRenderer : qxDotNet.UI.Core.Widget
    {

        private qxDotNet.UI.Form.Form _form;

        public AbstractRenderer(qxDotNet.UI.Form.Form form)
        {
            _form = form;
        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            yield return _form;
        }

        protected internal override string GetCustomConstructor()
        {
            return _form.GetReference();
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            if (isRefreshRequest || _form.ContentChanged)
            {
                response.Write(GetReference() + " = new qx.ui.form.renderer.Single(" + _form.GetReference() + ");");
            }
        }
    }
}
