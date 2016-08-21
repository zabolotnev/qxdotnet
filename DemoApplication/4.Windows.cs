using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using qxDotNet;

namespace DemoApplication
{
    public partial class MainForm
    {

        private Guid _uploadFileGuid;

        private qxDotNet.UploadWidget.UploadButton uploadButton;

        private qxDotNet.UI.Tabview.Page loadPage4()
        {
            var page = new qxDotNet.UI.Tabview.Page();
            page.Layout = new qxDotNet.UI.Layout.Canvas();
            page.Label = "Window";

            var window = new qxDotNet.UI.Window.Window();
            window.Layout = new qxDotNet.UI.Layout.Canvas();

            window.Caption = "Login window";
            window.Width = 400;
            window.Height = 200;

            page.Add(window);

            var label = new qxDotNet.UI.Basic.Label();
            label.Value = "Login:";
            window.Add(label,
                new Map()
                .Add("left", 10)
                .Add("top", 10));

            var login = new qxDotNet.UI.Form.TextField();
            window.Add(login,
                new Map()
                .Add("left", 80)
                .Add("top", 10));
            login.Width = 100;

            label = new qxDotNet.UI.Basic.Label();
            label.Value = "Password:";
            window.Add(label,
                new Map()
                .Add("left", 10)
                .Add("top", 40));

            var password = new qxDotNet.UI.Form.PasswordField();
            window.Add(password,
                new Map()
                .Add("left", 80)
                .Add("top", 40));
            password.Width = 100;

            label = new qxDotNet.UI.Basic.Label();
            label.Value = "Birth date:";
            window.Add(label,
                new Map()
                .Add("left", 10)
                .Add("top", 70));

            var borndate = new qxDotNet.UI.Form.DateField();
            window.Add(borndate,
                new Map()
                .Add("left", 80)
                .Add("top", 70));
            borndate.Width = 100;

            var uploadForm = new qxDotNet.UploadWidget.UploadForm();
            uploadForm.Layout = new qxDotNet.UI.Layout.Basic();
            window.Add(uploadForm,
                new Map()
                .Add("left", 80)
                .Add("top", 70));
            //uploadForm.Width = 100;

            _uploadFileGuid = Guid.NewGuid();

            uploadForm.Name = "uploadForm";
            uploadForm.Url = "UploadFile.aspx?id=" + _uploadFileGuid.ToString();
            uploadForm.Completed += new EventHandler(uploadForm_Completed);

            uploadButton = new qxDotNet.UploadWidget.UploadButton();
            uploadButton.FieldName = "uploadField";
            uploadButton.Label = "Upload file";
            uploadForm.Add(uploadButton);
            uploadButton.Width = 250;

            var submit = new qxDotNet.UI.Form.Button();
            submit.Label = "Submit";
            window.Add(submit,
                new Map()
                .Add("left", 10)
                .Add("top", 10));

            submit.Execute += new EventHandler(submit_Execute);



            window.Open();

            return page;
        }

        void uploadForm_Completed(object sender, EventArgs e)
        {
            var stream = UploadFileHandler.Instance.GetFile(_uploadFileGuid.ToString());
            if (stream == null)
            {
                return;
            }
            //uploadField.FileName = " ";
            var rdr = new System.IO.StreamReader(stream);
            var content = rdr.ReadToEnd();
            qxDotNet.UI.Dialog.MessageBox.Show(content);
        }

        private void submit_Execute(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
        }

    }
}
