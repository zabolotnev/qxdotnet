using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Dialog
{
    /// <summary>
    /// The popup represents a widget that gets shown above other widgets, usually to present more info/details regarding an item in the application.  There are 3 usages for now:   var widget = new qx.ui.mobile.form.Button(\Error!\); var popup = new qx.ui.mobile.dialog.Popup(widget); popup.show();   Here we show a popup consisting of a single buttons alerting the user that an error has occured. It will be centered to the screen.   var label = new qx.ui.mobile.basic.Label(\Item1\); var widget = new qx.ui.mobile.form.Button(\Error!\); var popup = new qx.ui.mobile.dialog.Popup(widget, label); popup.show(); widget.addListener(\tap\, function(){  popup.hide(); });    In this case everything is as above, except that the popup will get shown next to "label" so that the user can understand that the info presented is about the "Item1" we also add a tap listener to the button that will hide out popup.  Once created, the instance is reused between show/hide calls.   var widget = new qx.ui.mobile.form.Button(\Error!\); var popup = new qx.ui.mobile.dialog.Popup(widget); popup.placeTo(25,100); popup.show();   Same as the first example, but this time the popup will be shown at the 25,100 coordinates.
    /// </summary>
    public partial class Popup : qxDotNet.UI.Mobile.Core.Widget
    {

        private bool? _hideOnBlockerClick = false;
        private string _icon = "";
        private bool? _modal = false;
        private string _title = "";


        /// <summary>
        /// Indicates whether the a modal popup should disappear when user taps/clicks on Blocker.
        /// </summary>
        public bool? HideOnBlockerClick
        {
            get
            {
                return _hideOnBlockerClick;
            }
            set
            {
               _hideOnBlockerClick = value;
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
        /// Whether the popup should be displayed modal.
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
            }
        }

        /// <summary>
        /// The label/caption/text of the qx.ui.mobile.basic.Atom instance
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
               _title = value;
               OnChangeTitle();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.dialog.Popup";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("hideOnBlockerClick", _hideOnBlockerClick, false);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("modal", _modal, false);
            state.SetPropertyValue("title", _title, "");


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

        protected virtual void OnChangeTitle()
        {
            if (ChangeTitle != null)
            {
                ChangeTitle.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #title}.
        /// </summary>
        public event EventHandler ChangeTitle;

    }
}
