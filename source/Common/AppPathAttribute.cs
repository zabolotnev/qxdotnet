using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet
{
    public class AppPathAttribute : Attribute 
    {

        private string _path;

        public AppPathAttribute(string APath)
        {
            _path = APath;
        }

        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }

    }
}
