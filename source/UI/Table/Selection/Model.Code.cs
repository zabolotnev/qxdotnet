using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Selection
{

    public partial class Model : qxDotNet.Core.Object
    {

        private int _selectedIndex = -1;

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
            }
        }

        protected internal override void SetPropertyValue(string name, string value)
        {
            if (name == "selectedRanges")
            {
                if (value == null)
                {
                    _selectedIndex = -1;
                }
                else
                {
                    var s1 = value.Split(';');
                    var s2 = s1[0].Split(',');
                    int.TryParse(s2[0], out _selectedIndex);
                }
            }
            else
            {
                base.SetPropertyValue(name, value);
            }
        }

        protected internal override string GetGetPropertyAccessor(string name, bool isRef)
        {
            if (name == "selectedRanges")
            {
                return "App.gts(" + this.GetReference() + ".getSelectedRanges())";
            }
            else
            {
                return base.GetGetPropertyAccessor(name, isRef);
            }
        }

        protected internal override string GetSetPropertyValueExpression(string name, object value)
        {
            if (name == "selection")
            {
                return this.GetReference() + ".setSelectionInterval(" + _selectedIndex + "," + _selectedIndex + ");";
            }
            else
            {
                return base.GetSetPropertyValueExpression(name, value);
            }
        }

    }
}
