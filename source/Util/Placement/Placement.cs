using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Util.Placement
{
    /// <summary>
    /// Contains methods to compute a position for any object which should
    /// be positioned relative to another object.
    /// 
    /// </summary>
    public partial class Placement : qxDotNet.Core.Object
    {

        private qxDotNet.AlignEnum _align = AlignEnum.right;
        private qxDotNet.Core.Object _axisX = null;
        private qxDotNet.Core.Object _axisY = null;
        private qxDotNet.EdgeEnum _edge = EdgeEnum.top;


        /// <summary>
        /// Specify with which edge of the target object, the object should be aligned
        /// 
        /// </summary>
        public qxDotNet.AlignEnum Align
        {
            get
            {
                return _align;
            }
            set
            {
               _align = value;
            }
        }

        /// <summary>
        /// The axis object to use for the horizontal placement
        /// 
        /// </summary>
        public qxDotNet.Core.Object AxisX
        {
            get
            {
                return _axisX;
            }
            set
            {
               _axisX = value;
            }
        }

        /// <summary>
        /// The axis object to use for the vertical placement
        /// 
        /// </summary>
        public qxDotNet.Core.Object AxisY
        {
            get
            {
                return _axisY;
            }
            set
            {
               _axisY = value;
            }
        }

        /// <summary>
        /// Specify to which edge of the target object, the object should be attached
        /// 
        /// </summary>
        public qxDotNet.EdgeEnum Edge
        {
            get
            {
                return _edge;
            }
            set
            {
               _edge = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.util.placement.Placement";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("align", _align, AlignEnum.right);
            state.SetPropertyValue("axisX", _axisX, null);
            state.SetPropertyValue("axisY", _axisY, null);
            state.SetPropertyValue("edge", _edge, EdgeEnum.top);


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
