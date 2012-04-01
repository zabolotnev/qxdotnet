using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A button which opens the connected menu when clicking on it.
    /// </summary>
    public partial class MenuButton : qxDotNet.UI.Form.Button
    {

        private qxDotNet.UI.Menu.Menu _menu = null;


        /// <summary>
        /// The menu instance to show when clicking on the button
        /// </summary>
        public qxDotNet.UI.Menu.Menu Menu
        {
            get
            {
                return _menu;
            }
            set
            {
               _menu = value;
               OnChangeMenu();
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.MenuButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("menu", _menu, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeMenu()
        {
            if (ChangeMenu != null)
            {
                ChangeMenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #menu}.
        /// </summary>
        public event EventHandler ChangeMenu;

    }
}
