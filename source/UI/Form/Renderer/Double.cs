﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form.Renderer
{
    /// <summary>
    /// Double column renderer for {@link qx.ui.form.Form}.
    /// 
    /// </summary>
    public partial class Double : qxDotNet.UI.Form.Renderer.AbstractRenderer
    {

        public Double(Form form)
            :base(form)
        {

        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.renderer.Double";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
