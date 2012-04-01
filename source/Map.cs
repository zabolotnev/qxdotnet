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

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Map))
            {
                return false;
            }
            var obj_ = obj as Map;
            if (Count != obj_.Count)
            {
                return false;
            }
            foreach (var item in this)
            {
                if (!obj_.ContainsKey(item.Key))
                {
                    return false;
                }
                if (!object.Equals(item.Value, obj_[item.Key]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
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
