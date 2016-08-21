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

        private qxDotNet.UI.Container.Composite root;
        private qxDotNet.UI.Container.Composite dock;
        private qxDotNet.UI.Tabview.TabView tabs;

        public override void Main()
        {

            // window title
            this.Title = "qxdotnet DemoApplication";

            // this is a root element
            root = GetRoot();

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
            var tab = loadPage2();
            tabs.Add(tab);

            // page 3. Progress bar and timer
            tabs.Add(loadPage3());

            // page 4. Windows
            tabs.Add(loadPage4());
        }

        private void menuAbout_Execute(object sender, EventArgs e)
        {
            qxDotNet.UI.Dialog.MessageBox.Show("qxdotnet DemoApplication. Based on qooxdoo 5.0.1");
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
