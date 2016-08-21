using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// The button to fill the menubar
    /// 
    /// </summary>
    public partial class MenuButton : qxDotNet.UI.Menubar.Button
    {

        private bool? _showArrow = false;


        /// <summary>
        /// Whether the button should show an arrow to indicate the menu behind it
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.toolbar.MenuButton";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("showArrow", _showArrow, false);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
