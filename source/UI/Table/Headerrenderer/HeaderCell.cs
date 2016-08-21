using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Headerrenderer
{
    /// <summary>
    /// The default header cell widget
    /// 
    /// </summary>
    public partial class HeaderCell : qxDotNet.UI.Container.Composite
    {

        private string _icon = null;
        private string _label = null;
        private string _sortIcon = null;


        /// <summary>
        /// Icon URL
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
        /// header cell label
        /// 
        /// </summary>
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
               _label = value;
            }
        }

        /// <summary>
        /// The icon URL of the sorting indicator
        /// 
        /// </summary>
        public string SortIcon
        {
            get
            {
                return _sortIcon;
            }
            set
            {
               _sortIcon = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.headerrenderer.HeaderCell";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("icon", _icon, null);
            state.SetPropertyValue("label", _label, null);
            state.SetPropertyValue("sortIcon", _sortIcon, null);


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
