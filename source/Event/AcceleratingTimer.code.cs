using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Event
{
    public partial class AcceleratingTimer : qxDotNet.Core.Object
    {

        public AcceleratingTimer()
        {
            Common.ApplicationState.Instance.GUI.RegisterNonVisual(this);
        }

    }
}
