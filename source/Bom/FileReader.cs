using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom
{
    /// <summary>
    /// EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION  FileReaders allow retrieving the data from a local file, after the file name was selected by an &lt;input type="file"&gt; element.  For more information see: http://www.w3.org/TR/FileAPI/
    /// </summary>
    public partial class FileReader : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.bom.FileReader";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Abort != null)
            {
                state.SetEvent("abort", false);
            }
            if (Error != null)
            {
                state.SetEvent("error", false);
            }
            if (Load != null)
            {
                state.SetEvent("load", false);
            }
            if (Loadend != null)
            {
                state.SetEvent("loadend", false);
            }
            if (Loadstart != null)
            {
                state.SetEvent("loadstart", false);
            }
            if (Progress != null)
            {
                state.SetEvent("progress", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "abort")
            {
                OnAbort();
            }
            if (eventName == "error")
            {
                OnError();
            }
            if (eventName == "load")
            {
                OnLoad();
            }
            if (eventName == "loadend")
            {
                OnLoadend();
            }
            if (eventName == "loadstart")
            {
                OnLoadstart();
            }
            if (eventName == "progress")
            {
                OnProgress();
            }
        }

        protected virtual void OnAbort()
        {
            if (Abort != null)
            {
                Abort.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when progression has failed, after the last "progress" has been dispatched, or after "loadstart" has been dispatched, if "progress" has not been dispatched"
        /// </summary>
        public event EventHandler Abort;

        protected virtual void OnError()
        {
            if (Error != null)
            {
                Error.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when an error occurs
        /// </summary>
        public event EventHandler Error;

        protected virtual void OnLoad()
        {
            if (Load != null)
            {
                Load.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when progression is successful
        /// </summary>
        public event EventHandler Load;

        protected virtual void OnLoadend()
        {
            if (Loadend != null)
            {
                Loadend.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when progress has stopped, after any of "error", "abort", or "load" have been dispatched.
        /// </summary>
        public event EventHandler Loadend;

        protected virtual void OnLoadstart()
        {
            if (Loadstart != null)
            {
                Loadstart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when progress has begun.
        /// </summary>
        public event EventHandler Loadstart;

        protected virtual void OnProgress()
        {
            if (Progress != null)
            {
                Progress.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired while making progress, presumably at a minimum of every 50ms
        /// </summary>
        public event EventHandler Progress;

    }
}
