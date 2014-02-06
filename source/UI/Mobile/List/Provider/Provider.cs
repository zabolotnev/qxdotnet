using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.List.Provider
{
    /// <summary>
    /// Provides a list item element for a certain row and its data. Uses the {@link qx.ui.mobile.list.renderer.Default} list item renderer as a default renderer when no other renderer is given by the {@link qx.ui.mobile.list.List#delegate}.
    /// </summary>
    public partial class Provider : qxDotNet.Core.Object
    {

//        private _var _delegate = null;



        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.list.provider.Provider";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeDelegate()
        {
            if (ChangeDelegate != null)
            {
                ChangeDelegate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #delegate}.
        /// </summary>
        public event EventHandler ChangeDelegate;

    }
}
