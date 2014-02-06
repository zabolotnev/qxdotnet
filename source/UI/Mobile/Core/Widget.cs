using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Core
{
    /// <summary>
    /// This is the base class for all mobile widgets.
    /// </summary>
    public partial class Widget : qxDotNet.Core.Object
    {

        private bool? _activatable = false;
        private bool? _anonymous = null;
        private string _defaultCssClass = null;
        private bool? _enabled = true;
        private string _id = null;
        private string _name = null;
        private decimal _rotation = 0m;
        private decimal _scaleX = 0m;
        private decimal _scaleY = 0m;
        private qxDotNet.TransformUnitEnum _transformUnit = TransformUnitEnum.rem;
        private decimal _translateX = 0;
        private decimal _translateY = 0;
        private decimal _translateZ = 0;
        private qxDotNet.VisibilityEnum _visibility = VisibilityEnum.visible;
        private qxDotNet.UI.Core.Widget _layoutParent = null;


        /// <summary>
        /// Whether the widget can be activated or not. When the widget is activated a css class active is automatically added to the widget, which can indicate the acitvation status.
        /// </summary>
        public bool? Activatable
        {
            get
            {
                return _activatable;
            }
            set
            {
               _activatable = value;
            }
        }

        /// <summary>
        /// Whether the widget should be the target of an event. Set this property to false when the widget is a child of another widget and shouldn't react on events.
        /// </summary>
        public bool? Anonymous
        {
            get
            {
                return _anonymous;
            }
            set
            {
               _anonymous = value;
            }
        }

        /// <summary>
        /// The default CSS class used for this widget. The default CSS class should contain the common appearance of the widget. It is set to the container element of the widget. Use {@link #addCssClass} to enhance the default appearance of the widget.
        /// </summary>
        public string DefaultCssClass
        {
            get
            {
                return _defaultCssClass;
            }
            set
            {
               _defaultCssClass = value;
            }
        }

        /// <summary>
        /// Whether this widget is enabled or not
        /// </summary>
        public bool? Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
               _enabled = value;
               OnChangeEnabled();
            }
        }

        /// <summary>
        /// The ID of the widget. When the ID is set to null an auto id will be generated.
        /// </summary>
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
               _id = value;
               OnChangeId();
            }
        }

        /// <summary>
        /// The name attribute of the container element. Usefull when you want to find an element by its name attribute.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
               _name = value;
            }
        }

        /// <summary>
        /// Rotates the widget. Negative and positive values are allowed.
        /// </summary>
        public decimal Rotation
        {
            get
            {
                return _rotation;
            }
            set
            {
               _rotation = value;
            }
        }

        /// <summary>
        /// Scales the widget in X direction (width).
        /// </summary>
        public decimal ScaleX
        {
            get
            {
                return _scaleX;
            }
            set
            {
               _scaleX = value;
            }
        }

        /// <summary>
        /// Scales the widget in Y direction (height).
        /// </summary>
        public decimal ScaleY
        {
            get
            {
                return _scaleY;
            }
            set
            {
               _scaleY = value;
            }
        }

        /// <summary>
        /// This property controls whether the transformation uses the length unit px or rem. This feature is important for creating a resolution independent transformation.
        /// </summary>
        public qxDotNet.TransformUnitEnum TransformUnit
        {
            get
            {
                return _transformUnit;
            }
            set
            {
               _transformUnit = value;
            }
        }

        /// <summary>
        /// Moves the widget on X axis.
        /// </summary>
        public decimal TranslateX
        {
            get
            {
                return _translateX;
            }
            set
            {
               _translateX = value;
            }
        }

        /// <summary>
        /// Moves the widget on Y axis.
        /// </summary>
        public decimal TranslateY
        {
            get
            {
                return _translateY;
            }
            set
            {
               _translateY = value;
            }
        }

        /// <summary>
        /// Moves the widget on Z axis.
        /// </summary>
        public decimal TranslateZ
        {
            get
            {
                return _translateZ;
            }
            set
            {
               _translateZ = value;
            }
        }

        /// <summary>
        /// Controls the visibility. Valid values are:    visible: Render the widget  hidden: Hide the widget. The space will be still available.  excluded: Hide the widget. The space will be released. 
        /// </summary>
        public qxDotNet.VisibilityEnum Visibility
        {
            get
            {
                return _visibility;
            }
            set
            {
               _visibility = value;
               OnChangeVisibility();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Core.Widget LayoutParent
        {
            get
            {
                return _layoutParent;
            }
            set
            {
               _layoutParent = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.core.Widget";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("activatable", _activatable, false);
            state.SetPropertyValue("anonymous", _anonymous, null);
            state.SetPropertyValue("defaultCssClass", _defaultCssClass, null);
            state.SetPropertyValue("enabled", _enabled, true);
            state.SetPropertyValue("id", _id, null);
            state.SetPropertyValue("name", _name, null);
            state.SetPropertyValue("rotation", _rotation, 0m);
            state.SetPropertyValue("scaleX", _scaleX, 0m);
            state.SetPropertyValue("scaleY", _scaleY, 0m);
            state.SetPropertyValue("transformUnit", _transformUnit, TransformUnitEnum.rem);
            state.SetPropertyValue("translateX", _translateX, 0);
            state.SetPropertyValue("translateY", _translateY, 0);
            state.SetPropertyValue("translateZ", _translateZ, 0);
            state.SetPropertyValue("visibility", _visibility, VisibilityEnum.visible);
            state.SetPropertyValue("layoutParent", _layoutParent, null);

            if (Activate != null)
            {
                state.SetEvent("activate", false);
            }
            if (Appear != null)
            {
                state.SetEvent("appear", false);
            }
            if (BeforeContextmenuOpen != null)
            {
                state.SetEvent("beforeContextmenuOpen", false);
            }
            if (Blur != null)
            {
                state.SetEvent("blur", false);
            }
            if (Click != null)
            {
                state.SetEvent("click", false);
            }
            if (Contextmenu != null)
            {
                state.SetEvent("contextmenu", false);
            }
            if (Dblclick != null)
            {
                state.SetEvent("dblclick", false);
            }
            if (Deactivate != null)
            {
                state.SetEvent("deactivate", false);
            }
            if (Disappear != null)
            {
                state.SetEvent("disappear", false);
            }
            if (Domupdated != null)
            {
                state.SetEvent("domupdated", false);
            }
            if (Focus != null)
            {
                state.SetEvent("focus", false);
            }
            if (Focusin != null)
            {
                state.SetEvent("focusin", false);
            }
            if (Focusout != null)
            {
                state.SetEvent("focusout", false);
            }
            if (Keydown != null)
            {
                state.SetEvent("keydown", false);
            }
            if (Keyinput != null)
            {
                state.SetEvent("keyinput", false);
            }
            if (Keypress != null)
            {
                state.SetEvent("keypress", false);
            }
            if (Keyup != null)
            {
                state.SetEvent("keyup", false);
            }
            if (Longtap != null)
            {
                state.SetEvent("longtap", false);
            }
            if (Mousedown != null)
            {
                state.SetEvent("mousedown", false);
            }
            if (Mousemove != null)
            {
                state.SetEvent("mousemove", false);
            }
            if (Mouseout != null)
            {
                state.SetEvent("mouseout", false);
            }
            if (Mouseover != null)
            {
                state.SetEvent("mouseover", false);
            }
            if (Mouseup != null)
            {
                state.SetEvent("mouseup", false);
            }
            if (Mousewheel != null)
            {
                state.SetEvent("mousewheel", false);
            }
            if (Swipe != null)
            {
                state.SetEvent("swipe", false);
            }
            if (Tap != null)
            {
                state.SetEvent("tap", false);
            }
            if (Touchcancel != null)
            {
                state.SetEvent("touchcancel", false);
            }
            if (Touchend != null)
            {
                state.SetEvent("touchend", false);
            }
            if (Touchmove != null)
            {
                state.SetEvent("touchmove", false);
            }
            if (Touchstart != null)
            {
                state.SetEvent("touchstart", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "activate")
            {
                OnActivate();
            }
            if (eventName == "appear")
            {
                OnAppear();
            }
            if (eventName == "beforeContextmenuOpen")
            {
                OnBeforeContextmenuOpen();
            }
            if (eventName == "blur")
            {
                OnBlur();
            }
            if (eventName == "click")
            {
                OnClick();
            }
            if (eventName == "contextmenu")
            {
                OnContextmenu();
            }
            if (eventName == "dblclick")
            {
                OnDblclick();
            }
            if (eventName == "deactivate")
            {
                OnDeactivate();
            }
            if (eventName == "disappear")
            {
                OnDisappear();
            }
            if (eventName == "domupdated")
            {
                OnDomupdated();
            }
            if (eventName == "focus")
            {
                OnFocus();
            }
            if (eventName == "focusin")
            {
                OnFocusin();
            }
            if (eventName == "focusout")
            {
                OnFocusout();
            }
            if (eventName == "keydown")
            {
                OnKeydown();
            }
            if (eventName == "keyinput")
            {
                OnKeyinput();
            }
            if (eventName == "keypress")
            {
                OnKeypress();
            }
            if (eventName == "keyup")
            {
                OnKeyup();
            }
            if (eventName == "longtap")
            {
                OnLongtap();
            }
            if (eventName == "mousedown")
            {
                OnMousedown();
            }
            if (eventName == "mousemove")
            {
                OnMousemove();
            }
            if (eventName == "mouseout")
            {
                OnMouseout();
            }
            if (eventName == "mouseover")
            {
                OnMouseover();
            }
            if (eventName == "mouseup")
            {
                OnMouseup();
            }
            if (eventName == "mousewheel")
            {
                OnMousewheel();
            }
            if (eventName == "swipe")
            {
                OnSwipe();
            }
            if (eventName == "tap")
            {
                OnTap();
            }
            if (eventName == "touchcancel")
            {
                OnTouchcancel();
            }
            if (eventName == "touchend")
            {
                OnTouchend();
            }
            if (eventName == "touchmove")
            {
                OnTouchmove();
            }
            if (eventName == "touchstart")
            {
                OnTouchstart();
            }
        }

        protected virtual void OnActivate()
        {
            if (Activate != null)
            {
                Activate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget gets active (receives keyboard events etc.)
        /// </summary>
        public event EventHandler Activate;

        protected virtual void OnAppear()
        {
            if (Appear != null)
            {
                Appear.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the widget appears on the screen.
        /// </summary>
        public event EventHandler Appear;

        protected virtual void OnBeforeContextmenuOpen()
        {
            if (BeforeContextmenuOpen != null)
            {
                BeforeContextmenuOpen.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired before the context menu is opened.
        /// </summary>
        public event EventHandler BeforeContextmenuOpen;

        protected virtual void OnBlur()
        {
            if (Blur != null)
            {
                Blur.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired when the widget gets blurred.
        /// </summary>
        public event EventHandler Blur;

        protected virtual void OnChangeEnabled()
        {
            if (ChangeEnabled != null)
            {
                ChangeEnabled.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #enabled}.
        /// </summary>
        public event EventHandler ChangeEnabled;

        protected virtual void OnChangeId()
        {
            if (ChangeId != null)
            {
                ChangeId.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #id}.
        /// </summary>
        public event EventHandler ChangeId;

        protected virtual void OnChangeVisibility()
        {
            if (ChangeVisibility != null)
            {
                ChangeVisibility.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #visibility}.
        /// </summary>
        public event EventHandler ChangeVisibility;

        protected virtual void OnClick()
        {
            if (Click != null)
            {
                Click.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Widget is clicked using left or middle button.  {@link qx.event.type.Mouse#getButton} for more details.
        /// </summary>
        public event EventHandler Click;

        protected virtual void OnContextmenu()
        {
            if (Contextmenu != null)
            {
                Contextmenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Widget is clicked using the right mouse button.
        /// </summary>
        public event EventHandler Contextmenu;

        protected virtual void OnDblclick()
        {
            if (Dblclick != null)
            {
                Dblclick.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Widget is double clicked using left or middle button.  {@link qx.event.type.Mouse#getButton} for more details.
        /// </summary>
        public event EventHandler Dblclick;

        protected virtual void OnDeactivate()
        {
            if (Deactivate != null)
            {
                Deactivate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget gets inactive
        /// </summary>
        public event EventHandler Deactivate;

        protected virtual void OnDisappear()
        {
            if (Disappear != null)
            {
                Disappear.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the widget disappears from the screen.
        /// </summary>
        public event EventHandler Disappear;

        protected virtual void OnDomupdated()
        {
            if (Domupdated != null)
            {
                Domupdated.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after a massive DOM manipulation, e.g. when DOM elements were added or styles were changed. Listen to this event, if you need to recalculate a layout or have to update your view.
        /// </summary>
        public event EventHandler Domupdated;

        protected virtual void OnFocus()
        {
            if (Focus != null)
            {
                Focus.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired when the widget gets focused.
        /// </summary>
        public event EventHandler Focus;

        protected virtual void OnFocusin()
        {
            if (Focusin != null)
            {
                Focusin.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget itself or any child of the widget receive the focus.
        /// </summary>
        public event EventHandler Focusin;

        protected virtual void OnFocusout()
        {
            if (Focusout != null)
            {
                Focusout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget itself or any child of the widget lost the focus.
        /// </summary>
        public event EventHandler Focusout;

        protected virtual void OnKeydown()
        {
            if (Keydown != null)
            {
                Keydown.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event if fired if a keyboard key is pressed down. This event is only fired once if the user keeps the key pressed for a while.
        /// </summary>
        public event EventHandler Keydown;

        protected virtual void OnKeyinput()
        {
            if (Keyinput != null)
            {
                Keyinput.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired if the pressed key or keys result in a printable character. Since the character is not necessarily associated with a single physical key press, the event does not have a key identifier getter. This event gets repeated if the user keeps pressing the key(s).  The unicode code of the pressed key can be read using {@link qx.event.type.KeyInput#getCharCode}.
        /// </summary>
        public event EventHandler Keyinput;

        protected virtual void OnKeypress()
        {
            if (Keypress != null)
            {
                Keypress.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired any time a key is pressed. It will be repeated if the user keeps the key pressed. The pressed key can be determined using {@link qx.event.type.KeySequence#getKeyIdentifier}.
        /// </summary>
        public event EventHandler Keypress;

        protected virtual void OnKeyup()
        {
            if (Keyup != null)
            {
                Keyup.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event if fired if a keyboard key is released.
        /// </summary>
        public event EventHandler Keyup;

        protected virtual void OnLongtap()
        {
            if (Longtap != null)
            {
                Longtap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a finger holds on the screen.
        /// </summary>
        public event EventHandler Longtap;

        protected virtual void OnMousedown()
        {
            if (Mousedown != null)
            {
                Mousedown.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Mouse button is pressed on the widget.
        /// </summary>
        public event EventHandler Mousedown;

        protected virtual void OnMousemove()
        {
            if (Mousemove != null)
            {
                Mousemove.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse cursor moves over the widget.
        /// </summary>
        public event EventHandler Mousemove;

        protected virtual void OnMouseout()
        {
            if (Mouseout != null)
            {
                Mouseout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse cursor leaves widget.
        /// </summary>
        public event EventHandler Mouseout;

        protected virtual void OnMouseover()
        {
            if (Mouseover != null)
            {
                Mouseover.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse cursor enters the widget.
        /// </summary>
        public event EventHandler Mouseover;

        protected virtual void OnMouseup()
        {
            if (Mouseup != null)
            {
                Mouseup.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Mouse button is released on the widget.
        /// </summary>
        public event EventHandler Mouseup;

        protected virtual void OnMousewheel()
        {
            if (Mousewheel != null)
            {
                Mousewheel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse wheel is used over the widget.
        /// </summary>
        public event EventHandler Mousewheel;

        protected virtual void OnSwipe()
        {
            if (Swipe != null)
            {
                Swipe.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a finger swipes over the screen.
        /// </summary>
        public event EventHandler Swipe;

        protected virtual void OnTap()
        {
            if (Tap != null)
            {
                Tap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a finger taps on the screen.
        /// </summary>
        public event EventHandler Tap;

        protected virtual void OnTouchcancel()
        {
            if (Touchcancel != null)
            {
                Touchcancel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a touch at the screen is cancled.
        /// </summary>
        public event EventHandler Touchcancel;

        protected virtual void OnTouchend()
        {
            if (Touchend != null)
            {
                Touchend.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a touch at the screen has ended.
        /// </summary>
        public event EventHandler Touchend;

        protected virtual void OnTouchmove()
        {
            if (Touchmove != null)
            {
                Touchmove.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired during a touch at the screen.
        /// </summary>
        public event EventHandler Touchmove;

        protected virtual void OnTouchstart()
        {
            if (Touchstart != null)
            {
                Touchstart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a touch at the screen is started.
        /// </summary>
        public event EventHandler Touchstart;

    }
}
