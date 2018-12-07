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

        internal ISelectionModelMapper _mapper;

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
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
                    if (_mapper != null)
                    {
                        int v;
                        int.TryParse(s2[0], out v);
                        _selectedIndex = _mapper.MapToUser(v);
                    }
                    else
                    {
                        int.TryParse(s2[0], out _selectedIndex);
                    }
                }
                OnPropertyChanged("SelectedIndex");
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
                var v = _selectedIndex;
                if (_mapper != null)
                {
                    v = _mapper.MapToNative(v);
                }
                return this.GetReference() + ".setSelectionInterval(" + v + "," + v + ");";
            }
            else
            {
                return base.GetSetPropertyValueExpression(name, value);
            }
        }

    }

    internal interface ISelectionModelMapper
    {
        int MapToUser(int nativeIndex);

        int MapToNative(int userIndex);

    }

}
