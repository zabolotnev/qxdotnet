using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// For a GUI application that looks &amp; feels like native desktop application (often called "RIA" - Rich Internet Application).  Such a stand-alone application typically creates and updates all content dynamically. Often it is called a "single-page application", since the document itself is never reloaded or changed. Communication with the server is done with AJAX.
    /// </summary>
    public partial class Standalone : qxDotNet.Application.AbstractGui
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.application.Standalone";
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
