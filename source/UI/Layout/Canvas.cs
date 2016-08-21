using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// The Canvas is an extended Basic layout.
    /// 
    /// It is possible to position a widget relative to the right or bottom edge of
    /// the available space. It further supports stretching between left and right
    /// or top and bottom e.g. left=20 and right=20 would
    /// keep a margin of 20 pixels to both edges. The Canvas layout has support for
    /// percent dimensions and locations.
    /// 
    /// Features
    /// 
    /// 
    /// Pixel dimensions and locations
    /// Percent dimensions and locations
    /// Stretching between left+right and top+bottom
    /// Minimum and maximum dimensions
    /// Children are automatically shrunk to their minimum dimensions if not enough space is available
    /// Auto sizing (ignoring percent values)
    /// Margins (also negative ones)
    /// 
    /// 
    /// Item Properties
    /// 
    /// 
    /// left (Integer|String): The left coordinate in pixel or as a percent string e.g. 20 or 30%.
    /// top (Integer|String): The top coordinate in pixel or as a percent string e.g. 20 or 30%.
    /// right (Integer|String): The right coordinate in pixel or as a percent string e.g. 20 or 30%.
    /// bottom (Integer|String): The bottom coordinate in pixel or as a percent string e.g. 20 or 30%.
    /// edge (Integer|String): The coordinate in pixels or as a percent string to be used for all four edges.
    /// width (String): A percent width e.g. 40%.
    /// height (String): A percent height e.g. 60%.
    /// 
    /// 
    /// Notes
    /// 
    /// 
    /// Stretching (left->right or top->bottom)
    ///  has a higher priority than the preferred dimensions
    /// Stretching has a lower priority than the min/max dimensions.
    /// Percent values have no influence on the size hint of the layout.
    /// 
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the canvas layout.
    /// 
    /// 
    /// var container = new qx.ui.container.Composite(new qx.ui.layout.Canvas());
    /// 
    /// // simple positioning
    /// container.add(new qx.ui.core.Widget(), {top: 10, left: 10});
    /// 
    /// // stretch vertically with 10 pixel distance to the parent's top
    /// // and bottom border
    /// container.add(new qx.ui.core.Widget(), {top: 10, left: 10, bottom: 10});
    /// 
    /// // percent positioning and size
    /// container.add(new qx.ui.core.Widget(), {left: "50%", top: "50%", width: "25%", height: "40%"});
    /// 
    /// 
    /// External Documentation
    /// 
    /// 
    /// Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Canvas : qxDotNet.UI.Layout.Abstract
    {

        private bool? _desktop = false;


        /// <summary>
        /// If desktop mode is active, the children's minimum sizes are ignored
        /// by the layout calculation. This is necessary to prevent the desktop
        /// from growing if e.g. a window is moved beyond the edge of the desktop
        /// 
        /// </summary>
        public bool? Desktop
        {
            get
            {
                return _desktop;
            }
            set
            {
               _desktop = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Canvas";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("desktop", _desktop, false);


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
