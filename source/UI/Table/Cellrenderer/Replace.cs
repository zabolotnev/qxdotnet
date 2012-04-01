using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// The cell will use, if given, the replaceMap property and/or the replaceFunction to look up labels for a specific cell value. if the replaceMap, which does not need to be used but takes precedence if given, has no entry for a specific value, you can implement a fallback lookup in the replacementFunction, or use the replacementFunction exclusively.  In editable cells, you need to make sure that the method returning the data to the data storage (for example, a database backend) translates the replaced cell value (the label) back into the corresponding value. Thus, both map and function MUST also take care of the reverse translation of labels into values. Example: if you have a field that should display &#8220;Active&#8221; on a &#8220;1&#8221; value and &#8220;Inactive&#8221; on a &#8220;0&#8221; value, you must use the following map:   {  0 : \Inactive\,  1 : \Active\,  \Inactive\ : 0,  \Active\ : 1 }   You can use the addReversedReplaceMap() method to do this for you:   var propertyCellRenderer = new qx.ui.table.cellrenderer.Replace; propertyCellRenderer.setReplaceMap({  1 : \Active\,  0 : \Inactive\,  2 : \Waiting\,  'admin' : \SystemAdministrator\,  'manager' : \UserManager\,  'user' : \WebsiteUser\ }); propertyCellRenderer.addReversedReplaceMap(); 
    /// </summary>
    public partial class Replace : qxDotNet.UI.Table.Cellrenderer.Default
    {

        private Map _replaceMap = null;
        private string _prevMap = null;

        /// <summary>
        /// The cell will use, if given, the replaceMap property and/or the replaceFunction to look up labels for a specific cell value. if the replaceMap, which does not need to be used but takes precedence if given, has no entry for a specific value, you can implement a fallback lookup in the replacementFunction, or use the replacementFunction exclusively.
        /// </summary>
        public Map ReplaceMap
        {
            get
            {
                return _replaceMap;
            }
            set
            {
                _replaceMap = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Replace";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            if (_replaceMap != null)
            {
                state.SetPropertyValue("replaceMap", _replaceMap.ToString(), "");
            }
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            string map = null;
            if (_replaceMap != null)
            {
                map = _replaceMap.ToString();
            }
            if (map != _prevMap || isRefreshRequest)
            {
                response.Write(GetReference() + ".addReversedReplaceMap();\n");
            }
            _prevMap = map;
        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
