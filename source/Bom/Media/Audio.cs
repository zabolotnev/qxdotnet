using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Media
{
    /// <summary>
    /// EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION  Media object for playing sounds.
    /// </summary>
    public partial class Audio : qxDotNet.Bom.Media.Abstract
    {




        protected internal override string GetTypeName()
        {
            return "qx.bom.media.Audio";
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
