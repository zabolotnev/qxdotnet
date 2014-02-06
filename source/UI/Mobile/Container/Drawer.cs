using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// Creates a drawer widget inside the given parent widget. The parent widget can be assigned as a constructor argument. If no parent is set, the application's root will be assumed as parent. A drawer widget can be assigned to left, right, top or bottom edge of its parent by property orientation. The drawer floats in on show() and floats out on hide(). Additionally the drawer is shown by swiping in reverse direction on the parent edge to where the drawer is placed to: Orientation: left, Swipe: right on parents edge: Drawer is shown etc. The drawer is hidden when user touches the parent area outside of the drawer. This behaviour can be deactivated by the property hideOnParentTouch.     var drawer = new qx.ui.mobile.container.Drawer();  drawer.setOrientation(\right\);  drawer.setTouchOffset(100);   var button = new qx.ui.mobile.form.Button(\AButton\);  drawer.add(button); 
    /// </summary>
    public partial class Drawer : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _hideOnParentTouch = true;
        private string _orientation = "left";
        private qxDotNet.PositionZEnum _positionZ = PositionZEnum.above;
        private int _size = 300;
        private int _touchOffset = 20;
        private int _transitionDuration = 500;


        /// <summary>
        /// Indicates whether the drawer should hide when the parent area of it is touched.
        /// </summary>
        public bool? HideOnParentTouch
        {
            get
            {
                return _hideOnParentTouch;
            }
            set
            {
               _hideOnParentTouch = value;
            }
        }

        /// <summary>
        /// Property for setting the orientation of the drawer. Allowed values are: left,right,top,bottom
        /// </summary>
        public string Orientation
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
        /// Sets the drawer zIndex position relative to its parent.
        /// </summary>
        public qxDotNet.PositionZEnum PositionZ
        {
            get
            {
                return _positionZ;
            }
            set
            {
               _positionZ = value;
            }
        }

        /// <summary>
        /// The size of the drawer in px. This value is interpreted as width if orientation is left | right, as height if orientation is top | bottom.
        /// </summary>
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
               _size = value;
            }
        }

        /// <summary>
        /// Sets the size of the touching area, where the drawer reacts on swipes for opening itself.
        /// </summary>
        public int TouchOffset
        {
            get
            {
                return _touchOffset;
            }
            set
            {
               _touchOffset = value;
            }
        }

        /// <summary>
        /// The duration time of the transition between shown/hidden state in ms.
        /// </summary>
        public int TransitionDuration
        {
            get
            {
                return _transitionDuration;
            }
            set
            {
               _transitionDuration = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.Drawer";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("hideOnParentTouch", _hideOnParentTouch, true);
            state.SetPropertyValue("orientation", _orientation, "left");
            state.SetPropertyValue("positionZ", _positionZ, PositionZEnum.above);
            state.SetPropertyValue("size", _size, 300);
            state.SetPropertyValue("touchOffset", _touchOffset, 20);
            state.SetPropertyValue("transitionDuration", _transitionDuration, 500);

            state.SetEvent("resize", false, "size");

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "resize")
            {
                OnResize();
            }
        }

        protected virtual void OnResize()
        {
            if (Resize != null)
            {
                Resize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the drawer changes its size.
        /// </summary>
        public event EventHandler Resize;

    }
}
