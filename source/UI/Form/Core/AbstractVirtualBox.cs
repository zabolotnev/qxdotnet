using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Core
{
    /// <summary>
    /// Basic class for widgets which need a virtual list as popup for example a SelectBox. It&#8217;s basically supports a drop-down as popup with a virtual list and the whole children management.
    /// </summary>
    public abstract partial class AbstractVirtualBox : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IForm
    {

//        private _var _delegate = null;
//        private _var _iconOptions = null;
        private string _iconPath = "";
        private int _itemHeight = 25;
//        private _var _labelOptions = null;
        private string _labelPath = "";
        private decimal _maxListHeight = 200;
        private qxDotNet.Data.Array _model = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// The path to the property which holds the information that should be displayed as an icon. This is only needed if objects are stored in the model and icons should be displayed.
        /// </summary>
        public string IconPath
        {
            get
            {
                return _iconPath;
            }
            set
            {
               _iconPath = value;
               OnChangeIconPath();
            }
        }

        /// <summary>
        /// Default item height.
        /// </summary>
        public int ItemHeight
        {
            get
            {
                return _itemHeight;
            }
            set
            {
               _itemHeight = value;
            }
        }

        /// <summary>
        /// The path to the property which holds the information that should be displayed as a label. This is only needed if objects are stored in the model.
        /// </summary>
        public string LabelPath
        {
            get
            {
                return _labelPath;
            }
            set
            {
               _labelPath = value;
               OnChangeLabelPath();
            }
        }

        /// <summary>
        /// The maximum height of the drop-down list. Setting this value to null will set cause the list to be auto-sized.
        /// </summary>
        public decimal MaxListHeight
        {
            get
            {
                return _maxListHeight;
            }
            set
            {
               _maxListHeight = value;
            }
        }

        /// <summary>
        /// Data array containing the data which should be shown in the drop-down.
        /// </summary>
        public qxDotNet.Data.Array Model
        {
            get
            {
                return _model;
            }
            set
            {
               _model = value;
               OnChangeModel();
            }
        }

        /// <summary>
        /// Message which is shown in an invalid tooltip.
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
        /// Message which is shown in an invalid tooltip if the {@link #required} is set to true.
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
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid state will be set.
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


        public override string GetTypeName()
        {
            return "qx.ui.form.core.AbstractVirtualBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("iconPath", _iconPath, "");
            state.SetPropertyValue("itemHeight", _itemHeight, 25);
            state.SetPropertyValue("labelPath", _labelPath, "");
            state.SetPropertyValue("maxListHeight", _maxListHeight, 200);
            state.SetPropertyValue("model", _model, null);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeDelegate()
        {
            if (ChangeDelegate != null)
            {
                ChangeDelegate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #delegate}.
        /// </summary>
        public event EventHandler ChangeDelegate;

        protected virtual void OnChangeIconOptions()
        {
            if (ChangeIconOptions != null)
            {
                ChangeIconOptions.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #iconOptions}.
        /// </summary>
        public event EventHandler ChangeIconOptions;

        protected virtual void OnChangeIconPath()
        {
            if (ChangeIconPath != null)
            {
                ChangeIconPath.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #iconPath}.
        /// </summary>
        public event EventHandler ChangeIconPath;

        protected virtual void OnChangeLabelOptions()
        {
            if (ChangeLabelOptions != null)
            {
                ChangeLabelOptions.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #labelOptions}.
        /// </summary>
        public event EventHandler ChangeLabelOptions;

        protected virtual void OnChangeLabelPath()
        {
            if (ChangeLabelPath != null)
            {
                ChangeLabelPath.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #labelPath}.
        /// </summary>
        public event EventHandler ChangeLabelPath;

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
