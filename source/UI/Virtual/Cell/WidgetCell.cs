using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// EXPERIMENTAL!  Cell renderer can be used for Widget rendering. The Widget creation can be configured with the {@link #delegate} property:   widgetCell.setDelegate( {  createWidget : function() {  return new qx.ui.form.ListItem();  } });   When the {@link #delegate} property is not used {@link qx.ui.core.Widget} instances are created as fallback.  The {@link #updateData} method can be used to update any Widget property. Just use a Map with property name as key:   // widget is a qx.ui.form.ListItem instance widgetCell.updateData(widget, {  label: \mylabelvalue\,  icon: \qx/icon/22/emotes/face-angel.png\ }); 
    /// </summary>
    public partial class WidgetCell : qxDotNet.UI.Virtual.Cell.AbstractWidget
    {

//        private _var _delegate = null;



        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.WidgetCell";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
