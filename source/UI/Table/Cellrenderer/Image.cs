using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// The image cell renderer renders image into table cells.
    /// </summary>
    public partial class Image : qxDotNet.UI.Table.Cellrenderer.AbstractImage
    {

        private int _width;
        private int _heigth;

        public Image(int Width, int Heigth)
        {
            _width = Width;
            _heigth = Heigth;
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Image";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
        }

        protected internal override string GetCustomConstructor()
        {
            return _width.ToString() + "," + _heigth.ToString();
        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
