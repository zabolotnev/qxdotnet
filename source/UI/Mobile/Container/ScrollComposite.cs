using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// The ScrollComposite is a extension of {@linkqx.ui.mobile.container.Composite}, and makes it possible to scroll vertically, if content size is greater than scrollComposite's size.  Every widget will be added to child's composite.  Example  Here is a little example of how to use the widget.    // create the composite  var scrollComposite = new qx.ui.mobile.container.ScrollComposite();   scrollComposite.setLayout(new qx.ui.mobile.layout.HBox());   // add some children  scrollComposite.add(new qx.ui.mobile.basic.Label(\Name:\), {flex:1});  scrollComposite.add(new qx.ui.mobile.form.TextField());   This example horizontally groups a label and text field by using a Composite configured with a horizontal box layout as a container.
    /// </summary>
    public partial class ScrollComposite : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _fixedHeight = false;
        private string _height = "10rem";
        private bool? _scrollableX = false;
        private bool? _scrollableY = true;
        private bool? _showScrollIndicator = true;


        /// <summary>
        /// This flag controls whether this widget has a fixed height or grows till the property value of height has reached.
        /// </summary>
        public bool? FixedHeight
        {
            get
            {
                return _fixedHeight;
            }
            set
            {
               _fixedHeight = value;
            }
        }

        /// <summary>
        /// The height of this widget. Allowed values are length or percentage values according to CSS height syntax.
        /// </summary>
        public string Height
        {
            get
            {
                return _height;
            }
            set
            {
               _height = value;
            }
        }

        /// <summary>
        /// Flag if scrolling in horizontal direction should be allowed.
        /// </summary>
        public bool? ScrollableX
        {
            get
            {
                return _scrollableX;
            }
            set
            {
               _scrollableX = value;
            }
        }

        /// <summary>
        /// Flag if scrolling in vertical direction should be allowed.
        /// </summary>
        public bool? ScrollableY
        {
            get
            {
                return _scrollableY;
            }
            set
            {
               _scrollableY = value;
            }
        }

        /// <summary>
        /// Controls whether are visual indicator is used, when the scrollComposite is scrollable to top or bottom direction.
        /// </summary>
        public bool? ShowScrollIndicator
        {
            get
            {
                return _showScrollIndicator;
            }
            set
            {
               _showScrollIndicator = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.ScrollComposite";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("fixedHeight", _fixedHeight, false);
            state.SetPropertyValue("height", _height, "10rem");
            state.SetPropertyValue("scrollableX", _scrollableX, false);
            state.SetPropertyValue("scrollableY", _scrollableY, true);
            state.SetPropertyValue("showScrollIndicator", _showScrollIndicator, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
