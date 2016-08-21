using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Embed
{
    /// <summary>
    /// The Canvas widget embeds the HMTL canvas element
    /// [W3C-HTML5]
    /// 
    /// Note: This widget does not work in Internet Explorer 
    /// 
    /// To paint something on the canvas and keep the content updated on resizes you
    /// either have to override the {@link #_draw} method or redraw the content on
    /// the {@link #redraw} event. The drawing context can be obtained by {@link #getContext2d}.
    /// 
    /// Note that this widget operates on two different coordinate systems. The canvas
    /// has its own coordinate system for drawing operations. This canvas coordinate
    /// system is scaled to fit actual size of the DOM element. Each time the size of
    /// the canvas dimensions is changed a redraw is required. In this case the
    /// protected method {@link #_draw} is called and the event {@link #redraw}
    /// is fired. You can synchronize the internal canvas dimension with the
    /// CSS dimension of the canvas element by setting {@link #syncDimension} to
    /// true.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the canvas widget.
    /// 
    /// 
    /// var canvas = new qx.ui.embed.Canvas().set({
    ///  canvasWidth: 200,
    ///  canvasHeight: 200,
    ///  syncDimension: true
    /// });
    /// canvas.addListener("redraw", function(e)
    /// {
    ///  var data = e.getData();
    ///  var width = data.width;
    ///  var height = data.height;
    ///  var ctx = data.context;
    /// 
    ///  ctx.fillStyle = "rgb(200,0,0)";
    ///  ctx.fillRect (20, 20, width-5, height-5);
    /// 
    ///  ctx.fillStyle = "rgba(0, 0, 200, 0.5)";
    ///  ctx.fillRect (70, 70, 105, 100);
    /// }, this);
    /// 
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Canvas : qxDotNet.UI.Core.Widget
    {

        private int _canvasHeight = 150;
        private int _canvasWidth = 300;
        private bool? _syncDimension = false;


        /// <summary>
        /// The internal height of the canvas coordinates
        /// 
        /// </summary>
        public int CanvasHeight
        {
            get
            {
                return _canvasHeight;
            }
            set
            {
               _canvasHeight = value;
            }
        }

        /// <summary>
        /// The internal with of the canvas coordinates
        /// 
        /// </summary>
        public int CanvasWidth
        {
            get
            {
                return _canvasWidth;
            }
            set
            {
               _canvasWidth = value;
            }
        }

        /// <summary>
        /// Whether canvas and widget coordinates should be synchronized
        /// 
        /// </summary>
        public bool? SyncDimension
        {
            get
            {
                return _syncDimension;
            }
            set
            {
               _syncDimension = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.embed.Canvas";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("canvasHeight", _canvasHeight, 150);
            state.SetPropertyValue("canvasWidth", _canvasWidth, 300);
            state.SetPropertyValue("syncDimension", _syncDimension, false);

            if (Redraw != null)
            {
                state.SetEvent("redraw", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "redraw")
            {
                OnRedraw();
            }
        }

        /// <summary>
        /// Raises event 'Redraw'
        /// </summary>
        protected virtual void OnRedraw()
        {
            if (Redraw != null)
            {
                Redraw.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The redraw event is fired each time the canvas dimension change and the
        /// canvas needs to be updated. The data field contains a map containing the
        /// width and height of the canvas and the
        /// rendering context.
        /// 
        /// </summary>
        public event EventHandler Redraw;

    }
}
