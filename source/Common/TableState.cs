using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace qxDotNet.Common
{
    internal class TableState
    {

        private TableState()
        { }

        public static TableState Instance
        {
            get
            {
                var session = System.Web.HttpContext.Current.Session;
                if (session["__qxTableState"] == null)
                {
                    var ts = new TableState();
                    session["__qxTableState"] = ts;
                    return ts;
                }
                return (session["__qxTableState"] as TableState);
            }
        }

        private Dictionary<long, WeakReference> _models = new Dictionary<long,WeakReference>();

        internal void RegisterModel(UI.Table.RemoteModel model)
        {
            lock (_models)
            {
                var r = new WeakReference(model);
                _models[model.clientId] = r;
            }
        }

        internal void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            var method = context.Request.Params["m"];
            var sId = context.Request.Params["id"];
            long id;
            if (!long.TryParse(sId, out id))
            {
                return;
            }
            if (!_models.ContainsKey(id))
            {
                return;
            }
            switch (method)
            {
                case "cnt":
                    ProcessCountMethod(id, context);
                    break;
                case "d" :
                    ProcessDataMethod(id, context);
                    break;
            }
        }

        internal void ProcessCountMethod(long id, HttpContext context)
        {
            lock (_models)
            {
                if (_models.ContainsKey(id))
                {
                    var model = _models[id].Target as UI.Table.RemoteModel;
                    if (model == null)
                    {
                        return;
                    }
                    context.Response.Write(model.GetRowCount().ToString());
                }
            }
        }

        internal void ProcessDataMethod(long id, HttpContext context)
        {
            lock (_models)
            {
                if (_models.ContainsKey(id))
                {
                    var model = _models[id].Target as UI.Table.RemoteModel;
                    if (model == null)
                    {
                        _models.Remove(id);
                        return;
                    }

                    var sortOrder = context.Request.Params["so"];
                    var sortColumnIndex = context.Request.Params["si"];

                    if (!string.IsNullOrEmpty(sortOrder) && !string.IsNullOrEmpty(sortColumnIndex))
                    {
                        var intSortIndex = 0;
                        if (int.TryParse(sortColumnIndex, out intSortIndex))
                        {
                            model.Sort(intSortIndex, sortOrder == "desc");
                        }
                    }

                    var sFrom = context.Request.Params["f"];
                    var sTo = context.Request.Params["t"];

                    int from;
                    int to;

                    if (!int.TryParse(sFrom, out from))
                    {
                        return;
                    }

                    if (!int.TryParse(sTo, out to))
                    {
                        return;
                    }

                    var data = model.GetRowData();
                    var sb = new StringBuilder();
                    sb.Append("[");

                    var colums = model.GetColumnsCount();
                    var fRow = false;
                    for (int i = from; i <= to; i++)
                    {
                        if (i < 0 || i >= data.Count)
                        {
                            break;
                        }
                        var row = data[i];
                        if (fRow)
                        {
                            sb.Append(",");
                        }
                        fRow = true;
                        sb.Append("{");
                        var fCol = false;
                        for (int c = 0; c < colums; c++)
                        {
                            if (fCol)
                            {
                                sb.Append(",");
                            }
                            fCol = true;
                            sb.Append("\"c" + c + "\":");
                            var format = model.GetColumnFormat(c);
                            if (string.IsNullOrEmpty(format))
                            {
                                sb.Append(model.GetClientValue(Convert.ToString(row.GetValue(c))));
                            }
                            else
                            {
                                var value = row.GetValue(c);
                                try
                                {
                                    value = string.Format("{0: " + format + "}", value);
                                }
                                catch { }
                                sb.Append(model.GetClientValue(value));
                            }
                            
                        }
                        sb.Append("}");
                    }

                    sb.Append("]");

                    context.Response.Write(sb.ToString());
                }
            }
        }

    }
}
