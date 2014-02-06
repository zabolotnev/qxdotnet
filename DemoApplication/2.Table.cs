using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qxDotNet;

namespace DemoApplication
{
    public partial class MainForm
    {

        private qxDotNet.UI.Tabview.Page loadPage2()
        {
            var page = new qxDotNet.UI.Tabview.Page();
            page.Layout = new qxDotNet.UI.Layout.Dock();
            page.Label = "Data table";

            var data = new List<SampleData>();

            var rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                var row = new SampleData();
                row.Code = i;
                row.Name = "Name of " + rnd.Next(100);
                row.Desc = "Description " + rnd.Next(100);
                data.Add(row);
            }

            var table = new qxDotNet.UI.Table.Table();
            page.Add(table, new Map()
                .Add("edge", "center"));

            var column = new qxDotNet.UI.Table.Column();
            column.Name = "Code";
            column.Field = "Code";
            table.Columns.Add(column);

            column = new qxDotNet.UI.Table.Column();
            column.Name = "Name";
            column.Field = "Name";
            table.Columns.Add(column);

            column = new qxDotNet.UI.Table.Column();
            column.Name = "Description";
            column.Field = "Desc";
            column.Width = 350;
            table.Columns.Add(column);

            table.DataSource = data;

            return page;
        }

    }

    public class SampleData
    {

        public int Code { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

    }

}
