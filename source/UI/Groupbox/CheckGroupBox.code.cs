using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Groupbox
{
    public partial class CheckGroupBox : qxDotNet.UI.Groupbox.GroupBox, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IModel
    {

        private qxDotNet.UI.Core.Command _command = null;

        public qxDotNet.UI.Core.Command Command
        {
            get
            {
                return _command;
            }
            set
            {
                _command = value;
            }
        }

        #region IBooleanForm Members

        bool? qxDotNet.UI.Form.IBooleanForm.Value
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
