using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet
{
    public class Map : Dictionary<string, object>
    {
        public new Map Add(string key, object value)
        {
            base.Add(key, value);
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("{");
            var isNotFirst = false;
            foreach (var item in this)
            {
                if (item.Value == null)
                {
                    continue;
                }
                if (isNotFirst)
                {
                    sb.Append(",");
                }

                sb.Append(item.Key);
                sb.Append(":");

                if (item.Value is string)
                {
                    sb.Append("\"");
                    sb.Append(((string)item.Value).Replace("\"", "\""));
                    sb.Append("\"");
                }
                else
                {
                    sb.Append(item.Value.ToString());
                }

                isNotFirst = true;
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}
