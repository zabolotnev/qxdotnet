using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Window
{
   
    public partial class Window : qxDotNet.UI.Container.Composite
    {

        private bool _needToOpen;
        private bool _closed = false;

        public bool Centered { get; set; }

        public Window()
        {
            Close += new EventHandler(Window_Close);
        }

        private void Window_Close(object sender, EventArgs e)
        {
            _closed = true;
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            base.CustomPostRender(response, isRefreshRequest);
            if (_closed) return;
            if (_needToOpen || isRefreshRequest)
            {
                response.Write(GetReference() + ".open();\n");
                _needToOpen = false;
            }
        }

        protected internal override void CustomPreRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            if (!WindowClosed && Centered)
            {
                response.Write(GetReference() + ".addListener(\"appear\",function(){this.center();}, " + GetReference() + ");");
            }
            base.CustomPostRender(response, isRefreshRequest);
        }

        public void Open()
        {
            _needToOpen = true;
            _closed = false;
        }

        public bool WindowClosed
        {
            get
            {
                return _closed;
            }
        }

    }
}
