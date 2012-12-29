using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Application
{
    public abstract partial class AbstractGui : Core.Object, IApplication
    {

        private UI.Container.Composite _container;
        private List<WeakReference> _timers;
        private List<URLInfo> _openURL = new List<URLInfo>();
        

        public AbstractGui()
        {
            _container = new rootContainer();
            _timers = new List<WeakReference>();
        }

        protected internal abstract qxDotNet.UI.Layout.Abstract getLayout();
        

        public virtual void Main()
        {

        }

        public virtual void ProcessRequest()
        {

        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            if (isNewOnly)
            {
                yield return null;
            }
            else
            {
                yield return _container;
                foreach (var timerRef in _timers)
                {
                    var timer = timerRef.Target;
                    if (timer != null)
                    {
                        yield return timer;
                    }
                }
            }
        }

        internal override bool DisallowCreation
        {
            get
            {
                return true;
            }
        }

        public UI.Core.Widget GetRoot()
        {
            return _container;
        }

        private class rootContainer : UI.Container.Composite
        {

            protected internal override string GetReference()
            {
                return "root";
            }

            internal override bool DisallowCreation
            {
                get
                {
                    return true;
                }
            }

        }

        internal void RegisterTimer(Event.Timer timer)
        {
            var wr = new WeakReference(timer);
            _timers.Add(wr);
        }

        public void Open(string URL, bool blank)
        {
            var rec = new URLInfo();
            rec.path = URL;
            rec.isBlank = blank;
            _openURL.Add(rec);
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            base.CustomPostRender(response, isRefreshRequest);
            foreach (var rec in _openURL)
            {
                if (rec.isBlank)
                {
                    response.Write("window.open('" + rec.path + "', '_blank');");
                }
                else
                {
                    response.Write("window.open('" + rec.path + "');");
                }
            }
            _openURL.Clear();
        }

        private class URLInfo
        {
            public string path;

            public bool isBlank;
        }


    }
}
