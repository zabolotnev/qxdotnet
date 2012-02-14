using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Scroll
{
    /// <summary>
    /// The scroll bar widget, is a special slider, which is used in qooxdoo instead of the native browser scroll bars.  Scroll bars are used by the {@link qx.ui.container.Scroll} container. Usually a scroll bar is not used directly.
    /// </summary>
    public partial class ScrollBar : qxDotNet.UI.Core.Widget, qxDotNet.UI.Core.Scroll.IScrollBar
    {

        private decimal _knobFactor = 0m;
        private int _maximum = 100;
        private qxDotNet.OrientationEnum _orientation = OrientationEnum.horizontal;
        private int _pageStep = 10;
        private decimal _position = 0;
        private int _singleStep = 20;


        /// <summary>
        /// Factor to apply to the width/height of the knob in relation to the dimension of the underlying area.
        /// </summary>
        public decimal KnobFactor
        {
            get
            {
                return _knobFactor;
            }
            set
            {
               _knobFactor = value;
            }
        }

        /// <summary>
        /// The maximum value (difference between available size and content size).
        /// </summary>
        public int Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
               _maximum = value;
            }
        }

        /// <summary>
        /// The scroll bar orientation
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
        /// The amount to increment on each event. Typically corresponds to the user pressing PageUp or PageDown.
        /// </summary>
        public int PageStep
        {
            get
            {
                return _pageStep;
            }
            set
            {
               _pageStep = value;
            }
        }

        /// <summary>
        /// Position of the scrollbar (which means the scroll left/top of the attached area&#8217;s pane)  Strictly validates according to {@link #maximum}. Does not apply any correction to the incoming value. If you depend on this, please use {@link #scrollTo} instead.
        /// </summary>
        public decimal Position
        {
            get
            {
                return _position;
            }
            set
            {
               _position = value;
            }
        }

        /// <summary>
        /// Step size for each click on the up/down or left/right buttons.
        /// </summary>
        public int SingleStep
        {
            get
            {
                return _singleStep;
            }
            set
            {
               _singleStep = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.core.scroll.ScrollBar";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("knobFactor", _knobFactor, 0m);
            state.SetPropertyValue("maximum", _maximum, 100);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.horizontal);
            state.SetPropertyValue("pageStep", _pageStep, 10);
            state.SetPropertyValue("position", _position, 0);
            state.SetPropertyValue("singleStep", _singleStep, 20);

            if (Scroll != null)
            {
                state.SetEvent("scroll", false, "position");
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "scroll")
            {
                OnScroll();
            }
        }

        protected virtual void OnScroll()
        {
            if (Scroll != null)
            {
                Scroll.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #position}.
        /// </summary>
        public event EventHandler Scroll;

    }
}
