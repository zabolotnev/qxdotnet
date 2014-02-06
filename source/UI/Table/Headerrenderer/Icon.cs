using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Headerrenderer
{
    /// <summary>
    /// A header cell renderer which renders an icon (only). The icon cannot be combined with text.
    /// </summary>
    public partial class Icon : qxDotNet.UI.Table.Headerrenderer.Default
    {

        private string _iconUrl = "";


        /// <summary>
        /// URL of the icon to show
        /// </summary>
        public string IconUrl
        {
            get
            {
                return _iconUrl;
            }
            set
            {
               _iconUrl = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.headerrenderer.Icon";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("iconUrl", _iconUrl, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
