using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Embed
{
    /// <summary>
    /// Container widget for internal frames (iframes) with qooxdoo scroll bar and size hint support.  An iframe can display any HTML page inside the widget. Note that custom scroll bars do only work if the iframe's source points to the same domain as the application.
    /// </summary>
    public partial class ThemedIframe : qxDotNet.UI.Embed.AbstractIframe
    {

        private qxDotNet.ScrollbarEnum _scrollbarX = ScrollbarEnum.auto;
        private qxDotNet.ScrollbarEnum _scrollbarY = ScrollbarEnum.auto;


        /// <summary>
        /// The policy, when the horizontal scrollbar should be shown.   auto: Show scrollbar on demand  on: Always show the scrollbar  off: Never show the scrollbar 
        /// </summary>
        public qxDotNet.ScrollbarEnum ScrollbarX
        {
            get
            {
                return _scrollbarX;
            }
            set
            {
               _scrollbarX = value;
            }
        }

        /// <summary>
        /// The policy, when the horizontal scrollbar should be shown.   auto: Show scrollbar on demand  on: Always show the scrollbar  off: Never show the scrollbar 
        /// </summary>
        public qxDotNet.ScrollbarEnum ScrollbarY
        {
            get
            {
                return _scrollbarY;
            }
            set
            {
               _scrollbarY = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.embed.ThemedIframe";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scrollbarX", _scrollbarX, ScrollbarEnum.auto);
            state.SetPropertyValue("scrollbarY", _scrollbarY, ScrollbarEnum.auto);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
