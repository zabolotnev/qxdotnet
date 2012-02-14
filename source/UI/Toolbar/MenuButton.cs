using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// The button to fill the menubar
    /// </summary>
    public partial class MenuButton : qxDotNet.UI.Menubar.Button
    {

        private bool? _showArrow = false;


        /// <summary>
        /// Whether the button should show an arrow to indicate the menu behind it
        /// </summary>
        public bool? ShowArrow
        {
            get
            {
                return _showArrow;
            }
            set
            {
               _showArrow = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.toolbar.MenuButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("showArrow", _showArrow, false);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
