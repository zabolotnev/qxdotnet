using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// Managed wrapper for the HTML Flash tag.
    /// </summary>
    public partial class Flash : qxDotNet.Html.Element
    {

        private Map _variables = null;


        /// <summary>
        /// 
        /// </summary>
        public Map Variables
        {
            get
            {
                return _variables;
            }
            set
            {
               _variables = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.html.Flash";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("variables", _variables, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
