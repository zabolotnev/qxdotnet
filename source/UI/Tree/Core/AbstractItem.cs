using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree.Core
{
    /// <summary>
    /// The AbstractItem serves as a common superclass for the {@link qx.ui.tree.core.AbstractTreeItem} and {@link qx.ui.tree.VirtualTreeItem} classes.
    /// </summary>
    public abstract partial class AbstractItem : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IModel
    {

        private string _icon = "";
        private string _iconOpened = "";
        private int _indent = 19;
        private string _label = "";
        private bool? _open = false;
        private qxDotNet.OpenSymbolModeEnum _openSymbolMode = OpenSymbolModeEnum.auto;
//        private _var _model = null;


        /// <summary>
        /// URI of "closed" icon. Can be any URI String supported by qx.ui.basic.Image.
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
        /// URI of "opened" icon. Can be any URI String supported by qx.ui.basic.Image.
        /// </summary>
        public string IconOpened
        {
            get
            {
                return _iconOpened;
            }
            set
            {
               _iconOpened = value;
               OnChangeIconOpened();
            }
        }

        /// <summary>
        /// The number of pixel to indent the tree item for each level.
        /// </summary>
        public int Indent
        {
            get
            {
                return _indent;
            }
            set
            {
               _indent = value;
               OnChangeIndent();
            }
        }

        /// <summary>
        /// The label/caption/text
        /// </summary>
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
               _label = value;
               OnChangeLabel();
            }
        }

        /// <summary>
        /// Whether the tree item is opened.
        /// </summary>
        public bool? Open
        {
            get
            {
                return _open;
            }
            set
            {
               _open = value;
               OnChangeOpen();
            }
        }

        /// <summary>
        /// Controls, when to show the open symbol. If the mode is "auto" , the open symbol is shown only if the item has child items.
        /// </summary>
        public qxDotNet.OpenSymbolModeEnum OpenSymbolMode
        {
            get
            {
                return _openSymbolMode;
            }
            set
            {
               _openSymbolMode = value;
               OnChangeOpenSymbolMode();
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tree.core.AbstractItem";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("iconOpened", _iconOpened, "");
            state.SetPropertyValue("indent", _indent, 19);
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("open", _open, false);
            state.SetPropertyValue("openSymbolMode", _openSymbolMode, OpenSymbolModeEnum.auto);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

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

        protected virtual void OnChangeIconOpened()
        {
            if (ChangeIconOpened != null)
            {
                ChangeIconOpened.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #iconOpened}.
        /// </summary>
        public event EventHandler ChangeIconOpened;

        protected virtual void OnChangeIndent()
        {
            if (ChangeIndent != null)
            {
                ChangeIndent.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #indent}.
        /// </summary>
        public event EventHandler ChangeIndent;

        protected virtual void OnChangeLabel()
        {
            if (ChangeLabel != null)
            {
                ChangeLabel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #label}.
        /// </summary>
        public event EventHandler ChangeLabel;

        protected virtual void OnChangeOpen()
        {
            if (ChangeOpen != null)
            {
                ChangeOpen.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #open}.
        /// </summary>
        public event EventHandler ChangeOpen;

        protected virtual void OnChangeOpenSymbolMode()
        {
            if (ChangeOpenSymbolMode != null)
            {
                ChangeOpenSymbolMode.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #openSymbolMode}.
        /// </summary>
        public event EventHandler ChangeOpenSymbolMode;

        protected virtual void OnChangeModel()
        {
            if (ChangeModel != null)
            {
                ChangeModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #model}.
        /// </summary>
        public event EventHandler ChangeModel;

    }
}
