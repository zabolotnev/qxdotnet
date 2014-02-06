using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// Representation of a form. A form widget can contain one or more {@link Row} widgets.  Example  Here is an example of how to use the widget.    var title = new qx.ui.mobile.form.Title(\Group\);  var form = new qx.ui.mobile.form.Form();  form.add(new qx.ui.mobile.form.TextField(), \Username:\);   this.getRoot().add(title);  this.getRoot().add(new qx.ui.mobile.form.renderer.Single(form));   This example creates a form and adds a row with a text field in it.
    /// </summary>
    public partial class Form : qxDotNet.UI.Form.Form
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.Form";
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
