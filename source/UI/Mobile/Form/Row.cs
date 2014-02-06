using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The Row widget represents a row in a {@link Form}.
    /// </summary>
    public partial class Row : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _selectable = false;


        /// <summary>
        /// Whether the widget is selectable or not.
        /// </summary>
        public bool? Selectable
        {
            get
            {
                return _selectable;
            }
            set
            {
               _selectable = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.Row";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selectable", _selectable, false);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
