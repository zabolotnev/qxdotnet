using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// This class is an abstract base calls and used by {@link qx.theme.manager.Decoration}. It&#8217;s main purpose is to combine the included mixins into one working decorator.
    /// </summary>
    public abstract partial class DynamicDecorator : qxDotNet.UI.Decoration.Abstract
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.DynamicDecorator";
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
