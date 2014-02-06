using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// A group widget arranges several widgets visual.  Example  Here is a little example of how to use the widget.    var title = new qx.ui.mobile.form.Title(\Group\);  var list = new qx.ui.mobile.list.List();  var group = new qx.ui.mobile.form.Group([list]);   this.getRoot.add(title);  this.getRoot.add(group);   This example creates a group and adds a list to it.
    /// </summary>
    public partial class Group : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _showBorder = true;


        /// <summary>
        /// Defines whether a border should drawn around the group.
        /// </summary>
        public bool? ShowBorder
        {
            get
            {
                return _showBorder;
            }
            set
            {
               _showBorder = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.Group";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("showBorder", _showBorder, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
