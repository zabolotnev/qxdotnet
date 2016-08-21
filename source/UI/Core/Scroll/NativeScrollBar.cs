using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Scroll
{
    /// <summary>
    /// The scroll bar widget wraps the native browser scroll bars as a qooxdoo widget.
    /// It can be uses instead of the styled qooxdoo scroll bars.
    /// 
    /// Scroll bars are used by the {@link qx.ui.container.Scroll} container. Usually
    /// a scroll bar is not used directly.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  var scrollBar = new qx.ui.core.scroll.NativeScrollBar("horizontal");
    ///  scrollBar.set({
    ///  maximum: 500
    ///  })
    ///  this.getRoot().add(scrollBar);
    /// 
    /// 
    /// This example creates a horizontal scroll bar with a maximum value of 500.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class NativeScrollBar : qxDotNet.UI.Core.Widget, qxDotNet.UI.Core.Scroll.IScrollBar
    {

        private decimal _knobFactor = 0m;
        private int _maximum = 100;
        private qxDotNet.OrientationEnum _orientation = OrientationEnum.horizontal;
        private decimal _position = 0m;
        private int _singleStep = 20;


        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// Step size for each tap on the up/down or left/right buttons.
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.scroll.NativeScrollBar";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("knobFactor", _knobFactor, 0m);
            state.SetPropertyValue("maximum", _maximum, 100);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.horizontal);
            state.SetPropertyValue("position", _position, 0m);
            state.SetPropertyValue("singleStep", _singleStep, 20);

            state.SetEvent("scroll", false, "position");
            if (ScrollAnimationEnd != null)
            {
                state.SetEvent("scrollAnimationEnd", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "scroll")
            {
                OnScroll();
            }
            if (eventName == "scrollAnimationEnd")
            {
                OnScrollAnimationEnd();
            }
        }

        /// <summary>
        /// Raises event 'Scroll'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ScrollAnimationEnd'
        /// </summary>
        protected virtual void OnScrollAnimationEnd()
        {
            if (ScrollAnimationEnd != null)
            {
                ScrollAnimationEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired as soon as the scroll animation ended.
        /// 
        /// </summary>
        public event EventHandler ScrollAnimationEnd;

    }
}
