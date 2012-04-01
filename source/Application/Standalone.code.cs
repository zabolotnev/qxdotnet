using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Application
{
    public partial class Standalone : AbstractGui
    {

        private UI.Layout.Canvas _canvas;

        private string _title = "qxdotnet";
        private bool _titleChanged = false;

        public Standalone()
        {
            _canvas = new UI.Layout.Canvas();
        }

        public new UI.Container.Composite GetRoot()
        {
            return (UI.Container.Composite) base.GetRoot();
        }

        protected internal override qxDotNet.UI.Layout.Abstract getLayout()
        {
            return _canvas;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                _titleChanged = true;
            }
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            base.CustomPostRender(response, isRefreshRequest);
            if (_titleChanged || isRefreshRequest)
            {
                if (!isRefreshRequest)
                {
                    _titleChanged = false;
                }
                response.Write("window.document.title = \"" + _title.EscapeToJS() + "\";");
            }
        }

    }
}
