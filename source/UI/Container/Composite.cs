using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Container
{
    /// <summary>
    /// The Composite is a generic container widget.  It exposes all methods to set layouts and to manage child widgets as public methods. You must configure this widget with a layout manager to define the way the widget&#8217;s children are positioned.  Example  Here is a little example of how to use the widget.    // create the composite  var composite = new qx.ui.container.Composite()   // configure it with a horizontal box layout with a spacing of '5'  composite.setLayout(new qx.ui.layout.HBox(5));   // add some children  composite.add(new qx.ui.basic.Label(\Name:\));  composite.add(new qx.ui.form.TextField());   this.getRoot().add(composite);   This example horizontally groups a label and text field by using a Composite configured with a horizontal box layout as a container.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Composite : qxDotNet.UI.Core.Widget
    {

        private qxDotNet.UI.Layout.Abstract _layout = null;


        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Layout.Abstract Layout
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


        public override string GetTypeName()
        {
            return "qx.ui.container.Composite";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("layout", _layout, null);

            if (AddChildWidget != null)
            {
                state.SetEvent("addChildWidget", false);
            }
            if (RemoveChildWidget != null)
            {
                state.SetEvent("removeChildWidget", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "addChildWidget")
            {
                OnAddChildWidget();
            }
            if (eventName == "removeChildWidget")
            {
                OnRemoveChildWidget();
            }
        }

        protected virtual void OnAddChildWidget()
        {
            if (AddChildWidget != null)
            {
                AddChildWidget.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after a child widget was added to this widget. The {@link qx.event.type.Data#getData} method of the event returns the added child.
        /// </summary>
        public event EventHandler AddChildWidget;

        protected virtual void OnRemoveChildWidget()
        {
            if (RemoveChildWidget != null)
            {
                RemoveChildWidget.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after a child widget has been removed from this widget. The {@link qx.event.type.Data#getData} method of the event returns the removed child.
        /// </summary>
        public event EventHandler RemoveChildWidget;

    }
}
