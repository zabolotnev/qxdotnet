using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// The cell will use, if given, the
    /// replaceMap property and/or the replaceFunction to look up labels for a
    /// specific cell value. if the replaceMap, which does not need to be used but
    /// takes precedence if given, has no entry for a specific value, you can implement
    /// a fallback lookup in the replacementFunction, or use the replacementFunction exclusively.
    /// 
    /// In editable cells, you need to make sure that the method returning the data
    /// to the data storage (for example, a database backend) translates the replaced
    /// cell value (the label) back into the corresponding value. Thus, both map and
    /// function MUST also take care of the reverse translation of labels into
    /// values. Example: if you have a field that should display "Active" on a "1"
    /// value and "Inactive" on a "0" value, you must use the following map:
    /// 
    /// 
    /// {
    ///  0 : "Inactive",
    ///  1 : "Active",
    ///  "Inactive" : 0,
    ///  "Active" : 1
    /// }
    /// 
    /// 
    /// You can use the addReversedReplaceMap() method to do this for you:
    /// 
    /// 
    /// var propertyCellRenderer = new qx.ui.table.cellrenderer.Replace;
    /// propertyCellRenderer.setReplaceMap({
    ///  1 : "Active",
    ///  0 : "Inactive",
    ///  2 : "Waiting",
    ///  'admin' : "System Administrator",
    ///  'manager' : "User Manager",
    ///  'user' : "Website User"
    /// });
    /// propertyCellRenderer.addReversedReplaceMap();
    /// 
    /// </summary>
    public partial class Replace : qxDotNet.UI.Table.Cellrenderer.Default
    {

//TODO: private _var _replaceMap = null;



        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Replace";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
