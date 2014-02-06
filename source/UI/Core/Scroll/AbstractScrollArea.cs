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
        private float _dragScrollSlowDownFactor = 0.1f;
        private int _dragScrollThresholdX = 30;
        private int _dragScrollThresholdY = 30;


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

        /// <summary>
        /// The factor for slowing down the scrolling.
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.scroll.AbstractScrollArea";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scrollbarX", _scrollbarX, ScrollbarEnum.auto);
            state.SetPropertyValue("scrollbarY", _scrollbarY, ScrollbarEnum.auto);
            state.SetPropertyValue("dragScrollSlowDownFactor", _dragScrollSlowDownFactor, 0.1f);
            state.SetPropertyValue("dragScrollThresholdX", _dragScrollThresholdX, 30);
            state.SetPropertyValue("dragScrollThresholdY", _dragScrollThresholdY, 30);

            state.SetEvent("scrollAnimationXEnd", false);
            state.SetEvent("scrollAnimationYEnd", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "scrollAnimationXEnd")
            {
                OnScrollAnimationXEnd();
            }
            if (eventName == "scrollAnimationYEnd")
            {
                OnScrollAnimationYEnd();
            }
        }

        protected virtual void OnScrollAnimationXEnd()
        {
            if (ScrollAnimationXEnd != null)
            {
                ScrollAnimationXEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired as soon as the scroll animation in X direction ends.
        /// </summary>
        public event EventHandler ScrollAnimationXEnd;

        protected virtual void OnScrollAnimationYEnd()
        {
            if (ScrollAnimationYEnd != null)
            {
                ScrollAnimationYEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired as soon as the scroll animation in X direction ends.
        /// </summary>
        public event EventHandler ScrollAnimationYEnd;

    }
}
