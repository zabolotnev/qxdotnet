using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// This is the base class for all widgets.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Widget : qxDotNet.UI.Core.LayoutItem
    {

        private bool? _anonymous = false;
        private string _appearance = "widget";
        private string _backgroundColor = null;
        private bool? _blockToolTip = false;
        private qxDotNet.UI.Menu.Menu _contextMenu = null;
        private string _cursor = null;
        private object _decorator = null;
        private bool? _draggable = false;
        private bool? _droppable = false;
        private bool? _enabled = true;
        private bool? _focusable = false;
        private Font _font = null;
        private bool? _keepActive = false;
        private bool? _keepFocus = false;
        private bool? _nativeContextMenu = false;
        private decimal _opacity = 0m;
        private int _paddingBottom = 0;
        private int _paddingLeft = 0;
        private int _paddingRight = 0;
        private int _paddingTop = 0;
        private bool? _selectable = false;
        private bool? _showToolTipWhenDisabled = false;
        private int _tabIndex = 0;
        private string _textColor = null;
        private qxDotNet.UI.Tooltip.ToolTip _toolTip = null;
        private string _toolTipIcon = "";
        private string _toolTipText = "";
        private qxDotNet.VisibilityEnum _visibility = VisibilityEnum.visible;
        private int _zIndex = 10;


        /// <summary>
        /// Whether the widget is anonymous.
        /// 
        /// Anonymous widgets are ignored in the event hierarchy. This is useful
        /// for combined widgets where the internal structure do not have a custom
        /// appearance with a different styling from the element around. This is
        /// especially true for widgets like checkboxes or buttons where the text
        /// or icon are handled synchronously for state changes to the outer widget.
        /// 
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
        /// The appearance ID. This ID is used to identify the appearance theme
        /// entry to use for this widget. This controls the styling of the element.
        /// 
        /// </summary>
        public string Appearance
        {
            get
            {
                return _appearance;
            }
            set
            {
               _appearance = value;
               OnChangeAppearance();
            }
        }

        /// <summary>
        /// The background color the rendered widget.
        /// 
        /// </summary>
        public string BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }
            set
            {
               _backgroundColor = value;
               OnChangeBackgroundColor();
            }
        }

        /// <summary>
        /// Controls if a tooltip should shown or not.
        /// 
        /// </summary>
        public bool? BlockToolTip
        {
            get
            {
                return _blockToolTip;
            }
            set
            {
               _blockToolTip = value;
            }
        }

        /// <summary>
        /// Whether to show a context menu and which one
        /// 
        /// </summary>
        public qxDotNet.UI.Menu.Menu ContextMenu
        {
            get
            {
                return _contextMenu;
            }
            set
            {
               _contextMenu = value;
               OnChangeContextMenu();
            }
        }

        /// <summary>
        /// Mapping to native style property cursor.
        /// 
        /// The name of the cursor to show when the pointer is over the widget.
        /// This is any valid CSS2 cursor name defined by W3C.
        /// 
        /// The following values are possible crossbrowser:
        /// default
        /// crosshair
        /// pointer
        /// move
        /// n-resize
        /// ne-resize
        /// e-resize
        /// se-resize
        /// s-resize
        /// sw-resize
        /// w-resize
        /// nw-resize
        /// nesw-resize
        /// nwse-resize
        /// text
        /// wait
        /// help 
        /// 
        /// 
        /// </summary>
        public string Cursor
        {
            get
            {
                return _cursor;
            }
            set
            {
               _cursor = value;
            }
        }

        /// <summary>
        /// The decorator property points to an object, which is responsible
        /// for drawing the widget's decoration, e.g. border, background or shadow.
        /// 
        /// This can be a decorator object or a string pointing to a decorator
        /// defined in the decoration theme.
        /// 
        /// </summary>
        public object Decorator
        {
            get
            {
                return _decorator;
            }
            set
            {
               _decorator = value;
               OnChangeDecorator();
            }
        }

        /// <summary>
        /// Whether the widget acts as a source for drag&amp;drop operations
        /// 
        /// </summary>
        public bool? Draggable
        {
            get
            {
                return _draggable;
            }
            set
            {
               _draggable = value;
            }
        }

        /// <summary>
        /// Whether the widget acts as a target for drag&amp;drop operations
        /// 
        /// </summary>
        public bool? Droppable
        {
            get
            {
                return _droppable;
            }
            set
            {
               _droppable = value;
            }
        }

        /// <summary>
        /// Whether the widget is enabled. Disabled widgets are usually grayed out
        /// and do not process user created events. While in the disabled state most
        /// user input events are blocked. Only the {@link #pointerover} and
        /// {@link #pointerout} events will be dispatched.
        /// 
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
        /// Whether the widget is focusable e.g. rendering a focus border and visualize
        /// as active element.
        /// 
        /// See also {@link #isTabable} which allows runtime checks for
        /// isChecked or other stuff to test whether the widget is
        /// reachable via the TAB key.
        /// 
        /// </summary>
        public bool? Focusable
        {
            get
            {
                return _focusable;
            }
            set
            {
               _focusable = value;
            }
        }

        /// <summary>
        /// The widget's font. The value is either a font name defined in the font
        /// theme or an instance of {@link qx.bom.Font}.
        /// 
        /// </summary>
        public Font Font
        {
            get
            {
                return _font;
            }
            set
            {
               _font = value;
               OnChangeFont();
            }
        }

        /// <summary>
        /// If this property if enabled, the widget and all of its child widgets
        /// will never get activated. The activation keeps at the currently
        /// activated widget.
        /// 
        /// This is mainly useful for widget authors. Please use with caution!
        /// 
        /// </summary>
        public bool? KeepActive
        {
            get
            {
                return _keepActive;
            }
            set
            {
               _keepActive = value;
            }
        }

        /// <summary>
        /// If this property is enabled, the widget and all of its child widgets
        /// will never get focused. The focus keeps at the currently
        /// focused widget.
        /// 
        /// This only works for widgets which are not {@link #focusable}.
        /// 
        /// This is mainly useful for widget authors. Please use with caution!
        /// 
        /// </summary>
        public bool? KeepFocus
        {
            get
            {
                return _keepFocus;
            }
            set
            {
               _keepFocus = value;
            }
        }

        /// <summary>
        /// Whether the native context menu should be enabled for this widget. To
        /// globally enable the native context menu set the {@link #nativeContextMenu}
        /// property of the root widget ({@link qx.ui.root.Abstract}) to
        /// true.
        /// 
        /// </summary>
        public bool? NativeContextMenu
        {
            get
            {
                return _nativeContextMenu;
            }
            set
            {
               _nativeContextMenu = value;
               OnChangeNativeContextMenu();
            }
        }

        /// <summary>
        /// Mapping to native style property opacity.
        /// 
        /// The uniform opacity setting to be applied across an entire object.
        /// Behaves like the new CSS-3 Property.
        /// Any values outside the range 0.0 (fully transparent) to 1.0
        /// (fully opaque) will be clamped to this range.
        /// 
        /// </summary>
        public decimal Opacity
        {
            get
            {
                return _opacity;
            }
            set
            {
               _opacity = value;
            }
        }

        /// <summary>
        /// Padding of the widget (bottom)
        /// 
        /// </summary>
        public int PaddingBottom
        {
            get
            {
                return _paddingBottom;
            }
            set
            {
               _paddingBottom = value;
            }
        }

        /// <summary>
        /// Padding of the widget (left)
        /// 
        /// </summary>
        public int PaddingLeft
        {
            get
            {
                return _paddingLeft;
            }
            set
            {
               _paddingLeft = value;
            }
        }

        /// <summary>
        /// Padding of the widget (right)
        /// 
        /// </summary>
        public int PaddingRight
        {
            get
            {
                return _paddingRight;
            }
            set
            {
               _paddingRight = value;
            }
        }

        /// <summary>
        /// Padding of the widget (top)
        /// 
        /// </summary>
        public int PaddingTop
        {
            get
            {
                return _paddingTop;
            }
            set
            {
               _paddingTop = value;
            }
        }

        /// <summary>
        /// Whether the widget contains content which may be selected by the user.
        /// 
        /// If the value set to true the native browser selection can
        /// be used for text selection. But it is normally useful for
        /// forms fields, longer texts/documents, editors, etc.
        /// 
        /// </summary>
        public bool? Selectable
        {
            get
            {
                return _selectable;
            }
            set
            {
               _selectable = value;
               OnChangeSelectable();
            }
        }

        /// <summary>
        /// Forces to show tooltip when widget is disabled.
        /// 
        /// </summary>
        public bool? ShowToolTipWhenDisabled
        {
            get
            {
                return _showToolTipWhenDisabled;
            }
            set
            {
               _showToolTipWhenDisabled = value;
            }
        }

        /// <summary>
        /// Defines the tab index of an widget. If widgets with tab indexes are part
        /// of the current focus root these elements are sorted in first priority. Afterwards
        /// the sorting continues by rendered position, zIndex and other criteria.
        /// 
        /// Please note: The value must be between 1 and 32000.
        /// 
        /// </summary>
        public int TabIndex
        {
            get
            {
                return _tabIndex;
            }
            set
            {
               _tabIndex = value;
            }
        }

        /// <summary>
        /// The text color the rendered widget.
        /// 
        /// </summary>
        public string TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
               _textColor = value;
               OnChangeTextColor();
            }
        }

        /// <summary>
        /// Sets the tooltip instance to use for this widget. If only the tooltip
        /// text and icon have to be set its better to use the {@link #toolTipText}
        /// and {@link #toolTipIcon} properties since they use a shared tooltip
        /// instance.
        /// 
        /// If this property is set the {@link #toolTipText} and {@link #toolTipIcon}
        /// properties are ignored.
        /// 
        /// </summary>
        public qxDotNet.UI.Tooltip.ToolTip ToolTip
        {
            get
            {
                return _toolTip;
            }
            set
            {
               _toolTip = value;
            }
        }

        /// <summary>
        /// The icon URI of the widget's tooltip. This icon is displayed using a shared
        /// tooltip instance. If the tooltip must be customized beyond the tooltip text
        /// {@link #toolTipText} and the icon, the {@link #toolTip} property has to be
        /// used.
        /// 
        /// </summary>
        public string ToolTipIcon
        {
            get
            {
                return _toolTipIcon;
            }
            set
            {
               _toolTipIcon = value;
               OnChangeToolTipText();
            }
        }

        /// <summary>
        /// The text of the widget's tooltip. This text can contain HTML markup.
        /// The text is displayed using a shared tooltip instance. If the tooltip
        /// must be customized beyond the text and an icon {@link #toolTipIcon}, the
        /// {@link #toolTip} property has to be used
        /// 
        /// </summary>
        public string ToolTipText
        {
            get
            {
                return _toolTipText;
            }
            set
            {
               _toolTipText = value;
               OnChangeToolTipText();
            }
        }

        /// <summary>
        /// Controls the visibility. Valid values are:
        /// 
        /// 
        ///  visible: Render the widget
        ///  hidden: Hide the widget but don't relayout the widget's parent.
        ///  excluded: Hide the widget and relayout the parent as if the
        ///  widget was not a child of its parent.
        /// 
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
        /// The z-index property sets the stack order of an element. An element with
        /// greater stack order is always in front of another element with lower stack order.
        /// 
        /// </summary>
        public int ZIndex
        {
            get
            {
                return _zIndex;
            }
            set
            {
               _zIndex = value;
               OnChangeZIndex();
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.Widget";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("anonymous", _anonymous, false);
            state.SetPropertyValue("appearance", _appearance, "widget");
            state.SetPropertyValue("backgroundColor", _backgroundColor, null);
            state.SetPropertyValue("blockToolTip", _blockToolTip, false);
            state.SetPropertyValue("contextMenu", _contextMenu, null);
            state.SetPropertyValue("cursor", _cursor, null);
            state.SetPropertyValue("decorator", _decorator, null);
            state.SetPropertyValue("draggable", _draggable, false);
            state.SetPropertyValue("droppable", _droppable, false);
            state.SetPropertyValue("enabled", _enabled, true);
            state.SetPropertyValue("focusable", _focusable, false);
            state.SetPropertyValue("font", _font, null);
            state.SetPropertyValue("keepActive", _keepActive, false);
            state.SetPropertyValue("keepFocus", _keepFocus, false);
            state.SetPropertyValue("nativeContextMenu", _nativeContextMenu, false);
            state.SetPropertyValue("opacity", _opacity, 0m);
            state.SetPropertyValue("paddingBottom", _paddingBottom, 0);
            state.SetPropertyValue("paddingLeft", _paddingLeft, 0);
            state.SetPropertyValue("paddingRight", _paddingRight, 0);
            state.SetPropertyValue("paddingTop", _paddingTop, 0);
            state.SetPropertyValue("selectable", _selectable, false);
            state.SetPropertyValue("showToolTipWhenDisabled", _showToolTipWhenDisabled, false);
            state.SetPropertyValue("tabIndex", _tabIndex, 0);
            state.SetPropertyValue("textColor", _textColor, null);
            state.SetPropertyValue("toolTip", _toolTip, null);
            state.SetPropertyValue("toolTipIcon", _toolTipIcon, "");
            state.SetPropertyValue("toolTipText", _toolTipText, "");
            state.SetPropertyValue("visibility", _visibility, VisibilityEnum.visible);
            state.SetPropertyValue("zIndex", _zIndex, 10);

            if (Activated != null)
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
            if (Capture != null)
            {
                state.SetEvent("capture", false);
            }
            if (Click != null)
            {
                state.SetEvent("click", false);
            }
            if (Contextmenu != null)
            {
                state.SetEvent("contextmenu", false);
            }
            if (CreateChildControl != null)
            {
                state.SetEvent("createChildControl", false);
            }
            if (Dblclick != null)
            {
                state.SetEvent("dblclick", false);
            }
            if (Dbltap != null)
            {
                state.SetEvent("dbltap", false);
            }
            if (Deactivate != null)
            {
                state.SetEvent("deactivate", false);
            }
            if (Disappear != null)
            {
                state.SetEvent("disappear", false);
            }
            if (Drag != null)
            {
                state.SetEvent("drag", false);
            }
            if (Dragchange != null)
            {
                state.SetEvent("dragchange", false);
            }
            if (Dragend != null)
            {
                state.SetEvent("dragend", false);
            }
            if (Dragleave != null)
            {
                state.SetEvent("dragleave", false);
            }
            if (Dragover != null)
            {
                state.SetEvent("dragover", false);
            }
            if (Dragstart != null)
            {
                state.SetEvent("dragstart", false);
            }
            if (Drop != null)
            {
                state.SetEvent("drop", false);
            }
            if (Droprequest != null)
            {
                state.SetEvent("droprequest", false);
            }
            if (Focused != null)
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
            if (Losecapture != null)
            {
                state.SetEvent("losecapture", false);
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
            if (Move != null)
            {
                state.SetEvent("move", false);
            }
            if (Pinch != null)
            {
                state.SetEvent("pinch", false);
            }
            if (Pointercancel != null)
            {
                state.SetEvent("pointercancel", false);
            }
            if (Pointerdown != null)
            {
                state.SetEvent("pointerdown", false);
            }
            if (Pointermove != null)
            {
                state.SetEvent("pointermove", false);
            }
            if (Pointerout != null)
            {
                state.SetEvent("pointerout", false);
            }
            if (Pointerover != null)
            {
                state.SetEvent("pointerover", false);
            }
            if (Pointerup != null)
            {
                state.SetEvent("pointerup", false);
            }
            if (Resize != null)
            {
                state.SetEvent("resize", false);
            }
            if (Roll != null)
            {
                state.SetEvent("roll", false);
            }
            if (Rotate != null)
            {
                state.SetEvent("rotate", false);
            }
            if (Swipe != null)
            {
                state.SetEvent("swipe", false);
            }
            if (SyncAppearance != null)
            {
                state.SetEvent("syncAppearance", false);
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
            if (Track != null)
            {
                state.SetEvent("track", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "activate")
            {
                OnActivated();
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
            if (eventName == "capture")
            {
                OnCapture();
            }
            if (eventName == "click")
            {
                OnClick();
            }
            if (eventName == "contextmenu")
            {
                OnContextmenu();
            }
            if (eventName == "createChildControl")
            {
                OnCreateChildControl();
            }
            if (eventName == "dblclick")
            {
                OnDblclick();
            }
            if (eventName == "dbltap")
            {
                OnDbltap();
            }
            if (eventName == "deactivate")
            {
                OnDeactivate();
            }
            if (eventName == "disappear")
            {
                OnDisappear();
            }
            if (eventName == "drag")
            {
                OnDrag();
            }
            if (eventName == "dragchange")
            {
                OnDragchange();
            }
            if (eventName == "dragend")
            {
                OnDragend();
            }
            if (eventName == "dragleave")
            {
                OnDragleave();
            }
            if (eventName == "dragover")
            {
                OnDragover();
            }
            if (eventName == "dragstart")
            {
                OnDragstart();
            }
            if (eventName == "drop")
            {
                OnDrop();
            }
            if (eventName == "droprequest")
            {
                OnDroprequest();
            }
            if (eventName == "focus")
            {
                OnFocused();
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
            if (eventName == "losecapture")
            {
                OnLosecapture();
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
            if (eventName == "move")
            {
                OnMove();
            }
            if (eventName == "pinch")
            {
                OnPinch();
            }
            if (eventName == "pointercancel")
            {
                OnPointercancel();
            }
            if (eventName == "pointerdown")
            {
                OnPointerdown();
            }
            if (eventName == "pointermove")
            {
                OnPointermove();
            }
            if (eventName == "pointerout")
            {
                OnPointerout();
            }
            if (eventName == "pointerover")
            {
                OnPointerover();
            }
            if (eventName == "pointerup")
            {
                OnPointerup();
            }
            if (eventName == "resize")
            {
                OnResize();
            }
            if (eventName == "roll")
            {
                OnRoll();
            }
            if (eventName == "rotate")
            {
                OnRotate();
            }
            if (eventName == "swipe")
            {
                OnSwipe();
            }
            if (eventName == "syncAppearance")
            {
                OnSyncAppearance();
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
            if (eventName == "track")
            {
                OnTrack();
            }
        }

        /// <summary>
        /// Raises event 'Activate'
        /// </summary>
        protected virtual void OnActivated()
        {
            if (Activated != null)
            {
                Activated.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget gets active (receives keyboard events etc.)
        /// 
        /// </summary>
        public event EventHandler Activated;

        /// <summary>
        /// Raises event 'Appear'
        /// </summary>
        protected virtual void OnAppear()
        {
            if (Appear != null)
            {
                Appear.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the widget appears on the screen.
        /// 
        /// </summary>
        public event EventHandler Appear;

        /// <summary>
        /// Raises event 'BeforeContextmenuOpen'
        /// </summary>
        protected virtual void OnBeforeContextmenuOpen()
        {
            if (BeforeContextmenuOpen != null)
            {
                BeforeContextmenuOpen.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired before the context menu is opened.
        /// 
        /// </summary>
        public event EventHandler BeforeContextmenuOpen;

        /// <summary>
        /// Raises event 'Blur'
        /// </summary>
        protected virtual void OnBlur()
        {
            if (Blur != null)
            {
                Blur.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired when the widget gets blurred. Only widgets which are
        /// {@link #focusable} receive this event.
        /// 
        /// </summary>
        public event EventHandler Blur;

        /// <summary>
        /// Raises event 'Capture'
        /// </summary>
        protected virtual void OnCapture()
        {
            if (Capture != null)
            {
                Capture.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the widget becomes the capturing widget by a call to {@link #capture}.
        /// 
        /// </summary>
        public event EventHandler Capture;

        /// <summary>
        /// Raises event 'ChangeAppearance'
        /// </summary>
        protected virtual void OnChangeAppearance()
        {
            if (ChangeAppearance != null)
            {
                ChangeAppearance.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #appearance}.
        /// </summary>
        public event EventHandler ChangeAppearance;

        /// <summary>
        /// Raises event 'ChangeBackgroundColor'
        /// </summary>
        protected virtual void OnChangeBackgroundColor()
        {
            if (ChangeBackgroundColor != null)
            {
                ChangeBackgroundColor.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #backgroundColor}.
        /// </summary>
        public event EventHandler ChangeBackgroundColor;

        /// <summary>
        /// Raises event 'ChangeContextMenu'
        /// </summary>
        protected virtual void OnChangeContextMenu()
        {
            if (ChangeContextMenu != null)
            {
                ChangeContextMenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #contextMenu}.
        /// </summary>
        public event EventHandler ChangeContextMenu;

        /// <summary>
        /// Raises event 'ChangeDecorator'
        /// </summary>
        protected virtual void OnChangeDecorator()
        {
            if (ChangeDecorator != null)
            {
                ChangeDecorator.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #decorator}.
        /// </summary>
        public event EventHandler ChangeDecorator;

        /// <summary>
        /// Raises event 'ChangeEnabled'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeFont'
        /// </summary>
        protected virtual void OnChangeFont()
        {
            if (ChangeFont != null)
            {
                ChangeFont.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #font}.
        /// </summary>
        public event EventHandler ChangeFont;

        /// <summary>
        /// Raises event 'ChangeNativeContextMenu'
        /// </summary>
        protected virtual void OnChangeNativeContextMenu()
        {
            if (ChangeNativeContextMenu != null)
            {
                ChangeNativeContextMenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #nativeContextMenu}.
        /// </summary>
        public event EventHandler ChangeNativeContextMenu;

        /// <summary>
        /// Raises event 'ChangeSelectable'
        /// </summary>
        protected virtual void OnChangeSelectable()
        {
            if (ChangeSelectable != null)
            {
                ChangeSelectable.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #selectable}.
        /// </summary>
        public event EventHandler ChangeSelectable;

        /// <summary>
        /// Raises event 'ChangeTextColor'
        /// </summary>
        protected virtual void OnChangeTextColor()
        {
            if (ChangeTextColor != null)
            {
                ChangeTextColor.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #textColor}.
        /// </summary>
        public event EventHandler ChangeTextColor;

        /// <summary>
        /// Raises event 'ChangeToolTipText'
        /// </summary>
        protected virtual void OnChangeToolTipText()
        {
            if (ChangeToolTipText != null)
            {
                ChangeToolTipText.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #toolTipText}.
        /// </summary>
        public event EventHandler ChangeToolTipText;

        /// <summary>
        /// Raises event 'ChangeVisibility'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeZIndex'
        /// </summary>
        protected virtual void OnChangeZIndex()
        {
            if (ChangeZIndex != null)
            {
                ChangeZIndex.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #zIndex}.
        /// </summary>
        public event EventHandler ChangeZIndex;

        /// <summary>
        /// Raises event 'Click'
        /// </summary>
        protected virtual void OnClick()
        {
            if (Click != null)
            {
                Click.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Widget is clicked using left or middle button.
        ///  {@link qx.event.type.Mouse#getButton} for more details.
        /// 
        /// </summary>
        public event EventHandler Click;

        /// <summary>
        /// Raises event 'Contextmenu'
        /// </summary>
        protected virtual void OnContextmenu()
        {
            if (Contextmenu != null)
            {
                Contextmenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Widget is clicked using the right mouse button.
        /// 
        /// </summary>
        public event EventHandler Contextmenu;

        /// <summary>
        /// Raises event 'CreateChildControl'
        /// </summary>
        protected virtual void OnCreateChildControl()
        {
            if (CreateChildControl != null)
            {
                CreateChildControl.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the creation of a child control. The passed data is the
        /// newly created child widget.
        /// 
        /// </summary>
        public event EventHandler CreateChildControl;

        /// <summary>
        /// Raises event 'Dblclick'
        /// </summary>
        protected virtual void OnDblclick()
        {
            if (Dblclick != null)
            {
                Dblclick.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Widget is double clicked using left or middle button.
        ///  {@link qx.event.type.Mouse#getButton} for more details.
        /// 
        /// </summary>
        public event EventHandler Dblclick;

        /// <summary>
        /// Raises event 'Dbltap'
        /// </summary>
        protected virtual void OnDbltap()
        {
            if (Dbltap != null)
            {
                Dbltap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a pointer taps twice on the screen.
        /// 
        /// </summary>
        public event EventHandler Dbltap;

        /// <summary>
        /// Raises event 'Deactivate'
        /// </summary>
        protected virtual void OnDeactivate()
        {
            if (Deactivate != null)
            {
                Deactivate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget gets inactive
        /// 
        /// </summary>
        public event EventHandler Deactivate;

        /// <summary>
        /// Raises event 'Disappear'
        /// </summary>
        protected virtual void OnDisappear()
        {
            if (Disappear != null)
            {
                Disappear.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the widget disappears from the screen.
        /// 
        /// </summary>
        public event EventHandler Disappear;

        /// <summary>
        /// Raises event 'Drag'
        /// </summary>
        protected virtual void OnDrag()
        {
            if (Drag != null)
            {
                Drag.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired during the drag. Contains the current pointer coordinates
        /// using {@link qx.event.type.Drag#getDocumentLeft} and
        /// {@link qx.event.type.Drag#getDocumentTop}
        /// 
        /// Modeled after the WHATWG specification of Drag&amp;Drop:
        /// http://www.whatwg.org/specs/web-apps/current-work/#dnd
        /// 
        /// </summary>
        public event EventHandler Drag;

        /// <summary>
        /// Raises event 'Dragchange'
        /// </summary>
        protected virtual void OnDragchange()
        {
            if (Dragchange != null)
            {
                Dragchange.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the drag configuration has been modified e.g. the user
        /// pressed a key which changed the selected action. This event will be
        /// fired on the draggable and the droppable element. In case of the
        /// droppable element, you can cancel the event and prevent a drop based on
        /// e.g. the current action.
        /// 
        /// </summary>
        public event EventHandler Dragchange;

        /// <summary>
        /// Raises event 'Dragend'
        /// </summary>
        protected virtual void OnDragend()
        {
            if (Dragend != null)
            {
                Dragend.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on the source (drag) target every time a drag session was ended.
        /// 
        /// </summary>
        public event EventHandler Dragend;

        /// <summary>
        /// Raises event 'Dragleave'
        /// </summary>
        protected virtual void OnDragleave()
        {
            if (Dragleave != null)
            {
                Dragleave.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on a potential drop target when leaving it.
        /// 
        /// Modeled after the WHATWG specification of Drag&amp;Drop:
        /// http://www.whatwg.org/specs/web-apps/current-work/#dnd
        /// 
        /// </summary>
        public event EventHandler Dragleave;

        /// <summary>
        /// Raises event 'Dragover'
        /// </summary>
        protected virtual void OnDragover()
        {
            if (Dragover != null)
            {
                Dragover.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on a potential drop target when reaching it via the pointer.
        /// This event can be canceled if none of the incoming data types
        /// are supported.
        /// 
        /// Modeled after the WHATWG specification of Drag&amp;Drop:
        /// http://www.whatwg.org/specs/web-apps/current-work/#dnd
        /// 
        /// </summary>
        public event EventHandler Dragover;

        /// <summary>
        /// Raises event 'Dragstart'
        /// </summary>
        protected virtual void OnDragstart()
        {
            if (Dragstart != null)
            {
                Dragstart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Initiate the drag-and-drop operation. This event is cancelable
        /// when the drag operation is currently not allowed/possible.
        /// 
        /// Modeled after the WHATWG specification of Drag&amp;Drop:
        /// http://www.whatwg.org/specs/web-apps/current-work/#dnd
        /// 
        /// </summary>
        public event EventHandler Dragstart;

        /// <summary>
        /// Raises event 'Drop'
        /// </summary>
        protected virtual void OnDrop()
        {
            if (Drop != null)
            {
                Drop.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on the drop target when the drag&amp;drop action is finished
        /// successfully. This event is normally used to transfer the data
        /// from the drag to the drop target.
        /// 
        /// Modeled after the WHATWG specification of Drag&amp;Drop:
        /// http://www.whatwg.org/specs/web-apps/current-work/#dnd
        /// 
        /// </summary>
        public event EventHandler Drop;

        /// <summary>
        /// Raises event 'Droprequest'
        /// </summary>
        protected virtual void OnDroprequest()
        {
            if (Droprequest != null)
            {
                Droprequest.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the drop was successfully done and the target widget
        /// is now asking for data. The listener should transfer the data,
        /// respecting the selected action, to the event. This can be done using
        /// the event's {@link qx.event.type.Drag#addData} method.
        /// 
        /// </summary>
        public event EventHandler Droprequest;

        /// <summary>
        /// Raises event 'Focus'
        /// </summary>
        protected virtual void OnFocused()
        {
            if (Focused != null)
            {
                Focused.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired when the widget gets focused. Only widgets which are
        /// {@link #focusable} receive this event.
        /// 
        /// </summary>
        public event EventHandler Focused;

        /// <summary>
        /// Raises event 'Focusin'
        /// </summary>
        protected virtual void OnFocusin()
        {
            if (Focusin != null)
            {
                Focusin.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget itself or any child of the widget receive the focus.
        /// 
        /// </summary>
        public event EventHandler Focusin;

        /// <summary>
        /// Raises event 'Focusout'
        /// </summary>
        protected virtual void OnFocusout()
        {
            if (Focusout != null)
            {
                Focusout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// When the widget itself or any child of the widget lost the focus.
        /// 
        /// </summary>
        public event EventHandler Focusout;

        /// <summary>
        /// Raises event 'Keydown'
        /// </summary>
        protected virtual void OnKeydown()
        {
            if (Keydown != null)
            {
                Keydown.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event if fired if a keyboard key is pressed down. This event is
        /// only fired once if the user keeps the key pressed for a while.
        /// 
        /// </summary>
        public event EventHandler Keydown;

        /// <summary>
        /// Raises event 'Keyinput'
        /// </summary>
        protected virtual void OnKeyinput()
        {
            if (Keyinput != null)
            {
                Keyinput.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired if the pressed key or keys result in a printable
        /// character. Since the character is not necessarily associated with a
        /// single physical key press, the event does not have a key identifier
        /// getter. This event gets repeated if the user keeps pressing the key(s).
        /// 
        /// The unicode code of the pressed key can be read using
        /// {@link qx.event.type.KeyInput#getCharCode}.
        /// 
        /// </summary>
        public event EventHandler Keyinput;

        /// <summary>
        /// Raises event 'Keypress'
        /// </summary>
        protected virtual void OnKeypress()
        {
            if (Keypress != null)
            {
                Keypress.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired any time a key is pressed. It will be repeated if
        /// the user keeps the key pressed. The pressed key can be determined using
        /// {@link qx.event.type.KeySequence#getKeyIdentifier}.
        /// 
        /// </summary>
        public event EventHandler Keypress;

        /// <summary>
        /// Raises event 'Keyup'
        /// </summary>
        protected virtual void OnKeyup()
        {
            if (Keyup != null)
            {
                Keyup.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event if fired if a keyboard key is released.
        /// 
        /// </summary>
        public event EventHandler Keyup;

        /// <summary>
        /// Raises event 'Longtap'
        /// </summary>
        protected virtual void OnLongtap()
        {
            if (Longtap != null)
            {
                Longtap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a pointer holds on the screen.
        /// 
        /// </summary>
        public event EventHandler Longtap;

        /// <summary>
        /// Raises event 'Losecapture'
        /// </summary>
        protected virtual void OnLosecapture()
        {
            if (Losecapture != null)
            {
                Losecapture.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the widget looses the capturing mode by a call to
        /// {@link #releaseCapture} or a mouse click.
        /// 
        /// </summary>
        public event EventHandler Losecapture;

        /// <summary>
        /// Raises event 'Mousedown'
        /// </summary>
        protected virtual void OnMousedown()
        {
            if (Mousedown != null)
            {
                Mousedown.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Mouse button is pressed on the widget.
        /// 
        /// </summary>
        public event EventHandler Mousedown;

        /// <summary>
        /// Raises event 'Mousemove'
        /// </summary>
        protected virtual void OnMousemove()
        {
            if (Mousemove != null)
            {
                Mousemove.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse cursor moves over the widget.
        ///  The data property of the event contains the widget's computed location
        ///  and dimension as returned by {@link qx.ui.core.LayoutItem#getBounds}
        /// 
        /// </summary>
        public event EventHandler Mousemove;

        /// <summary>
        /// Raises event 'Mouseout'
        /// </summary>
        protected virtual void OnMouseout()
        {
            if (Mouseout != null)
            {
                Mouseout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse cursor leaves widget.
        /// 
        /// Note: This event is also dispatched if the widget is disabled!
        /// 
        /// </summary>
        public event EventHandler Mouseout;

        /// <summary>
        /// Raises event 'Mouseover'
        /// </summary>
        protected virtual void OnMouseover()
        {
            if (Mouseover != null)
            {
                Mouseover.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse cursor enters the widget.
        /// 
        /// Note: This event is also dispatched if the widget is disabled!
        /// 
        /// </summary>
        public event EventHandler Mouseover;

        /// <summary>
        /// Raises event 'Mouseup'
        /// </summary>
        protected virtual void OnMouseup()
        {
            if (Mouseup != null)
            {
                Mouseup.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Mouse button is released on the widget.
        /// 
        /// </summary>
        public event EventHandler Mouseup;

        /// <summary>
        /// Raises event 'Mousewheel'
        /// </summary>
        protected virtual void OnMousewheel()
        {
            if (Mousewheel != null)
            {
                Mousewheel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the mouse wheel is used over the widget.
        /// 
        /// </summary>
        public event EventHandler Mousewheel;

        /// <summary>
        /// Raises event 'Move'
        /// </summary>
        protected virtual void OnMove()
        {
            if (Move != null)
            {
                Move.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on move (after layout) of the widget.
        /// The data property of the event contains the widget's computed location
        /// and dimension as returned by {@link qx.ui.core.LayoutItem#getBounds}
        /// 
        /// </summary>
        public event EventHandler Move;

        /// <summary>
        /// Raises event 'Pinch'
        /// </summary>
        protected virtual void OnPinch()
        {
            if (Pinch != null)
            {
                Pinch.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when two pointers performing a pinch in/out gesture on the screen.
        /// 
        /// </summary>
        public event EventHandler Pinch;

        /// <summary>
        /// Raises event 'Pointercancel'
        /// </summary>
        protected virtual void OnPointercancel()
        {
            if (Pointercancel != null)
            {
                Pointercancel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a pointer (mouse/touch/pen) action is canceled.
        /// 
        /// </summary>
        public event EventHandler Pointercancel;

        /// <summary>
        /// Raises event 'Pointerdown'
        /// </summary>
        protected virtual void OnPointerdown()
        {
            if (Pointerdown != null)
            {
                Pointerdown.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a pointer (mouse/touch/pen) button is pressed or
        /// a finger touches the widget.
        /// 
        /// </summary>
        public event EventHandler Pointerdown;

        /// <summary>
        /// Raises event 'Pointermove'
        /// </summary>
        protected virtual void OnPointermove()
        {
            if (Pointermove != null)
            {
                Pointermove.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a pointer (mouse/touch/pen) moves or changes any of it's values.
        /// 
        /// </summary>
        public event EventHandler Pointermove;

        /// <summary>
        /// Raises event 'Pointerout'
        /// </summary>
        protected virtual void OnPointerout()
        {
            if (Pointerout != null)
            {
                Pointerout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a pointer (mouse/touch/pen) leaves this widget.
        /// 
        /// </summary>
        public event EventHandler Pointerout;

        /// <summary>
        /// Raises event 'Pointerover'
        /// </summary>
        protected virtual void OnPointerover()
        {
            if (Pointerover != null)
            {
                Pointerover.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a pointer (mouse/touch/pen) hovers the widget.
        /// 
        /// </summary>
        public event EventHandler Pointerover;

        /// <summary>
        /// Raises event 'Pointerup'
        /// </summary>
        protected virtual void OnPointerup()
        {
            if (Pointerup != null)
            {
                Pointerup.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if all pointer (mouse/touch/pen) buttons are released or
        /// the finger is lifted from the widget.
        /// 
        /// </summary>
        public event EventHandler Pointerup;

        /// <summary>
        /// Raises event 'Resize'
        /// </summary>
        protected virtual void OnResize()
        {
            if (Resize != null)
            {
                Resize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on resize (after layout) of the widget.
        /// The data property of the event contains the widget's computed location
        /// and dimension as returned by {@link qx.ui.core.LayoutItem#getBounds}
        /// 
        /// </summary>
        public event EventHandler Resize;

        /// <summary>
        /// Raises event 'Roll'
        /// </summary>
        protected virtual void OnRoll()
        {
            if (Roll != null)
            {
                Roll.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when an active pointer moves on the screen or the mouse wheel is used.
        /// 
        /// </summary>
        public event EventHandler Roll;

        /// <summary>
        /// Raises event 'Rotate'
        /// </summary>
        protected virtual void OnRotate()
        {
            if (Rotate != null)
            {
                Rotate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when two pointers performing a rotate gesture on the screen.
        /// 
        /// </summary>
        public event EventHandler Rotate;

        /// <summary>
        /// Raises event 'Swipe'
        /// </summary>
        protected virtual void OnSwipe()
        {
            if (Swipe != null)
            {
                Swipe.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a pointer swipes over the screen.
        /// 
        /// </summary>
        public event EventHandler Swipe;

        /// <summary>
        /// Raises event 'SyncAppearance'
        /// </summary>
        protected virtual void OnSyncAppearance()
        {
            if (SyncAppearance != null)
            {
                SyncAppearance.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the appearance has been applied. This happens before the
        /// widget becomes visible, on state and appearance changes. The data field
        /// contains the state map. This can be used to react on state changes or to
        /// read properties set by the appearance.
        /// 
        /// </summary>
        public event EventHandler SyncAppearance;

        /// <summary>
        /// Raises event 'Tap'
        /// </summary>
        protected virtual void OnTap()
        {
            if (Tap != null)
            {
                Tap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a pointer taps on the screen.
        /// 
        /// </summary>
        public event EventHandler Tap;

        /// <summary>
        /// Raises event 'Touchcancel'
        /// </summary>
        protected virtual void OnTouchcancel()
        {
            if (Touchcancel != null)
            {
                Touchcancel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a touch at the screen is canceled.
        /// 
        /// </summary>
        public event EventHandler Touchcancel;

        /// <summary>
        /// Raises event 'Touchend'
        /// </summary>
        protected virtual void OnTouchend()
        {
            if (Touchend != null)
            {
                Touchend.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a touch at the screen has ended.
        /// 
        /// </summary>
        public event EventHandler Touchend;

        /// <summary>
        /// Raises event 'Touchmove'
        /// </summary>
        protected virtual void OnTouchmove()
        {
            if (Touchmove != null)
            {
                Touchmove.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired during a touch at the screen.
        /// 
        /// </summary>
        public event EventHandler Touchmove;

        /// <summary>
        /// Raises event 'Touchstart'
        /// </summary>
        protected virtual void OnTouchstart()
        {
            if (Touchstart != null)
            {
                Touchstart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if a touch at the screen is started.
        /// 
        /// </summary>
        public event EventHandler Touchstart;

        /// <summary>
        /// Raises event 'Track'
        /// </summary>
        protected virtual void OnTrack()
        {
            if (Track != null)
            {
                Track.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when an active pointer moves on the screen (after pointerdown till pointerup).
        /// 
        /// </summary>
        public event EventHandler Track;

    }
}
