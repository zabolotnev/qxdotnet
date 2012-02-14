using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmenu
{
    /// <summary>
    /// The traditional qx.ui.menu.MenuButton to access the column visibility menu.
    /// </summary>
    public partial class Button : qxDotNet.UI.Form.MenuButton, qxDotNet.UI.Table.IColumnMenuButton
    {




        public override string GetTypeName()
        {
            return "qx.ui.table.columnmenu.Button";
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
