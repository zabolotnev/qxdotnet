using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Groupbox
{
    public partial class RadioGroupBox : qxDotNet.UI.Groupbox.GroupBox, qxDotNet.UI.Form.IRadioItem, qxDotNet.UI.Form.IBooleanForm, qxDotNet.UI.Form.IModel
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

        #region IRadioItem Members

        qxDotNet.UI.Form.RadioGroup qxDotNet.UI.Form.IRadioItem.Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }

        bool? qxDotNet.UI.Form.IRadioItem.Value
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
