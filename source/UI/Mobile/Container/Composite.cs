using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// The Composite is a generic container widget.  It exposes all methods to set layouts and to manage child widgets as public methods. You must configure this widget with a layout manager to define the way the widget's children are positioned.  Example  Here is a little example of how to use the widget.    // create the composite  var composite = new qx.ui.mobile.container.Composite();   composite.setLayout(new qx.ui.mobile.layout.HBox());   // add some children  composite.add(new qx.ui.mobile.basic.Label(\Name:\), {flex:1});  composite.add(new qx.ui.mobile.form.TextField());   this.getRoot().add(composite);   This example horizontally groups a label and text field by using a Composite configured with a horizontal box layout as a container.
    /// </summary>
    public partial class Composite : qxDotNet.UI.Mobile.Core.Widget
    {

        private qxDotNet.UI.Mobile.Layout.Abstract _layout = null;


        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Mobile.Layout.Abstract Layout
        {
            get
            {
                return _layout;
            }
            set
            {
               _layout = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.Composite";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("layout", _layout, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
