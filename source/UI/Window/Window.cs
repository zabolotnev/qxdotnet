using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Window
{
    /// <summary>
    /// A window widget  More information can be found in the package description {@link qx.ui.window}.
    /// </summary>
    public partial class Window : qxDotNet.UI.Container.Composite
    {

        private bool? _active = false;
        private bool? _allowClose = true;
        private bool? _allowMaximize = true;
        private bool? _allowMinimize = true;
        private bool? _alwaysOnTop = false;
        private string _caption = "";
        private string _icon = "";
        private bool? _modal = false;
        private bool? _showClose = true;
        private bool? _showMaximize = true;
        private bool? _showMinimize = true;
        private bool? _showStatusbar = false;
        private string _status = "";
        private qxDotNet.UI.Layout.Abstract _layout = null;
        private bool? _resizableBottom = true;
        private bool? _resizableLeft = true;
        private bool? _resizableRight = true;
        private bool? _resizableTop = true;
        private int _resizeSensitivity = 5;
        private bool? _useResizeFrame = true;
        private bool? _movable = true;
        private bool? _useMoveFrame = false;
        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;


        /// <summary>
        /// If the window is active, only one window in a single qx.ui.window.Manager could  have set this to true at the same time.
        /// </summary>
        public bool? Active
        {
            get
            {
                return _active;
            }
            set
            {
               _active = value;
               OnChangeActive();
            }
        }

        /// <summary>
        /// Should the user have the ability to close the window
        /// </summary>
        public bool? AllowClose
        {
            get
            {
                return _allowClose;
            }
            set
            {
               _allowClose = value;
            }
        }

        /// <summary>
        /// Should the user have the ability to maximize the window
        /// </summary>
        public bool? AllowMaximize
        {
            get
            {
                return _allowMaximize;
            }
            set
            {
               _allowMaximize = value;
            }
        }

        /// <summary>
        /// Should the user have the ability to minimize the window
        /// </summary>
        public bool? AllowMinimize
        {
            get
            {
                return _allowMinimize;
            }
            set
            {
               _allowMinimize = value;
            }
        }

        /// <summary>
        /// Should the window be always on top
        /// </summary>
        public bool? AlwaysOnTop
        {
            get
            {
                return _alwaysOnTop;
            }
            set
            {
               _alwaysOnTop = value;
               OnChangeAlwaysOnTop();
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
            }
        }

        /// <summary>
        /// The icon of the caption
        /// </summary>
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
               _icon = value;
               OnChangeIcon();
            }
        }

        /// <summary>
        /// Should the window be modal (this disables minimize and maximize buttons)
        /// </summary>
        public bool? Modal
        {
            get
            {
                return _modal;
            }
            set
            {
               _modal = value;
               OnChangeModal();
            }
        }

        /// <summary>
        /// Should the close button be shown
        /// </summary>
        public bool? ShowClose
        {
            get
            {
                return _showClose;
            }
            set
            {
               _showClose = value;
            }
        }

        /// <summary>
        /// Should the maximize button be shown
        /// </summary>
        public bool? ShowMaximize
        {
            get
            {
                return _showMaximize;
            }
            set
            {
               _showMaximize = value;
            }
        }

        /// <summary>
        /// Should the minimize button be shown
        /// </summary>
        public bool? ShowMinimize
        {
            get
            {
                return _showMinimize;
            }
            set
            {
               _showMinimize = value;
            }
        }

        /// <summary>
        /// Should the statusbar be shown
        /// </summary>
        public bool? ShowStatusbar
        {
            get
            {
                return _showStatusbar;
            }
            set
            {
               _showStatusbar = value;
            }
        }

        /// <summary>
        /// The text of the statusbar
        /// </summary>
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
               _status = value;
               OnChangeStatus();
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
        /// Whether the bottom edge is resizable
        /// </summary>
        public bool? ResizableBottom
        {
            get
            {
                return _resizableBottom;
            }
            set
            {
               _resizableBottom = value;
            }
        }

        /// <summary>
        /// Whether the left edge is resizable
        /// </summary>
        public bool? ResizableLeft
        {
            get
            {
                return _resizableLeft;
            }
            set
            {
               _resizableLeft = value;
            }
        }

        /// <summary>
        /// Whether the right edge is resizable
        /// </summary>
        public bool? ResizableRight
        {
            get
            {
                return _resizableRight;
            }
            set
            {
               _resizableRight = value;
            }
        }

        /// <summary>
        /// Whether the top edge is resizable
        /// </summary>
        public bool? ResizableTop
        {
            get
            {
                return _resizableTop;
            }
            set
            {
               _resizableTop = value;
            }
        }

        /// <summary>
        /// The tolerance to activate resizing
        /// </summary>
        public int ResizeSensitivity
        {
            get
            {
                return _resizeSensitivity;
            }
            set
            {
               _resizeSensitivity = value;
            }
        }

        /// <summary>
        /// Whether a frame replacement should be used during the resize sequence
        /// </summary>
        public bool? UseResizeFrame
        {
            get
            {
                return _useResizeFrame;
            }
            set
            {
               _useResizeFrame = value;
            }
        }

        /// <summary>
        /// Whether the widget is movable
        /// </summary>
        public bool? Movable
        {
            get
            {
                return _movable;
            }
            set
            {
               _movable = value;
            }
        }

        /// <summary>
        /// Whether to use a frame instead of the original widget during move sequences
        /// </summary>
        public bool? UseMoveFrame
        {
            get
            {
                return _useMoveFrame;
            }
            set
            {
               _useMoveFrame = value;
            }
        }

        /// <summary>
        /// Bottom padding of the content pane
        /// </summary>
        public int ContentPaddingBottom
        {
            get
            {
                return _contentPaddingBottom;
            }
            set
            {
               _contentPaddingBottom = value;
            }
        }

        /// <summary>
        /// Left padding of the content pane
        /// </summary>
        public int ContentPaddingLeft
        {
            get
            {
                return _contentPaddingLeft;
            }
            set
            {
               _contentPaddingLeft = value;
            }
        }

        /// <summary>
        /// Right padding of the content pane
        /// </summary>
        public int ContentPaddingRight
        {
            get
            {
                return _contentPaddingRight;
            }
            set
            {
               _contentPaddingRight = value;
            }
        }

        /// <summary>
        /// Top padding of the content pane
        /// </summary>
        public int ContentPaddingTop
        {
            get
            {
                return _contentPaddingTop;
            }
            set
            {
               _contentPaddingTop = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.window.Window";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            if (_closed) return;
            base.Render(state);
            state.SetPropertyValue("active", _active, false);
            state.SetPropertyValue("allowClose", _allowClose, true);
            state.SetPropertyValue("allowMaximize", _allowMaximize, true);
            state.SetPropertyValue("allowMinimize", _allowMinimize, true);
            state.SetPropertyValue("alwaysOnTop", _alwaysOnTop, false);
            state.SetPropertyValue("caption", _caption, "");
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("modal", _modal, false);
            state.SetPropertyValue("showClose", _showClose, true);
            state.SetPropertyValue("showMaximize", _showMaximize, true);
            state.SetPropertyValue("showMinimize", _showMinimize, true);
            state.SetPropertyValue("showStatusbar", _showStatusbar, false);
            state.SetPropertyValue("status", _status, "");
            state.SetPropertyValue("layout", _layout, null);
            state.SetPropertyValue("resizableBottom", _resizableBottom, true);
            state.SetPropertyValue("resizableLeft", _resizableLeft, true);
            state.SetPropertyValue("resizableRight", _resizableRight, true);
            state.SetPropertyValue("resizableTop", _resizableTop, true);
            state.SetPropertyValue("resizeSensitivity", _resizeSensitivity, 5);
            state.SetPropertyValue("useResizeFrame", _useResizeFrame, true);
            state.SetPropertyValue("movable", _movable, true);
            state.SetPropertyValue("useMoveFrame", _useMoveFrame, false);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);

            if (BeforeClose != null)
            {
                state.SetEvent("beforeClose", false);
            }
            if (BeforeMaximize != null)
            {
                state.SetEvent("beforeMaximize", false);
            }
            if (BeforeMinimize != null)
            {
                state.SetEvent("beforeMinimize", false);
            }
            if (BeforeRestore != null)
            {
                state.SetEvent("beforeRestore", false);
            }
            if (Close != null)
            {
                state.SetEvent("close", true);
            }
            if (Maximize != null)
            {
                state.SetEvent("maximize", false);
            }
            if (Minimize != null)
            {
                state.SetEvent("minimize", false);
            }
            if (Restore != null)
            {
                state.SetEvent("restore", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "beforeClose")
            {
                OnBeforeClose();
            }
            if (eventName == "beforeMaximize")
            {
                OnBeforeMaximize();
            }
            if (eventName == "beforeMinimize")
            {
                OnBeforeMinimize();
            }
            if (eventName == "beforeRestore")
            {
                OnBeforeRestore();
            }
            if (eventName == "close")
            {
                OnClose();
            }
            if (eventName == "maximize")
            {
                OnMaximize();
            }
            if (eventName == "minimize")
            {
                OnMinimize();
            }
            if (eventName == "restore")
            {
                OnRestore();
            }
        }

        protected virtual void OnBeforeClose()
        {
            if (BeforeClose != null)
            {
                BeforeClose.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired before the window is closed.  The close action can be prevented by calling {@link qx.event.type.Event#preventDefault} on the event object
        /// </summary>
        public event EventHandler BeforeClose;

        protected virtual void OnBeforeMaximize()
        {
            if (BeforeMaximize != null)
            {
                BeforeMaximize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired before the window is maximize.  The maximize action can be prevented by calling {@link qx.event.type.Event#preventDefault} on the event object
        /// </summary>
        public event EventHandler BeforeMaximize;

        protected virtual void OnBeforeMinimize()
        {
            if (BeforeMinimize != null)
            {
                BeforeMinimize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired before the window is minimize.  The minimize action can be prevented by calling {@link qx.event.type.Event#preventDefault} on the event object
        /// </summary>
        public event EventHandler BeforeMinimize;

        protected virtual void OnBeforeRestore()
        {
            if (BeforeRestore != null)
            {
                BeforeRestore.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired before the window is restored from a minimized or maximized state.  The restored action can be prevented by calling {@link qx.event.type.Event#preventDefault} on the event object
        /// </summary>
        public event EventHandler BeforeRestore;

        protected virtual void OnChangeActive()
        {
            if (ChangeActive != null)
            {
                ChangeActive.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #active}.
        /// </summary>
        public event EventHandler ChangeActive;

        protected virtual void OnChangeAlwaysOnTop()
        {
            if (ChangeAlwaysOnTop != null)
            {
                ChangeAlwaysOnTop.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #alwaysOnTop}.
        /// </summary>
        public event EventHandler ChangeAlwaysOnTop;

        protected virtual void OnChangeCaption()
        {
            if (ChangeCaption != null)
            {
                ChangeCaption.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #caption}.
        /// </summary>
        public event EventHandler ChangeCaption;

        protected virtual void OnChangeIcon()
        {
            if (ChangeIcon != null)
            {
                ChangeIcon.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #icon}.
        /// </summary>
        public event EventHandler ChangeIcon;

        protected virtual void OnChangeModal()
        {
            if (ChangeModal != null)
            {
                ChangeModal.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #modal}.
        /// </summary>
        public event EventHandler ChangeModal;

        protected virtual void OnChangeStatus()
        {
            if (ChangeStatus != null)
            {
                ChangeStatus.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #status}.
        /// </summary>
        public event EventHandler ChangeStatus;

        protected virtual void OnClose()
        {
            if (Close != null)
            {
                Close.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the window is closed
        /// </summary>
        public event EventHandler Close;

        protected virtual void OnMaximize()
        {
            if (Maximize != null)
            {
                Maximize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the window is maximized
        /// </summary>
        public event EventHandler Maximize;

        protected virtual void OnMinimize()
        {
            if (Minimize != null)
            {
                Minimize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the window is minimized
        /// </summary>
        public event EventHandler Minimize;

        protected virtual void OnRestore()
        {
            if (Restore != null)
            {
                Restore.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the window is restored from a minimized or maximized state
        /// </summary>
        public event EventHandler Restore;

    }
}
