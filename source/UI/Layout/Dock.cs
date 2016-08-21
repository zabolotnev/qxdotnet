using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// Docks children to one of the edges.
    /// 
    /// Features
    /// 
    /// 
    /// Percent width for left/right/center attached children
    /// Percent height for top/bottom/center attached children
    /// Minimum and maximum dimensions
    /// Prioritized growing/shrinking (flex)
    /// Auto sizing
    /// Margins and Spacings
    /// Alignment in orthogonal axis (e.g. alignX of north attached)
    /// Different sort options for children
    /// 
    /// 
    /// Item Properties
    /// 
    /// 
    /// edge (String): The edge where the layout item
    ///  should be docked. This may be one of north, east,
    ///  south, west or center. (Required)
    /// width (String): Defines a percent
    ///  width for the item. The percent width,
    ///  when specified, is used instead of the width defined by the size hint.
    ///  This is only supported for children added to the north or south edge or
    ///  are centered in the middle of the layout.
    ///  The minimum and maximum width still takes care of the elements limitations.
    ///  It has no influence on the layout's size hint. Percents are mainly useful for
    ///  widgets which are sized by the outer hierarchy.
    /// 
    /// height (String): Defines a percent
    ///  height for the item. The percent height,
    ///  when specified, is used instead of the height defined by the size hint.
    ///  This is only supported for children added to the west or east edge or
    ///  are centered in the middle of the layout.
    ///  The minimum and maximum height still takes care of the elements limitations.
    ///  It has no influence on the layout's size hint. Percents are mainly useful for
    ///  widgets which are sized by the outer hierarchy.
    /// 
    /// 
    /// 
    /// Example
    /// 
    /// 
    /// var layout = new qx.ui.layout.Dock();
    /// 
    /// var w1 = new qx.ui.core.Widget();
    /// var w2 = new qx.ui.core.Widget();
    /// var w3 = new qx.ui.core.Widget();
    /// 
    /// w1.setHeight(200);
    /// w2.setWidth(150);
    /// 
    /// var container = new qx.ui.container.Composite(layout);
    /// container.add(w1, {edge:"north"});
    /// container.add(w2, {edge:"west"});
    /// container.add(w3, {edge:"center"});
    /// 
    /// 
    /// Detailed Description
    /// 
    /// Using this layout, items may be "docked" to a specific side
    /// of the available space. Each displayed item reduces the available space
    /// for the following children. Priorities depend on the position of
    /// the child in the internal children list.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Dock : qxDotNet.UI.Layout.Abstract
    {

        private bool? _connectSeparators = false;
        private string _separatorX = null;
        private string _separatorY = null;
        private qxDotNet.SortEnum _sort = SortEnum.auto;
        private int _spacingX = 0;
        private int _spacingY = 0;


        /// <summary>
        /// Whether separators should be collapsed so when a spacing is
        /// configured the line go over into each other
        /// 
        /// </summary>
        public bool? ConnectSeparators
        {
            get
            {
                return _connectSeparators;
            }
            set
            {
               _connectSeparators = value;
            }
        }

        /// <summary>
        /// Separator lines to use between the horizontal objects
        /// 
        /// </summary>
        public string SeparatorX
        {
            get
            {
                return _separatorX;
            }
            set
            {
               _separatorX = value;
            }
        }

        /// <summary>
        /// Separator lines to use between the vertical objects
        /// 
        /// </summary>
        public string SeparatorY
        {
            get
            {
                return _separatorY;
            }
            set
            {
               _separatorY = value;
            }
        }

        /// <summary>
        /// The way the widgets should be displayed (in conjunction with their
        /// position in the childrens array).
        /// 
        /// </summary>
        public qxDotNet.SortEnum Sort
        {
            get
            {
                return _sort;
            }
            set
            {
               _sort = value;
            }
        }

        /// <summary>
        /// Horizontal spacing between two children
        /// 
        /// </summary>
        public int SpacingX
        {
            get
            {
                return _spacingX;
            }
            set
            {
               _spacingX = value;
            }
        }

        /// <summary>
        /// Vertical spacing between two children
        /// 
        /// </summary>
        public int SpacingY
        {
            get
            {
                return _spacingY;
            }
            set
            {
               _spacingY = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Dock";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("connectSeparators", _connectSeparators, false);
            state.SetPropertyValue("separatorX", _separatorX, null);
            state.SetPropertyValue("separatorY", _separatorY, null);
            state.SetPropertyValue("sort", _sort, SortEnum.auto);
            state.SetPropertyValue("spacingX", _spacingX, 0);
            state.SetPropertyValue("spacingY", _spacingY, 0);


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
