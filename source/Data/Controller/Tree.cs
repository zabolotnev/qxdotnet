using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data.Controller
{
    /// <summary>
    /// Tree Controller  General idea  The tree controller is the controller made for the {@link qx.ui.tree.Tree} widget in qooxdoo. Therefore, it is responsible for creating and adding the tree folders to the tree given as target.  Features   Synchronize the model and the target Label and icon are bindable Takes care of the selection Passes on the options used by {@link qx.data.SingleValueBinding#bind}   Usage  As model, you can use every qooxdoo widget structure having one property, which is a data array holding the children of the current node. There can be as many additional as you like. You need to specify a model, a target, a child path and a label path to make the controller work.  Cross reference   If you want to bind single values, use {@link qx.data.controller.Object} If you want to bind a list like widget, use {@link qx.data.controller.List} If you want to bin a form widget, use {@link qx.data.controller.Form} 
    /// </summary>
    public partial class Tree : qxDotNet.Core.Object
    {

        private string _childPath = "";
//        private _var _delegate = null;
//        private _var _iconOptions = null;
        private string _iconPath = "";
//        private _var _labelOptions = null;
        private string _labelPath = "";
        private qxDotNet.Core.Object _model = null;
//        private _var _target = null;
        private qxDotNet.Data.Array _selection = null;


        /// <summary>
        /// The name of the property, where the children are stored in the model.
        /// </summary>
        public string ChildPath
        {
            get
            {
                return _childPath;
            }
            set
            {
               _childPath = value;
            }
        }

        /// <summary>
        /// The name of the property, where the source for the tree folders icon is stored in the model classes.
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
        /// The name of the property, where the value for the tree folders label is stored in the model classes.
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
        /// The root element of the data.
        /// </summary>
        public qxDotNet.Core.Object Model
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
            return "qx.data.controller.Tree";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("childPath", _childPath, "");
            state.SetPropertyValue("iconPath", _iconPath, "");
            state.SetPropertyValue("labelPath", _labelPath, "");
            state.SetPropertyValue("model", _model, null);
            state.SetPropertyValue("selection", _selection, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

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
