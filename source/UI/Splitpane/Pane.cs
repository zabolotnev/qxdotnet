using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Splitpane
{
    /// <summary>
    /// A split panes divides an area into two panes. The ratio between the two panes is configurable by the user using the splitter.
    /// </summary>
    public partial class Pane : qxDotNet.UI.Core.Widget
    {

        private int _offset = 6;
        private qxDotNet.OrientationEnum _orientation = OrientationEnum.horizontal;


        /// <summary>
        /// Distance between mouse cursor and splitter when the cursor should change and enable resizing.
        /// </summary>
        public int Offset
        {
            get
            {
                return _offset;
            }
            set
            {
               _offset = value;
            }
        }

        /// <summary>
        /// The orientation of the splitpane control.
        /// </summary>
        public qxDotNet.OrientationEnum Orientation
        {
            get
            {
                return _orientation;
            }
            set
            {
               _orientation = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.splitpane.Pane";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("offset", _offset, 6);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.horizontal);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
