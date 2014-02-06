using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Dialog
{
    /// <summary>
    /// This widget displays a menu. A dialog menu extends a popup and contains a list, which provides the user the possibility to select one value. The selected value is identified through selected index.  Example    var model = new qx.data.Array([\item1\,\item2\,\item3\]);  var menu = new qx.ui.mobile.dialog.Menu(model); menu.show(); menu.addListener(\changeSelection\, function(evt){  var selectedIndex = evt.getData().index;  var selectedItem = evt.getData().item; }, this);   This example creates a menu with several choosable items.
    /// </summary>
    public partial class Menu : qxDotNet.UI.Mobile.Dialog.Popup
    {

        private string _clearButtonLabel = "None";
        private bool? _nullable = false;
        private int _selectedIndex = 0;
//        private _var _selectedItemClass = "item-selected";
//        private _var _unselectedItemClass = "item-unselected";
        private int _visibleListItems = 0;


        /// <summary>
        /// The label of the null value entry of the list. Only relevant when nullable property is set to true.
        /// </summary>
        public string ClearButtonLabel
        {
            get
            {
                return _clearButtonLabel;
            }
            set
            {
               _clearButtonLabel = value;
            }
        }

        /// <summary>
        /// Defines if the menu has a null value in the list, which can be chosen by the user. The label
        /// </summary>
        public bool? Nullable
        {
            get
            {
                return _nullable;
            }
            set
            {
               _nullable = value;
            }
        }

        /// <summary>
        /// The selected index of this menu.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
               _selectedIndex = value;
            }
        }

        /// <summary>
        /// This value defines how much list items are visible inside the menu.
        /// </summary>
        public int VisibleListItems
        {
            get
            {
                return _visibleListItems;
            }
            set
            {
               _visibleListItems = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.dialog.Menu";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("clearButtonLabel", _clearButtonLabel, "None");
            state.SetPropertyValue("nullable", _nullable, false);
            state.SetPropertyValue("selectedIndex", _selectedIndex, 0);
            state.SetPropertyValue("visibleListItems", _visibleListItems, 0);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeSelection")
            {
                OnChangeSelection();
            }
        }

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the selection is changed.
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
