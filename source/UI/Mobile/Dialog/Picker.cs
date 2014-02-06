using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Dialog
{
    /// <summary>
    /// The picker widget gives the user the possibility to select a value out of an array of values. The picker widget is always shown in a {@link qx.ui.mobile.dialog.Popup}.  The picker widget is able to display multiple picker slots, for letting the user choose several values at one time, in one single dialog.  The selectable value array is passed to this widget through a {@link qx.data.Array} which represents one picker slot.  Example  Here is an example of how to use the picker widget.    var pickerSlot1 = new qx.data.Array([\qx.Desktop\, \qx.Mobile\, \qx.Website\,\qx.Server\]); var pickerSlot2 = new qx.data.Array([\1.5.1\, \1.6.1\, \2.0.4\, \2.1.2\, \3.0\]);  var picker = new qx.ui.mobile.dialog.Picker(); picker.setTitle(\Picker\); picker.addSlot(pickerSlot1); picker.addSlot(pickerSlot2);  var showPickerButton = new qx.ui.mobile.form.Button(\ShowPicker\); showPickerButton.addListener(\tap\, picker.show, picker); this.getContent().add(showPickerButton);  // Listener when user has confirmed his selection. // Contains the selectedIndex and values of all slots in a array. picker.addListener(\confirmSelection\,function(evt){  var pickerData = evt.getData(); }, this);  // Listener for change of picker slots. picker.addListener(\changeSelection\,function(evt){  var slotData = evt.getData(); }, this);  
    /// </summary>
    public partial class Picker : qxDotNet.UI.Mobile.Dialog.Popup
    {

        private int _selectedIndex = 0;


        /// <summary>
        /// 
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


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.dialog.Picker";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selectedIndex", _selectedIndex, 0);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
            }
            if (ConfirmSelection != null)
            {
                state.SetEvent("confirmSelection", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeSelection")
            {
                OnChangeSelection();
            }
            if (eventName == "confirmSelection")
            {
                OnConfirmSelection();
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
        /// Fired when the selection of a single slot has changed.
        /// </summary>
        public event EventHandler ChangeSelection;

        protected virtual void OnConfirmSelection()
        {
            if (ConfirmSelection != null)
            {
                ConfirmSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the picker is closed. This means user has confirmed its selection. Thie events contains all data which were chosen by user.
        /// </summary>
        public event EventHandler ConfirmSelection;

    }
}
