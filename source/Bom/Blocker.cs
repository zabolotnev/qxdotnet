using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom
{
    /// <summary>
    /// This class provides an unified blocker which offers three different modes.  Blocker modes   block the whole document block the content of an element act as an underlying blocker for an element to shim native controls   The third mode is mainly necessary for IE browsers.  The first mode is the easiest to use. Just use the {@link #block} method without a parameter. The second and third mode are taking a DOM element as parameter for the {@link #block} method. Additionally one need to setup the "zIndex" value correctly to get the right results (see at {@link #setBlockerZIndex} method).  The zIndex value defaults to the value "10000". Either you set an appropiate value for the blocker zIndex or for your DOM element to block. If you want to block the content of your DOM element it has to have at least the zIndex value of "10001" with default blocker values.
    /// </summary>
    public partial class Blocker : qxDotNet.Core.Object
    {

        private string _blockerColor = "";
        private int _blockerOpacity = 0;
        private int _blockerZIndex = 0;


        /// <summary>
        /// 
        /// </summary>
        public string BlockerColor
        {
            get
            {
                return _blockerColor;
            }
            set
            {
               _blockerColor = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int BlockerOpacity
        {
            get
            {
                return _blockerOpacity;
            }
            set
            {
               _blockerOpacity = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int BlockerZIndex
        {
            get
            {
                return _blockerZIndex;
            }
            set
            {
               _blockerZIndex = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.Blocker";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("blockerColor", _blockerColor, "");
            state.SetPropertyValue("blockerOpacity", _blockerOpacity, 0);
            state.SetPropertyValue("blockerZIndex", _blockerZIndex, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
