using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qxDotNet;

namespace DemoApplication
{
    
    [AppPath("MainForm.ashx")]
    public partial class MainForm : qxDotNet.Application.Standalone
    {


        private qxDotNet.UI.Container.Composite dock;
        private qxDotNet.UI.Tabview.TabView tabs;

        public override void Main()
        {

            // window title
            this.Title = "qxdotnet DemoApplication";

            // this is a root element
            var root = GetRoot();

            // using dock container for menu and toolbar
            dock = new qxDotNet.UI.Container.Composite(new qxDotNet.UI.Layout.Dock());
            root.Add(dock,
                new Map()
                .Add("left", 0)
                .Add("top", 0)
                .Add("width", "100%")
                .Add("height", "100%"));

            // create the main menubar
            var menubar = new qxDotNet.UI.Menubar.MenuBar();

            // create "Help" menu
            var menuHelp = new qxDotNet.UI.Menubar.Button();
            menuHelp.Label = "Help";
            menubar.Add(menuHelp);

            // and it's content
            var subMenuItems = new qxDotNet.UI.Menu.Menu();
            menuHelp.Menu = subMenuItems;

            // create "About" menu
            var menuAbout = new qxDotNet.UI.Menu.Button();
            menuAbout.Label = "About";
            menuAbout.Execute += new EventHandler(menuAbout_Execute);
            
            
            // add it under "File" menu
            subMenuItems.Add(menuAbout);

            // add menubar at a top of the form
            dock.Add(menubar,
                    new Map()
                    .Add("edge", "north"));

            // create a toolbar
            var toolbar = new qxDotNet.UI.Toolbar.ToolBar();
            dock.Add(toolbar,
                new Map()
                .Add("edge", "north"));

            // and add a button to the toolbar
            var toolbtn = new qxDotNet.UI.Toolbar.Button();
            toolbtn.Label = "click me";
            toolbtn.Icon = "resource/images/test.png";
            toolbtn.Execute += new EventHandler(toolbtn_Execute);
            toolbar.Add(toolbtn);

            // now let's create a tabview. It's like a TabControl
            tabs = new qxDotNet.UI.Tabview.TabView();
            dock.Add(tabs,
                new Map()
                .Add("edge", "center"));

            // page 1. Form controls
            tabs.Add(loadPage1());

            // page 2. Data table
            tabs.Add(loadPage2());

            // page 3. Progress bar and timer
            tabs.Add(loadPage3());

            //// this is a page 1
            //page = new qxDotNet.UI.Tabview.Page();
            //page.Layout = new qxDotNet.UI.Layout.Canvas();
            //page.Label = "page 1";
            //tabs.Add(page);
            
            //// scroll control in page 1
            //var scr = new qxDotNet.UI.Container.Scroll();
            //page.Add(scr,
            //    new Map()
            //    .Add("left", 0)
            //    .Add("top", 0)
            //    .Add("width", "100%")
            //    .Add("height", "100%"));

            //// it is for content of scroll control
            //var cm1 = new qxDotNet.UI.Container.Composite(new qxDotNet.UI.Layout.Flow());
            //scr.Add(cm1);

            //// children controls inside of this container supports X,Y coordinates
            //var cm2 = new qxDotNet.UI.Container.Composite(new qxDotNet.UI.Layout.Canvas());
            //cm1.Add(cm2);

            //// add a label
            //label = new qxDotNet.UI.Basic.Label();
            //label.Value = "Enter value here:";

            //cm2.Add(label,
            //    new Map()
            //    .Add("left", 50)
            //    .Add("top", 50));

            //// and a textbox
            //text = new qxDotNet.UI.Form.DateField();
            //text.Width = 200;
            //cm2.Add(text,
            //    new Map()
            //    .Add("left", 150)
            //    .Add("top", 50));
            //text.Value = DateTime.Today;
            //text.DateFormat = new qxDotNet.Util.Format.DateFormat("HH.mm");


            //// button underneath
            //btn = new qxDotNet.UI.Form.Button();
            //btn.Label = "push me";
            //cm2.Add(btn, 
            //    new Map()
            //    .Add("left", 50)
            //    .Add("top", 80));
            //btn.Execute += new EventHandler(btn_Execute);

            //// empty page for tabcontrol for example
            //page2 = new qxDotNet.UI.Tabview.Page();
            //page2.Layout = new qxDotNet.UI.Layout.Grow();
            //page2.Label = "page 2";
            //tabs.Add(page2);

            //var table = new qxDotNet.UI.Table.Table();
            //var c = new qxDotNet.UI.Table.Column();
            //c.Name = "First name";
            //c.Field = "FirstName";
            //c.Width = 200;
            //table.Columns.Add(c);
            //c = new qxDotNet.UI.Table.Column();
            //c.Name = "Last name";
            //c.Field = "LastName";
            //c.Width = 300;
            //table.Columns.Add(c);

            //var d = new List<testData>();

            //var r = new testData();
            //r.FirstName = "john";
            //r.LastName = "doe";
            //d.Add(r);

            //r = new testData();
            //r.FirstName = "will";
            //r.LastName = "smith";
            //d.Add(r);

            //table.DataSource = d;

            //page2.Add(table);

        }

        private void menuAbout_Execute(object sender, EventArgs e)
        {
            qxDotNet.UI.Dialog.MessageBox.Show("qxdotnet DemoApplication. Based on qooxdoo 1.6");
        }

        private void toolbtn_Execute(object sender, EventArgs e)
        {
            qxDotNet.UI.Dialog.MessageBox.Show(
                "Yes or no?", 
                "Some question", 
                qxDotNet.UI.Dialog.MessageBoxButtonsEnum.YesNoCancel, 
                qxDotNet.UI.Dialog.MessageBoxIconEnum.Question,
                qxDotNet.UI.Dialog.MessageBoxDefaultButtonEnum.Button3,
                AnswerTheQuestion);
        }

        private void AnswerTheQuestion(qxDotNet.UI.Dialog.DialogResultEnum result)
        {
            switch (result)
            {
                case qxDotNet.UI.Dialog.DialogResultEnum.Yes:
                    qxDotNet.UI.Dialog.MessageBox.Show("Yes, it is");
                    break;
                case qxDotNet.UI.Dialog.DialogResultEnum.No:
                    qxDotNet.UI.Dialog.MessageBox.Show("No, it is not");
                    break;
            }
        }

    }
}
