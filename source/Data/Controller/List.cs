using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data.Controller
{
    /// <summary>
    /// List Controller  General idea The list controller is responsible for synchronizing every list like widget with a data array. It does not matter if the array contains atomic values like strings of complete objects where one property holds the value for the label and another property holds the icon url. You can even use converters that make the label show a text corresponding to the icon, by binding both label and icon to the same model property and converting one of them.  Features   Synchronize the model and the target Label and icon are bindable Takes care of the selection Passes on the options used by {@link qx.data.SingleValueBinding#bind}   Usage  As model, only {@link qx.data.Array}s do work. The currently supported targets are   {@link qx.ui.form.SelectBox} {@link qx.ui.form.List} {@link qx.ui.form.ComboBox}   All the properties like model, target or any property path is bindable. Especially the model is nice to bind to another selection for example. The controller itself can only work if it has a model and a target set. The rest of the properties may be empty.  Cross reference   If you want to bind single values, use {@link qx.data.controller.Object} If you want to bind a tree widget, use {@link qx.data.controller.Tree} If you want to bind a form widget, use {@link qx.data.controller.Form} 
    /// </summary>
    public partial class List : qxDotNet.Core.Object
    {

//        private _var _delegate = null;
//        private _var _iconOptions = null;
        private string _iconPath = "";
//        private _var _labelOptions = null;
        private string _labelPath = "";
        private qxDotNet.Data.IListData _model = null;
//        private _var _target = null;
        private qxDotNet.Data.Array _selection = null;


        /// <summary>
        /// The path to the property which holds the information that should be shown as an icon. This is only needed if objects are stored in the model and if the icon should be shown.
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
            }
        }

        /// <summary>
        /// The path to the property which holds the information that should be shown as a label. This is only needed if objects are stored in the model.
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
            }
        }

        /// <summary>
        /// Data array containing the data which should be shown in the list.
        /// </summary>
        public qxDotNet.Data.IListData Model
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
        /// Data array containing the selected model objects. This property can be manipulated directly which means that a push to the selection will also select the corresponding element in the target.
        /// </summary>
        public qxDotNet.Data.Array Selection
        {
            get
            {
                return _selection;
            }
            set
            {
               _selection = value;
               OnChangeSelection();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.data.controller.List";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("iconPath", _iconPath, "");
            state.SetPropertyValue("labelPath", _labelPath, "");
            state.SetPropertyValue("model", _model, null);
            state.SetPropertyValue("selection", _selection, null);


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

        protected virtual void OnChangeTarget()
        {
            if (ChangeTarget != null)
            {
                ChangeTarget.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #target}.
        /// </summary>
        public event EventHandler ChangeTarget;

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #selection}.
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
