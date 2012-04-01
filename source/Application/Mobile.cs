using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION  For a mobile application. Supports the mobile widget set.
    /// </summary>
    public partial class Mobile : qxDotNet.Core.Object, qxDotNet.Application.IApplication
    {




        protected internal override string GetTypeName()
        {
            return "qx.application.Mobile";
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
