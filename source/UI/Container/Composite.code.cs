using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Container
{
    public partial class Composite
    {

        public Composite()
        {

        }

        public Composite(Layout.Abstract layout)
        {
            SetLayout(layout);
        }

        public void SetLayout(Layout.Abstract layout)
        {
            _layout = layout;
        }

    }
}
