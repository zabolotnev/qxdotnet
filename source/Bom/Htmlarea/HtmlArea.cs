using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Htmlarea
{
    /// <summary>
    /// Low-level Rich text editor which can be used by connecting it to an existing DOM element (DIV node). This component does not contain any {@link qx.ui} code resulting in a smaller footprint.  Optimized for the use at a traditional webpage.
    /// </summary>
    public partial class HtmlArea : qxDotNet.Core.Object
    {

        private string _contentType = "xhtml";
        private string _defaultFontFamily = "Verdana";
        private int _defaultFontSize = 4;
        private bool? _insertLinebreakOnCtrlEnter = true;
        private bool? _insertParagraphOnLinebreak = true;
        private bool? _messengerMode = false;
        private bool? _nativeContextMenu = false;
        private bool? _useUndoRedo = true;
        private bool? _editable = false;
        private string _value = "";


        /// <summary>
        /// Selected content type. Currently only XHTML is supported.
        /// </summary>
        public string ContentType
        {
            get
            {
                return _contentType;
            }
            set
            {
               _contentType = value;
            }
        }

        /// <summary>
        /// Default font family to use when e.g. user removes all content
        /// </summary>
        public string DefaultFontFamily
        {
            get
            {
                return _defaultFontFamily;
            }
            set
            {
               _defaultFontFamily = value;
            }
        }

        /// <summary>
        /// Default font size to use when e.g. user removes all content
        /// </summary>
        public int DefaultFontSize
        {
            get
            {
                return _defaultFontSize;
            }
            set
            {
               _defaultFontSize = value;
            }
        }

        /// <summary>
        /// If true we add a linebreak after control+enter
        /// </summary>
        public bool? InsertLinebreakOnCtrlEnter
        {
            get
            {
                return _insertLinebreakOnCtrlEnter;
            }
            set
            {
               _insertLinebreakOnCtrlEnter = value;
            }
        }

        /// <summary>
        /// Toggles whether a p element is inserted on each line break or not. A "normal" linebreak can be achieved using the combination "Shift+Enter" anyway
        /// </summary>
        public bool? InsertParagraphOnLinebreak
        {
            get
            {
                return _insertParagraphOnLinebreak;
            }
            set
            {
               _insertParagraphOnLinebreak = value;
            }
        }

        /// <summary>
        /// If turned on the editor acts like a messenger widget e.g. if one hits the Enter key the current content gets outputted (via a DataEvent) and the editor clears his content
        /// </summary>
        public bool? MessengerMode
        {
            get
            {
                return _messengerMode;
            }
            set
            {
               _messengerMode = value;
            }
        }

        /// <summary>
        /// Whether to use the native contextmenu or to block it and use own event
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
            }
        }

        /// <summary>
        /// Toggles whether to use Undo/Redo
        /// </summary>
        public bool? UseUndoRedo
        {
            get
            {
                return _useUndoRedo;
            }
            set
            {
               _useUndoRedo = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool? Editable
        {
            get
            {
                return _editable;
            }
            set
            {
               _editable = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
               _value = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.htmlarea.HtmlArea";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("contentType", _contentType, "xhtml");
            state.SetPropertyValue("defaultFontFamily", _defaultFontFamily, "Verdana");
            state.SetPropertyValue("defaultFontSize", _defaultFontSize, 4);
            state.SetPropertyValue("insertLinebreakOnCtrlEnter", _insertLinebreakOnCtrlEnter, true);
            state.SetPropertyValue("insertParagraphOnLinebreak", _insertParagraphOnLinebreak, true);
            state.SetPropertyValue("messengerMode", _messengerMode, false);
            state.SetPropertyValue("nativeContextMenu", _nativeContextMenu, false);
            state.SetPropertyValue("useUndoRedo", _useUndoRedo, true);
            state.SetPropertyValue("editable", _editable, false);
            state.SetPropertyValue("value", _value, "");

            if (Contextmenu != null)
            {
                state.SetEvent("contextmenu", false);
            }
            if (CursorContext != null)
            {
                state.SetEvent("cursorContext", false);
            }
            if (Focused != null)
            {
                state.SetEvent("focused", false);
            }
            if (FocusOut != null)
            {
                state.SetEvent("focusOut", false);
            }
            if (Load != null)
            {
                state.SetEvent("load", false);
            }
            if (LoadingError != null)
            {
                state.SetEvent("loadingError", false);
            }
            if (MessengerContent != null)
            {
                state.SetEvent("messengerContent", false);
            }
            if (Ready != null)
            {
                state.SetEvent("ready", false);
            }
            if (ReadyAfterInvalid != null)
            {
                state.SetEvent("readyAfterInvalid", false);
            }
            if (UndoRedoState != null)
            {
                state.SetEvent("undoRedoState", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "contextmenu")
            {
                OnContextmenu();
            }
            if (eventName == "cursorContext")
            {
                OnCursorContext();
            }
            if (eventName == "focused")
            {
                OnFocused();
            }
            if (eventName == "focusOut")
            {
                OnFocusOut();
            }
            if (eventName == "load")
            {
                OnLoad();
            }
            if (eventName == "loadingError")
            {
                OnLoadingError();
            }
            if (eventName == "messengerContent")
            {
                OnMessengerContent();
            }
            if (eventName == "ready")
            {
                OnReady();
            }
            if (eventName == "readyAfterInvalid")
            {
                OnReadyAfterInvalid();
            }
            if (eventName == "undoRedoState")
            {
                OnUndoRedoState();
            }
        }

        protected virtual void OnContextmenu()
        {
            if (Contextmenu != null)
            {
                Contextmenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is dispatched when the editor gets a right click.  Fires a data event with the following data:   x &#8211; absolute x coordinate y &#8211; absolute y coordinate relX &#8211; relative x coordinate relY &#8211; relative y coordinate target &#8211; DOM element target 
        /// </summary>
        public event EventHandler Contextmenu;

        protected virtual void OnCursorContext()
        {
            if (CursorContext != null)
            {
                CursorContext.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event holds a data map which informs about the formatting at the current cursor position. It holds the following keys:   bold italic underline strikethrough fontSize fontFamily insertUnorderedList insertOrderedList justifyLeft justifyCenter justifyRight justifyFull   This map can be used to control/update a toolbar states.
        /// </summary>
        public event EventHandler CursorContext;

        protected virtual void OnFocused()
        {
            if (Focused != null)
            {
                Focused.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is dispatched when the editor gets the focus and his own handling is done
        /// </summary>
        public event EventHandler Focused;

        protected virtual void OnFocusOut()
        {
            if (FocusOut != null)
            {
                FocusOut.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is dispatched when the document receives an "focusout" event
        /// </summary>
        public event EventHandler FocusOut;

        protected virtual void OnLoad()
        {
            if (Load != null)
            {
                Load.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Thrown when the editor is loaded.
        /// </summary>
        public event EventHandler Load;

        protected virtual void OnLoadingError()
        {
            if (LoadingError != null)
            {
                LoadingError.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Thrown when the editor gets an error at loading time.
        /// </summary>
        public event EventHandler LoadingError;

        protected virtual void OnMessengerContent()
        {
            if (MessengerContent != null)
            {
                MessengerContent.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Only available if messengerMode is active. This event returns the current content of the editor.
        /// </summary>
        public event EventHandler MessengerContent;

        protected virtual void OnReady()
        {
            if (Ready != null)
            {
                Ready.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is dispatched when the editor is ready to use
        /// </summary>
        public event EventHandler Ready;

        protected virtual void OnReadyAfterInvalid()
        {
            if (ReadyAfterInvalid != null)
            {
                ReadyAfterInvalid.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is dispatched when the editor is ready to use after it was re-located and re-initialized. Only implemented for Gecko browsers.
        /// </summary>
        public event EventHandler ReadyAfterInvalid;

        protected virtual void OnUndoRedoState()
        {
            if (UndoRedoState != null)
            {
                UndoRedoState.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Holds information about the state of undo/redo Keys are "undo" and "redo". Possible values are 0 and -1 to stay in sync with the kind the "cursorContext" event works. (1 = active/pressed, 0 = possible/not pressed, -1 = disabled)
        /// </summary>
        public event EventHandler UndoRedoState;

    }
}
