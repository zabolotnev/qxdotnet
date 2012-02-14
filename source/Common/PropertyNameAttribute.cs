using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Common
{
    public class PropertyNameAttribute : Attribute
    {

        public PropertyNameAttribute(string AName)
        {
            Name = AName;
        }

        public string Name { get; set; }

    }
}
