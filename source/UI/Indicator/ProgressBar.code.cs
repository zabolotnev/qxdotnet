using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Indicator
{
    public partial class ProgressBar : qxDotNet.UI.Container.Composite
    {

        private int _maximum = 0;
        private int _value = 0;

        public int Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
                _maximum = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

    }
}
