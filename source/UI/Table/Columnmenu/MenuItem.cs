using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmenu
{
    /// <summary>
    /// A menu item.
    /// </summary>
    public partial class MenuItem : qxDotNet.UI.Menu.CheckBox, qxDotNet.UI.Table.IColumnMenuItem
    {

        private bool? _visible = true;


        /// <summary>
        /// Whether the table column associated with this menu item is visible.
        /// </summary>
        public bool? Visible
        {
            get
            {
                return _visible;
            }
            set
            {
               _visible = value;
               OnChangeVisible();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.columnmenu.MenuItem";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("visible", _visible, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeVisible()
        {
            if (ChangeVisible != null)
            {
                ChangeVisible.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #visible}.
        /// </summary>
        public event EventHandler ChangeVisible;

    }
}
