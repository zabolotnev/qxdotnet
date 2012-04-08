using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Event
{
    public partial class Timer : qxDotNet.Core.Object
    {

        public Timer()
        {
            Common.ApplicationState.Instance.GUI.RegisterTimer(this);
        }

    }
}
