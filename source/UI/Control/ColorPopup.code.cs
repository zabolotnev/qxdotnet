using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Control
{
    public partial class ColorPopup : qxDotNet.UI.Popup.Popup, qxDotNet.UI.Form.IColorForm
    {

        private string _value = null;

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

        #region IColorForm Members

        string qxDotNet.UI.Form.IColorForm.Value
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
