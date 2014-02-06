using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Htmlarea.Manager
{
    /// <summary>
    /// Decorator for CommandManager instance to implement Undo/Redo functionality
    /// </summary>
    public partial class UndoRedo : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.bom.htmlarea.manager.UndoRedo";
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
