using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    public partial class Form : qxDotNet.Core.Object
    {

        private Dictionary<object, object> _items = new Dictionary<object, object>();
        private bool _contentChanged = true;

        public void Add(IForm item, string label)
        {
            _contentChanged = true;
            var info = new itemInfo();
            info.Item = item;
            info.Label = label;
            _items.Add(item, info);
        }

        public void AddButton(qxDotNet.UI.Form.Button button)
        {
            _contentChanged = true;
            var info = new buttonInfo();
            info.button = button;
            _items.Add(button, info);
        }

        public void AddGroupHeader(string title)
        {
            _contentChanged = true;
            var info = new groupInfo();
            info.title = title;
            _items.Add(title, info);
        }

        public void Reset()
        {
            _contentChanged = true;
            _items.Clear();
        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            if (_contentChanged || !isNewOnly)
            {
                foreach (var item in _items)
                {
                    if (item.Key is IForm)
                    {
                        yield return item.Key;
                    }
                }
            }
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            if (isRefreshRequest || _contentChanged)
            {
                response.Write(GetReference() + ".reset();\n");
                foreach (var item in _items)
                {
                    if (item.Value is itemInfo)
                    {
                        var i = item.Value as itemInfo;
                        var t = i.Item as qxDotNet.Core.Object;
                        response.Write(GetReference() + ".add(" + t.GetReference() + "," + GetClientValue(i.Label) + ");\n");
                    }
                    else if (item.Value is buttonInfo)
                    {
                        var i = item.Value as buttonInfo;
                        var t = i.button as qxDotNet.Core.Object;
                        response.Write(GetReference() + ".addButton(" + t.GetReference() + ");\n");
                    }
                    else if (item.Value is groupInfo)
                    {
                        var i = item.Value as groupInfo;
                        response.Write(GetReference() + ".addGroupHeader(" + GetClientValue(i.title) + ");\n");
                    }
                }
            }
        }

        internal override void Commit()
        {
            base.Commit();
            _contentChanged = false;
        }

        internal bool ContentChanged
        {
            get
            {
                return _contentChanged;
            }
        }

        private class itemInfo
        {
            public IForm Item;
            public string Label;
            public Map Options;
        }

        private class buttonInfo
        {
            public qxDotNet.UI.Form.Button button;
            public Map options;
        }

        private class groupInfo
        {
            public string title;
            public Map options;
        }

    }
}
