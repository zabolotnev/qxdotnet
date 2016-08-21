using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApplication
{
    public partial class UploadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod.ToUpper() != "POST")
            {
                Response.Close();
                return;
            }
            if (string.IsNullOrEmpty(Request.Params["id"]))
            {
                Response.Close();
                return;
            }
            var id = Request.Params["id"];
            if (uploadField.PostedFile != null && uploadField.PostedFile.ContentLength >= 0)
            {
                UploadFileHandler.Instance.RegisterFile(id, uploadField.PostedFile.InputStream);
            }
        }
    }

    public class UploadFileHandler
    {
        public static UploadFileHandler Instance
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["__uploadFileHandler"] == null)
                {
                    var inst = new UploadFileHandler();
                    System.Web.HttpContext.Current.Session["__uploadFileHandler"] = inst;
                    return inst;
                }
                else
                {
                    return System.Web.HttpContext.Current.Session["__uploadFileHandler"] as UploadFileHandler;
                }
            }
        }

        private Dictionary<string, System.IO.Stream> _files = new Dictionary<string,System.IO.Stream>();

        public void RegisterFile(string id, System.IO.Stream content)
        {
            lock (_files)
            {
                _files[id] = content;
            }
        }

        public System.IO.Stream GetFile(string id)
        {
            lock (_files)
            {
                if (_files.ContainsKey(id))
                {
                    var res = _files[id];
                    _files.Remove(id);
                    return res;
                }
            }
            return null;
        }

    }

}
