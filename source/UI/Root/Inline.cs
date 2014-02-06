using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Root
{
    /// <summary>
    /// This classes could be used to insert qooxdoo islands into existing web pages. You can use the isles to place any qooxdoo powered widgets inside a layout made using traditional HTML markup and CSS.  The size of the widget in each dimension can either be determined by the size hint of the inline";s children or by the size of the root DOM element. If dynamicX/dynamicY is true the width/height of the DOM element is used.  This class uses {@link qx.ui.layout.Basic} as default layout. The layout can be changed using the {@link #setLayout} method.  To position popups and tooltips please have a look at {@link qx.ui.root.Page}.
    /// </summary>
    public partial class Inline : qxDotNet.UI.Root.Abstract
    {

        private qxDotNet.UI.Layout.Abstract _layout = null;


        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Layout.Abstract Layout
        {
            get
            {
                return _layout;
            }
            set
            {
               _layout = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.root.Inline";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("layout", _layout, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
