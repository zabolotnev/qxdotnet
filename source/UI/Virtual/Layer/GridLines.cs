using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  Represents horizontal or vertical lines.
    /// </summary>
    public partial class GridLines : qxDotNet.UI.Virtual.Layer.Abstract
    {

        private string _defaultLineColor = "gray";
        private int _defaultLineSize = 1;
        private string _lineColor = "";
        private int _lineSize = 0;


        /// <summary>
        /// The default color for grid lines.
        /// </summary>
        public string DefaultLineColor
        {
            get
            {
                return _defaultLineColor;
            }
            set
            {
               _defaultLineColor = value;
            }
        }

        /// <summary>
        /// The default width/height for grid lines.
        /// </summary>
        public int DefaultLineSize
        {
            get
            {
                return _defaultLineSize;
            }
            set
            {
               _defaultLineSize = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LineColor
        {
            get
            {
                return _lineColor;
            }
            set
            {
               _lineColor = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LineSize
        {
            get
            {
                return _lineSize;
            }
            set
            {
               _lineSize = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.layer.GridLines";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("defaultLineColor", _defaultLineColor, "gray");
            state.SetPropertyValue("defaultLineSize", _defaultLineSize, 1);
            state.SetPropertyValue("lineColor", _lineColor, "");
            state.SetPropertyValue("lineSize", _lineSize, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
