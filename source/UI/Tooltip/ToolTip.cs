using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tooltip
{
    /// <summary>
    /// A Tooltip provides additional information for widgets when the user hovers
    /// over a widget.
    /// 
    /// </summary>
    public partial class ToolTip : qxDotNet.UI.Popup.Popup
    {

        private qxDotNet.ArrowPositionEnum _arrowPosition = ArrowPositionEnum.left;
        private int _hideTimeout = 4000;
        private string _icon = "";
        private string _label = "";
        private qxDotNet.UI.Core.Widget _opener = null;
        private bool? _rich = false;
        private int _showTimeout = 700;


        /// <summary>
        /// Position of the arrow pointing towards the opening widget *
        /// 
        /// </summary>
        public qxDotNet.ArrowPositionEnum ArrowPosition
        {
            get
            {
                return _arrowPosition;
            }
            set
            {
               _arrowPosition = value;
            }
        }

        /// <summary>
        /// Interval after the tooltip is hidden (in milliseconds)
        /// 
        /// </summary>
        public int HideTimeout
        {
            get
            {
                return _hideTimeout;
            }
            set
            {
               _hideTimeout = value;
            }
        }

        /// <summary>
        /// Any URI String supported by qx.ui.basic.Image to display an icon in
        /// ToolTips's atom.
        /// 
        /// </summary>
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
               _icon = value;
            }
        }

        /// <summary>
        /// The label/caption/text of the ToolTip's atom.
        /// 
        /// </summary>
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
               _label = value;
            }
        }

        /// <summary>
        /// Widget that opened the tooltip
        /// 
        /// </summary>
        public qxDotNet.UI.Core.Widget Opener
        {
            get
            {
                return _opener;
            }
            set
            {
               _opener = value;
            }
        }

        /// <summary>
        /// Switches between rich HTML and text content. The text mode
        /// (false) supports advanced features like ellipsis when the
        /// available space is not enough. HTML mode (true) supports
        /// multi-line content and all the markup features of HTML content.
        /// 
        /// </summary>
        public bool? Rich
        {
            get
            {
                return _rich;
            }
            set
            {
               _rich = value;
            }
        }

        /// <summary>
        /// Interval after the tooltip is shown (in milliseconds)
        /// 
        /// </summary>
        public int ShowTimeout
        {
            get
            {
                return _showTimeout;
            }
            set
            {
               _showTimeout = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tooltip.ToolTip";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("arrowPosition", _arrowPosition, ArrowPositionEnum.left);
            state.SetPropertyValue("hideTimeout", _hideTimeout, 4000);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("opener", _opener, null);
            state.SetPropertyValue("rich", _rich, false);
            state.SetPropertyValue("showTimeout", _showTimeout, 700);


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
