﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// For a GUI application that looks &amp; feels like native desktop application (often called &#8220;RIA&#8221; &#8211; Rich Internet Application).  Such a stand-alone application typically creates and updates all content dynamically. Often it is called a &#8220;single-page application&#8221;, since the document itself is never reloaded or changed. Communication with the server is done with AJAX.
    /// </summary>
    public partial class Standalone : qxDotNet.Application.AbstractGui
    {




        public override string GetTypeName()
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