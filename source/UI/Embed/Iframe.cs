using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Embed
{
    /// <summary>
    /// Container widget for internal frames (iframes).
    /// An iframe can display any HTML page inside the widget.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    /// var document = this.getRoot();
    /// var iframe = new qx.ui.embed.Iframe("http://www.qooxdoo.org");
    /// document.add(iframe);
    /// 
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Iframe : qxDotNet.UI.Embed.AbstractIframe
    {

        private bool? _nativeHelp = false;
        private qxDotNet.ScrollbarVisibleEnum _scrollbar = (ScrollbarVisibleEnum)(-1);


        /// <summary>
        /// If the user presses F1 in IE by default the onhelp event is fired and
        /// IE's help window is opened. Setting this property to false
        /// prevents this behavior.
        /// 
        /// Note: This only works if the iframe source is served from the same domain
        /// as the main application.
        /// 
        /// </summary>
        public bool? NativeHelp
        {
            get
            {
                return _nativeHelp;
            }
            set
            {
               _nativeHelp = value;
            }
        }

        /// <summary>
        /// Whether the widget should have scrollbars.
        /// 
        /// </summary>
        public qxDotNet.ScrollbarVisibleEnum Scrollbar
        {
            get
            {
                return _scrollbar;
            }
            set
            {
               _scrollbar = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.embed.Iframe";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("nativeHelp", _nativeHelp, false);
            state.SetPropertyValue("scrollbar", _scrollbar, (ScrollbarVisibleEnum)(-1));


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
