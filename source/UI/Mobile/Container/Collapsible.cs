using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// Creates a Collapsible widget. It contains a {@link qx.ui.mobile.basic.Label Label} for the header and a {@link qx.ui.mobile.container.Composite Composite} for the content.  The visiblity of the content composite toggles when user taps on header.  Example  Here is an example of how to use the widget.    var collapsible = new qx.ui.mobile.container.Collapsible(\CollapsibleHeader\);  collapsible.setCombined(false);  collapsible.setCollapsed(false);   var label = new qx.ui.mobile.basic.Label(\ThisisthecontentoftheCollapsible.\);  collapsible.add(label);  
    /// </summary>
    public partial class Collapsible : qxDotNet.UI.Mobile.Core.Widget
    {

        private bool? _collapsed = true;
        private bool? _combined = true;


        /// <summary>
        /// The collapsed state of this widget.
        /// </summary>
        public bool? Collapsed
        {
            get
            {
                return _collapsed;
            }
            set
            {
               _collapsed = value;
               OnChangeCollapsed();
            }
        }

        /// <summary>
        /// Controls whether the Collapsible's content  should be visually associated with its headers.
        /// </summary>
        public bool? Combined
        {
            get
            {
                return _combined;
            }
            set
            {
               _combined = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.Collapsible";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("collapsed", _collapsed, true);
            state.SetPropertyValue("combined", _combined, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeCollapsed()
        {
            if (ChangeCollapsed != null)
            {
                ChangeCollapsed.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #collapsed}.
        /// </summary>
        public event EventHandler ChangeCollapsed;

    }
}
