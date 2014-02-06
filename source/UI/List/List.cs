using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.List
{
    /// <summary>
    /// The qx.ui.list.List is based on the virtual infrastructure and supports filtering, sorting, grouping, single selection, multi selection, data binding and custom rendering.  Using the virtual infrastructure has considerable advantages when there is a huge amount of model items to render because the virtual infrastructure only creates widgets for visible items and reuses them. This saves both creation time and memory.  With the {@link qx.ui.list.core.IListDelegate} interface it is possible to configure the list's behavior (item and group renderer configuration, filtering, sorting, grouping, etc.).  Here";s an example of how to use the widget:   //create the model data var rawData = []; for (var i = 0; i  b ? 1 : a 
    /// </summary>
    public partial class List : qxDotNet.UI.Virtual.Core.Scroller
    {

        private bool? _autoGrouping = true;
//        private _var _delegate = null;
//        private _var _groupLabelOptions = null;
        private string _groupLabelPath = "";
        private qxDotNet.Data.Array _groups = null;
//        private _var _iconOptions = null;
        private string _iconPath = "";
        private int _itemHeight = 25;
//        private _var _labelOptions = null;
        private string _labelPath = "";
        private qxDotNet.Data.IListData _model = null;


        /// <summary>
        /// Indicates that the list is managing the {@link #groups} automatically.
        /// </summary>
        public bool? AutoGrouping
        {
            get
            {
                return _autoGrouping;
            }
            set
            {
               _autoGrouping = value;
            }
        }

        /// <summary>
        /// The path to the property which holds the information that should be displayed as a group label. This is only needed if objects are stored in the model.
        /// </summary>
        public string GroupLabelPath
        {
            get
            {
                return _groupLabelPath;
            }
            set
            {
               _groupLabelPath = value;
            }
        }

        /// <summary>
        /// Contains all groups for data binding, but do only manipulate the array when the {@link #autoGrouping} is set to false.
        /// </summary>
        public qxDotNet.Data.Array Groups
        {
            get
            {
                return _groups;
            }
            set
            {
               _groups = value;
               OnChangeGroups();
            }
        }

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
            }
        }

        /// <summary>
        /// Default item height
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.list.List";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("autoGrouping", _autoGrouping, true);
            state.SetPropertyValue("groupLabelPath", _groupLabelPath, "");
            state.SetPropertyValue("groups", _groups, null);
            state.SetPropertyValue("iconPath", _iconPath, "");
            state.SetPropertyValue("itemHeight", _itemHeight, 25);
            state.SetPropertyValue("labelPath", _labelPath, "");
            state.SetPropertyValue("model", _model, null);


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

        protected virtual void OnChangeGroups()
        {
            if (ChangeGroups != null)
            {
                ChangeGroups.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #groups}.
        /// </summary>
        public event EventHandler ChangeGroups;

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
