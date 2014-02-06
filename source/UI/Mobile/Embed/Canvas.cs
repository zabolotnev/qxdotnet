using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Embed
{
    /// <summary>
    /// Creates a HTML canvas widget in your mobile application.  Example  Here is an example of how to use the canvas widget.   var canvas = new qx.ui.mobile.embed.Canvas();  canvas.setWidth(150); canvas.setHeight(150); this.getContent().add(canvas);  var ctx = canvas.getContext2d(); ctx.strokeStyle = '#3D72C9'; ctx.beginPath(); ctx.arc(75,85,50,0,Math.PI*2,true); ctx.moveTo(110,85); ctx.arc(75,85,35,0,Math.PI,false); ctx.moveTo(65,75); ctx.arc(60,75,5,0,Math.PI*2,true); ctx.moveTo(95,75); ctx.arc(90,75,5,0,Math.PI*2,true); ctx.stroke(); 
    /// </summary>
    public partial class Canvas : qxDotNet.UI.Mobile.Core.Widget
    {

        private int _height = 0;
        private int _width = 0;


        /// <summary>
        /// 
        /// </summary>
        public int Height
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
        /// 
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
               _width = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.embed.Canvas";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("height", _height, 0);
            state.SetPropertyValue("width", _width, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
