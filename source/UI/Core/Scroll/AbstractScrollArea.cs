using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Scroll
{
    /// <summary>
    /// The ScrollArea provides a container widget with on demand scroll bars if the content size exceeds the size of the container.
    /// </summary>
    public abstract partial class AbstractScrollArea : qxDotNet.UI.Core.Widget
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


        public override string GetTypeName()
        {
            return "qx.ui.core.scroll.AbstractScrollArea";
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
