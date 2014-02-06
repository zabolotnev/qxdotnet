using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Basic
{
    /// <summary>
    /// A multi-purpose widget, which combines a label with an icon.  The intended purpose of qx.ui.mobile.basic.Atom is to easily align the common icon-text combination in different ways.  Example  Here is a little example of how to use the widget.    var atom = new qx.ui.mobile.basic.Atom(\IconRight\, \icon/32/actions/go-next.png\);  this.getRoot().add(atom);   This example creates an atom with the label "Icon Right" and an icon.
    /// </summary>
    public partial class Atom : qxDotNet.UI.Mobile.Core.Widget
    {

        private int _gap = 4;
        private string _icon = "";
        private qxDotNet.IconPositionEnum _iconPosition = IconPositionEnum.left;
        private string _label = "";
        private qxDotNet.ShowEnum _show = ShowEnum.both;


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
            }
        }

        /// <summary>
        /// Any URI String supported by qx.ui.mobile.basic.Image to display an icon
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
        /// The position of the icon in relation to the text. Only useful/needed if text and icon is configured and &#8216;show' is configured as &#8216;both' (default)
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
        /// The label/caption/text of the qx.ui.mobile.basic.Atom instance
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
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.basic.Atom";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("gap", _gap, 4);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("iconPosition", _iconPosition, IconPositionEnum.left);
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("show", _show, ShowEnum.both);


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

    }
}
