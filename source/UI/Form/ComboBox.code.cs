using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    public partial class ComboBox : qxDotNet.UI.Form.AbstractSelectBox, qxDotNet.UI.Form.IStringForm
    {

        private string _value = "";

        public string Value
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

        #region IStringForm Members

        string IStringForm.Value
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

        #endregion
    }
}
