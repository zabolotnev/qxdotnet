using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// Provides scrolling ability during drag session to the widget.
    /// 
    /// </summary>
    public partial class DragDropScrolling : qxDotNet.Core.Object
    {

        private float _dragScrollSlowDownFactor = 0.1f;
        private int _dragScrollThresholdX = 30;
        private int _dragScrollThresholdY = 30;


        /// <summary>
        /// The factor for slowing down the scrolling.
        /// 
        /// </summary>
        public float DragScrollSlowDownFactor
        {
            get
            {
                return _dragScrollSlowDownFactor;
            }
            set
            {
               _dragScrollSlowDownFactor = value;
            }
        }

        /// <summary>
        /// The threshold for the x-axis (in pixel) to activate scrolling at the edges.
        /// 
        /// </summary>
        public int DragScrollThresholdX
        {
            get
            {
                return _dragScrollThresholdX;
            }
            set
            {
               _dragScrollThresholdX = value;
            }
        }

        /// <summary>
        /// The threshold for the y-axis (in pixel) to activate scrolling at the edges.
        /// 
        /// </summary>
        public int DragScrollThresholdY
        {
            get
            {
                return _dragScrollThresholdY;
            }
            set
            {
               _dragScrollThresholdY = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.DragDropScrolling";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("dragScrollSlowDownFactor", _dragScrollSlowDownFactor, 0.1f);
            state.SetPropertyValue("dragScrollThresholdX", _dragScrollThresholdX, 30);
            state.SetPropertyValue("dragScrollThresholdY", _dragScrollThresholdY, 30);


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
