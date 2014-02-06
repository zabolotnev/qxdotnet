using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Container
{
    /// <summary>
    /// Container, which provides scrolling in one dimension (vertical or horizontal).
    /// </summary>
    public partial class SlideBar : qxDotNet.UI.Core.Widget
    {

        private qxDotNet.OrientationEnum _orientation = OrientationEnum.horizontal;
        private int _scrollStep = 15;
        private qxDotNet.UI.Layout.Abstract _layout = null;


        /// <summary>
        /// Orientation of the bar
        /// </summary>
        public qxDotNet.OrientationEnum Orientation
        {
            get
            {
                return _orientation;
            }
            set
            {
               _orientation = value;
            }
        }

        /// <summary>
        /// The number of pixels to scroll if the buttons are pressed
        /// </summary>
        public int ScrollStep
        {
            get
            {
                return _scrollStep;
            }
            set
            {
               _scrollStep = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Layout.Abstract Layout
        {
            get
            {
                return _layout;
            }
            set
            {
               _layout = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.container.SlideBar";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.horizontal);
            state.SetPropertyValue("scrollStep", _scrollStep, 15);
            state.SetPropertyValue("layout", _layout, null);

            state.SetEvent("scrollAnimationEnd", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "scrollAnimationEnd")
            {
                OnScrollAnimationEnd();
            }
        }

        protected virtual void OnScrollAnimationEnd()
        {
            if (ScrollAnimationEnd != null)
            {
                ScrollAnimationEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on scroll animation end invoked by "scroll*"; methods.
        /// </summary>
        public event EventHandler ScrollAnimationEnd;

    }
}
