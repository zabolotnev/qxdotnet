using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Dialog
{
    /// <summary>
    /// The widget displays a busy indicator.  Example  Here is a little example of how to use the widget.    var busyIndicator = new qx.ui.mobile.dialog.BusyIndicator(\Pleasewait\);  this.getRoot().add(busyIndicator);   This example create a widget to display the busy indicator.
    /// </summary>
    public partial class BusyIndicator : qxDotNet.UI.Mobile.Basic.Atom
    {

        private string _spinnerClass = "spinner";


        /// <summary>
        /// The spinner css class to use.
        /// </summary>
        public string SpinnerClass
        {
            get
            {
                return _spinnerClass;
            }
            set
            {
               _spinnerClass = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.dialog.BusyIndicator";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("spinnerClass", _spinnerClass, "spinner");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
