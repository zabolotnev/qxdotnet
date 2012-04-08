using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qxDotNet;

namespace DemoApplication
{
    public partial class MainForm
    {

        private qxDotNet.UI.Tabview.Page loadPage1()
        {
            var page = new qxDotNet.UI.Tabview.Page();
            page.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Label = "Form";

            var label = new qxDotNet.UI.Basic.Label();
            label.Value = "Login:";
            page.Add(label,
                new Map()
                .Add("left", 10)
                .Add("top", 10));

            var login = new qxDotNet.UI.Form.TextField();
            page.Add(login,
                new Map()
                .Add("left", 80)
                .Add("top", 10));
            login.Width = 100;

            label = new qxDotNet.UI.Basic.Label();
            label.Value = "Password:";
            page.Add(label,
                new Map()
                .Add("left", 10)
                .Add("top", 40));

            var password = new qxDotNet.UI.Form.PasswordField();
            page.Add(password,
                new Map()
                .Add("left", 80)
                .Add("top", 40));
            password.Width = 100;

            label = new qxDotNet.UI.Basic.Label();
            label.Value = "Birth date:";
            page.Add(label,
                new Map()
                .Add("left", 10)
                .Add("top", 70));

            var borndate = new qxDotNet.UI.Form.DateField();
            page.Add(borndate,
                new Map()
                .Add("left", 80)
                .Add("top", 70));
            borndate.Width = 100;

            var submit = new qxDotNet.UI.Form.Button();
            submit.Label = "Submit";
            page.Add(submit,
                new Map()
                .Add("left", 80)
                .Add("top", 100));

            submit.Execute += new EventHandler(submit_Execute);

            return page;
        }

        private void submit_Execute(object sender, EventArgs e)
        {
            tabs.Selection = tabs.Pages[1];
        }

    }
}
