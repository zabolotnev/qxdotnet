using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Core
{

    internal class ClientMethodCall
    {

        public ClientMethodCall(string methodName)
        {
            this.MethodName = methodName;
        }

        private ClientMethodCallParameterCollection _parametars = new ClientMethodCallParameterCollection();


        internal string GetKey()
        {
            var sb = new StringBuilder();
            sb.AppendLine(MethodName);
            foreach (var item in Parameters)
            {
                if (item.KeyParameter)
                {
                    sb.AppendLine(item.GetExpression());
                }
            }
            return sb.ToString();
        }

        internal string GetExpression(qxDotNet.Core.Object target)
        {
            var sb = new StringBuilder();
            sb.Append(target.GetReference());
            sb.Append(".");
            sb.Append(MethodName);
            sb.Append("(");
            var needComma = false;

            foreach (var prm in Parameters)
            {
                if (needComma)
                {
                    sb.Append(",");
                }
                needComma = true;
                sb.Append(prm.GetExpression());
            }
            sb.Append(");\n");
            return sb.ToString();
        }

        public string MethodName { get; private set; }

        public ClientMethodCallParameterCollection Parameters
        {
            get
            {
                return _parametars;
            }
        }

        public ClientMethodCall SetParameter(object parameterValue)
        {
            _parametars.Add(new ClientMethodCallParameterExpression(parameterValue));
            return this;
        }

        public ClientMethodCall SetKeyParameter(object parameterValue)
        {
            _parametars.Add(new ClientMethodCallParameterExpression(parameterValue, true));
            return this;
        }

    }

    internal class ClientMethodCallParameterExpression
    {

        private object _clientValue;

        public string GetExpression()
        {
            return qxDotNet.Core.Object.GetClientValue(_clientValue);
        }

        public ClientMethodCallParameterExpression(object value, bool keyParameter)
        {
            this.KeyParameter = keyParameter;
            _clientValue = value;
        }

        public ClientMethodCallParameterExpression(object value)
            : this(value, false)
        {

        }

        public bool KeyParameter { get; private set; }
       
    }


    internal class ClientMethodCallParameterCollection : List<ClientMethodCallParameterExpression>
    {

    }

    internal class ClientMethodCallBag
    {

        private Dictionary<string, ClientMethodCall> _keySet = new Dictionary<string, ClientMethodCall>();

        private List<ClientMethodCall> _list = new List<ClientMethodCall>();

        public void Add(ClientMethodCall method)
        {
            var key = method.GetKey();
            if (_keySet.ContainsKey(key))
            {
                _list.Remove(_keySet[key]);
            }
            _keySet[key] = method;
            _list.Add(method);
        }

        public IEnumerable<ClientMethodCall> Get()
        {
            return _list;
        }

        public void Clear()
        {
            _keySet.Clear();
            _list.Clear();
        }

    }
}
