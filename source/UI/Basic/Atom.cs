using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Basic
{
    /// <summary>
    /// A multi-purpose widget, which combines a label with an icon.  The intended purpose of qx.ui.basic.Atom is to easily align the common icon-text combination in different ways.  This is useful for all types of buttons, tooltips, ...  Example  Here is a little example of how to use the widget.    var atom = new qx.ui.basic.Atom(\IconRight\, \icon/32/actions/go-next.png\);  this.getRoot().add(atom);   This example creates an atom with the label &#8220;Icon Right&#8221; and an icon.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Atom : qxDotNet.UI.Core.Widget
    {

        private bool? _center = false;
        private int _gap = 4;
        private string _icon = "";
        private qxDotNet.IconPositionEnum _iconPosition = IconPositionEnum.left;
        private string _label = "";
        private bool? _rich = false;
        private qxDotNet.ShowEnum _show = ShowEnum.both;


        /// <summary>
        /// Whether the content should be rendered centrally when to much space is available. Affects both axis.
        /// </summary>
        public bool? Center
        {
            get
            {
                return _center;
            }
            set
            {
               _center = value;
            }
        }

        /// <summary>
        /// The space between the icon and the label
        /// </summary>
        public int Gap
        {
            get
            {
                return _gap;
            }
            set
            {
               _gap = value;
               OnChangeGap();
            }
        }

        /// <summary>
        /// Any URI String supported by qx.ui.basic.Image to display an icon
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
        /// The position of the icon in relation to the text. Only useful/needed if text and icon is configured and &#8216;show&#8217; is configured as &#8216;both&#8217; (default)
        /// </summary>
        public qxDotNet.IconPositionEnum IconPosition
        {
            get
            {
                return _iconPosition;
            }
            set
            {
               _iconPosition = value;
            }
        }

        /// <summary>
        /// The label/caption/text of the qx.ui.basic.Atom instance
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
        /// Switches between rich HTML and text content. The text mode (false) supports advanced features like ellipsis when the available space is not enough. HTML mode (true) supports multi-line content and all the markup features of HTML content.
        /// </summary>
        public bool? Rich
        {
            get
            {
                return _rich;
            }
            set
            {
               _rich = value;
            }
        }

        /// <summary>
        /// Configure the visibility of the sub elements/widgets. Possible values: both, text, icon
        /// </summary>
        public qxDotNet.ShowEnum Show
        {
            get
            {
                return _show;
            }
            set
            {
               _show = value;
               OnChangeShow();
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.basic.Atom";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("center", _center, false);
            state.SetPropertyValue("gap", _gap, 4);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("iconPosition", _iconPosition, IconPositionEnum.left);
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("rich", _rich, false);
            state.SetPropertyValue("show", _show, ShowEnum.both);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeGap()
        {
            if (ChangeGap != null)
            {
                ChangeGap.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #gap}.
        /// </summary>
        public event EventHandler ChangeGap;

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

        protected virtual void OnChangeShow()
        {
            if (ChangeShow != null)
            {
                ChangeShow.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #show}.
        /// </summary>
        public event EventHandler ChangeShow;

    }
}
