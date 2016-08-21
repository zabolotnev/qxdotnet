using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Groupbox
{
    /// <summary>
    /// Group boxes are used to group a set of form elements.
    /// 
    /// </summary>
    public partial class GroupBox : qxDotNet.UI.Core.ChildrenHandling, qxDotNet.UI.Form.IForm
    {

        private qxDotNet.LegendPositionEnum _legendPosition = LegendPositionEnum.middle;
        private string _icon = "";
        private string _legend = "";
        private qxDotNet.UI.Layout.Abstract _layout = null;
        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// Property for setting the position of the legend.
        /// 
        /// </summary>
        public qxDotNet.LegendPositionEnum LegendPosition
        {
            get
            {
                return _legendPosition;
            }
            set
            {
               _legendPosition = value;
            }
        }

        /// <summary>
        /// Accessor method for the icon of the legend sub widget
        /// 
        /// Sets the icon of the legend sub widget.
        /// 
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
            }
        }

        /// <summary>
        /// Accessor method for the label of the legend sub widget
        /// 
        /// Sets the label of the legend sub widget if the given string is
        /// valid. Otherwise the legend sub widget get not displayed.
        /// 
        /// </summary>
        public string Legend
        {
            get
            {
                return _legend;
            }
            set
            {
               _legend = value;
            }
        }

        /// <summary>
        /// Get the widget's layout manager.
        /// 
        /// Set a layout manager for the widget. A a layout manager can only be connected
        /// with one widget. Reset the connection with a previous widget first, if you
        /// like to use it in another widget instead.
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
        /// Bottom padding of the content pane
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// Message which is shown in an invalid tooltip.
        /// 
        /// </summary>
        public string InvalidMessage
        {
            get
            {
                return _invalidMessage;
            }
            set
            {
               _invalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is required.
        /// 
        /// </summary>
        public bool? Required
        {
            get
            {
                return _required;
            }
            set
            {
               _required = value;
               OnChangeRequired();
            }
        }

        /// <summary>
        /// Message which is shown in an invalid tooltip if the {@link #required} is
        /// set to true.
        /// 
        /// </summary>
        public string RequiredInvalidMessage
        {
            get
            {
                return _requiredInvalidMessage;
            }
            set
            {
               _requiredInvalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid
        /// state will be set.
        /// 
        /// </summary>
        public bool? Valid
        {
            get
            {
                return _valid;
            }
            set
            {
               _valid = value;
               OnChangeValid();
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.groupbox.GroupBox";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("legendPosition", _legendPosition, LegendPositionEnum.middle);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("legend", _legend, "");
            state.SetPropertyValue("layout", _layout, null);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        /// <summary>
        /// Raises event 'ChangeInvalidMessage'
        /// </summary>
        protected virtual void OnChangeInvalidMessage()
        {
            if (ChangeInvalidMessage != null)
            {
                ChangeInvalidMessage.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #invalidMessage}.
        /// </summary>
        public event EventHandler ChangeInvalidMessage;

        /// <summary>
        /// Raises event 'ChangeRequired'
        /// </summary>
        protected virtual void OnChangeRequired()
        {
            if (ChangeRequired != null)
            {
                ChangeRequired.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #required}.
        /// </summary>
        public event EventHandler ChangeRequired;

        /// <summary>
        /// Raises event 'ChangeValid'
        /// </summary>
        protected virtual void OnChangeValid()
        {
            if (ChangeValid != null)
            {
                ChangeValid.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #valid}.
        /// </summary>
        public event EventHandler ChangeValid;

    }
}
