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

            
            var grid = new qxDotNet.UI.Layout.Grid();
            grid.SpacingX = 20;
            grid.SpacingY = 20;
            page.Layout = grid;
            page.PaddingBottom = 10;
            page.PaddingLeft = 10;
            page.PaddingRight = 10;
            page.PaddingTop = 10;
            var tabIndex = 1;

            /*****************************************
             * TEXT INPUT
             ****************************************/

            var form = new qxDotNet.UI.Form.Form();

            var textGroupBox = new qxDotNet.UI.Groupbox.GroupBox();
            textGroupBox.Legend = "Text";
            textGroupBox.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Add(textGroupBox, new Map()
                .Add("row", 0)
                .Add("column", 0));

            // text field
            var textField = new qxDotNet.UI.Form.TextField();
            textField.Placeholder = "required";
            textField.TabIndex = tabIndex++;
            textField.Required = true;
            form.Add(textField, "TextField");

            // password field
            var passwordField = new qxDotNet.UI.Form.PasswordField();
            passwordField.TabIndex = tabIndex++;
            textField.Required = true;
            form.Add(passwordField, "PasswordField");

            // text area
            var textArea = new qxDotNet.UI.Form.TextArea();
            textArea.Placeholder = "placeholder test...";
            textArea.TabIndex = tabIndex++;
            form.Add(textArea, "TextArea");

            // combo box
            var comboBox = new qxDotNet.UI.Form.ComboBox();
            comboBox.TabIndex = tabIndex++;
            this.createItems(comboBox);
            form.Add(comboBox, "ComboBox");

            // virtual combo box
            var virtualComboBox = new qxDotNet.UI.Form.VirtualComboBox();
            virtualComboBox.TabIndex = tabIndex++;
            //this.__createItemsVirtual(virtualComboBox);
            form.Add(virtualComboBox, "VirtualComboBox");

            // date field
            var dateField = new qxDotNet.UI.Form.DateField();
            dateField.TabIndex = tabIndex++;
            form.Add(dateField, "DateField");

            var renderedForm = new qxDotNet.UI.Form.Renderer.Single(form);
            textGroupBox.Add(renderedForm);

            /*****************************************
            * SELECTION
            ****************************************/

            form = new qxDotNet.UI.Form.Form();

            var selectionGroupBox = new qxDotNet.UI.Groupbox.GroupBox();
            selectionGroupBox.Legend = "Selection";
            selectionGroupBox.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Add(selectionGroupBox, new Map()
                .Add("row", 1)
                .Add("column", 0)
                .Add("rowSpan", 2));

            // select box
            var selectBox = new qxDotNet.UI.Form.SelectBox();
            selectBox.TabIndex = tabIndex++;
            form.Add(selectBox, "SelectBox");
            this.createItems(selectBox);

            // virtual select box
            var virtualSelectBox = new qxDotNet.UI.Form.VirtualSelectBox();
            virtualSelectBox.TabIndex = tabIndex++;
            //form.Add(virtualSelectBox, "VirtualSelectBox");
            //this.__createItemsVirtual(virtualSelectBox);

            // list
            var list = new qxDotNet.UI.Form.List();
            list.TabIndex = tabIndex++;
            list.Height = 60;
            list.Width = 155;
            form.Add(list, "List");
            this.createListItems(list);

            // radio button group
            var radioButtonGroup = new qxDotNet.UI.Form.RadioButtonGroup();
            radioButtonGroup.Add(
                new qxDotNet.UI.Form.RadioButton()
                    { Label = "RadioButton 1", TabIndex = tabIndex++});
            radioButtonGroup.Add(
                new qxDotNet.UI.Form.RadioButton()
                    { Label = "RadioButton 2", TabIndex = tabIndex++});
            radioButtonGroup.Add(
                new qxDotNet.UI.Form.RadioButton()
                    { Label = "RadioButton 3", TabIndex = tabIndex++});
            form.Add(radioButtonGroup, "RadioButtonGroup");

            renderedForm = new qxDotNet.UI.Form.Renderer.Single(form);
            selectionGroupBox.Add(renderedForm);

            /*****************************************
            * BUTTONS
            ****************************************/

            var buttonGroupBox = new qxDotNet.UI.Groupbox.GroupBox();
            buttonGroupBox.Legend = "Buttons";
            var layout = new qxDotNet.UI.Layout.Grid();
            layout.SpacingX = 8;
            layout.SpacingY = 8;
            buttonGroupBox.Layout = layout;
            //layout.setColumnAlign(0, "right", "middle");
            page.Add(buttonGroupBox, new Map()
                .Add("row", 0)
                .Add("column", 1));

            // button
            var button = new qxDotNet.UI.Form.Button();
            button.Label = "Button";
            button.TabIndex = tabIndex++;
            var label = new qxDotNet.UI.Basic.Label();
            label.Value = "Button :";
            label.Buddy = button;
            buttonGroupBox.Add(label, new Map()
                .Add("row", 0)
                .Add("column", 0));
            buttonGroupBox.Add(button, new Map()
                .Add("row", 0)
                .Add("column", 1));

            // toggle button
            var toggleButton = new qxDotNet.UI.Form.ToggleButton();
            toggleButton.Label = "ToggleButton";
            toggleButton.TabIndex = tabIndex++;
            label = new qxDotNet.UI.Basic.Label();
            label.Value = "ToggleButton :";
            label.Buddy = toggleButton;
            buttonGroupBox.Add(label, new Map()
                .Add("row", 1)
                .Add("column", 0));
            buttonGroupBox.Add(toggleButton, new Map()
                .Add("row", 1)
                .Add("column", 1));

            // toggle button
            var repeatButton = new qxDotNet.UI.Form.RepeatButton();
            repeatButton.TabIndex = tabIndex++;
            repeatButton.Label = "0";
            label = new qxDotNet.UI.Basic.Label();
            label.Value = "RepeatButton :";
            label.Buddy = repeatButton;
            buttonGroupBox.Add(label, new Map()
                .Add("row", 2)
                .Add("column", 0));
            buttonGroupBox.Add(repeatButton, new Map()
                .Add("row", 2)
                .Add("column", 1));

            // menu button
            var menueButton = new qxDotNet.UI.Form.MenuButton();
            menueButton.Label = "MenuButton";
            menueButton.TabIndex = tabIndex++;
            label = new qxDotNet.UI.Basic.Label();
            label.Value = "MenuButton :";
            label.Buddy = menueButton;
            buttonGroupBox.Add(label, new Map()
                .Add("row", 3)
                .Add("column", 0));
            buttonGroupBox.Add(menueButton, new Map()
                .Add("row", 3)
                .Add("column", 1));

            // split button
            var splitButton = new qxDotNet.UI.Form.SplitButton();
            splitButton.Label = "SplitButton";
            splitButton.TabIndex = tabIndex++;
            label = new qxDotNet.UI.Basic.Label();
            label.Value = "SplitButton :";
            label.Buddy = splitButton;
            buttonGroupBox.Add(label, new Map()
                .Add("row", 4)
                .Add("column", 0));
            buttonGroupBox.Add(splitButton, new Map()
                .Add("row", 4)
                .Add("column", 1));

            // Listener
            repeatButton.Execute += new EventHandler(repeatButton_Execute);

            /*****************************************
            * BOOLEAN INPUT
            ****************************************/

            form = new qxDotNet.UI.Form.Form();

            var booleanGroupBox = new qxDotNet.UI.Groupbox.GroupBox();
            booleanGroupBox.Legend = "Boolean";
            booleanGroupBox.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Add(booleanGroupBox, new Map()
                .Add("row", 1)
                .Add("column", 1));

            // check box
            var checkBox = new qxDotNet.UI.Form.CheckBox();
            checkBox.TabIndex = tabIndex++;
            form.Add(checkBox, "CheckBox");

            // tri-state check box
            var triCheckBox = new qxDotNet.UI.Form.CheckBox();
            triCheckBox.TabIndex = tabIndex++;
            triCheckBox.TriState = true;
            triCheckBox.Value = null;
            form.Add(triCheckBox, "Tri-State CheckBox");

            // radio button
            var radioButton = new qxDotNet.UI.Form.RadioButton();
            radioButton.TabIndex = tabIndex++;
            form.Add(radioButton, "RadioButton");

            renderedForm = new qxDotNet.UI.Form.Renderer.Single(form);
            booleanGroupBox.Add(renderedForm);

            /*****************************************
            * NUMBER INPUT
            ****************************************/

            form = new qxDotNet.UI.Form.Form();

            var numberGroupBox = new qxDotNet.UI.Groupbox.GroupBox();
            numberGroupBox.Legend = "Number";
            numberGroupBox.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Add(numberGroupBox, new Map()
                .Add("row", 2)
                .Add("column", 1));

            // spinner
            var spinner = new qxDotNet.UI.Form.Spinner();
            spinner.Minimum = 0;
            spinner.Value = 50;
            spinner.Maximum = 100;
            spinner.TabIndex = tabIndex++;
            form.Add(spinner, "Spinner");

            // slider
            var slider = new qxDotNet.UI.Form.Slider();
            slider.TabIndex = tabIndex++;
            slider.Width = 130;
            form.Add(slider, "Slider");

            slider.Bind("value", spinner, "value");
            spinner.Bind("value", slider, "value");

            renderedForm = new qxDotNet.UI.Form.Renderer.Single(form);
            numberGroupBox.Add(renderedForm);
            
            return page;
        }

        void repeatButton_Execute(object sender, EventArgs e)
        {
            var repeatButton = sender as qxDotNet.UI.Form.RepeatButton;
            var tempValue = int.Parse(repeatButton.Label) + 1;
            repeatButton.Label = tempValue.ToString();
        }

        private void createItems(qxDotNet.UI.Form.AbstractSelectBox widget)
        {
            for (var i = 0; i < 10; i++) {
                var tempItem = new qxDotNet.UI.Form.ListItem();
                tempItem.Label = "Item " + i;
                widget.Add(tempItem);
            }
        }

        private void createListItems(qxDotNet.UI.Form.List widget)
        {
            for (var i = 0; i < 10; i++) {
                var tempItem = new qxDotNet.UI.Form.ListItem();
                tempItem.Label = "Item " + i;
                widget.Add(tempItem);
            }
        }

    //__createItemsVirtual: function(widget)
    //{
    //  // Creates the model data
    //  var model = new qx.data.Array();
    //  for (var i = 0; i < 300; i++) {
    //    model.push("Item " + (i));
    //  }
    //  widget.setModel(model);
    //},


    //__createMenuForMenuButton : function()
    //{
    //  // Creates the option menu
    //  var optionMenu = new qx.ui.menu.Menu;

    //  for (var i = 0; i < 3; i++) {
    //    optionMenu.add(new qx.ui.menu.RadioButton("Option" + i));
    //  }

    //  var groupOptions = new qx.ui.form.RadioGroup;
    //  groupOptions.add.apply(groupOptions, optionMenu.getChildren());

    //  // create main menu and buttons
    //  var menu = new qx.ui.menu.Menu();

    //  for (i = 0; i < 3; i++) {
    //    var tempButton = new qx.ui.menu.Button("Button" + i);
    //    menu.add(tempButton);
    //  }

    //  var optionButton = new qx.ui.menu.Button("Options", "", null, optionMenu);
    //  menu.addSeparator();
    //  menu.add(optionButton);

    //  return menu;
    //},


    //__createMenuForSplitButton : function()
    //{
    //  var menu = new qx.ui.menu.Menu;

    //  var site1 = new qx.ui.menu.Button("Website 1");
    //  var site2 = new qx.ui.menu.Button("Website 2");
    //  var site3 = new qx.ui.menu.Button("Website 3");

    //  menu.add(site1);
    //  menu.add(site2);
    //  menu.add(site3);

    //  return menu;
    //},


    }
}
