using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Basic
{
    /// <summary>
    /// The image widget displays an image file.  Example  Here is a little example of how to use the widget.    var image = new qx.ui.mobile.basic.Image(\path/to/icon.png\);   this.getRoot().add(image);   This example create a widget to display the image path/to/icon.png.
    /// </summary>
    public partial class Image : qxDotNet.UI.Mobile.Core.Widget
    {

        private string _source = null;


        /// <summary>
        /// The URL of the image to display.
        /// </summary>
        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
               _source = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.basic.Image";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("source", _source, null);

            if (Loaded != null)
            {
                state.SetEvent("loaded", false);
            }
            if (LoadingFailed != null)
            {
                state.SetEvent("loadingFailed", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "loaded")
            {
                OnLoaded();
            }
            if (eventName == "loadingFailed")
            {
                OnLoadingFailed();
            }
        }

        protected virtual void OnLoaded()
        {
            if (Loaded != null)
            {
                Loaded.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the image has been loaded.
        /// </summary>
        public event EventHandler Loaded;

        protected virtual void OnLoadingFailed()
        {
            if (LoadingFailed != null)
            {
                LoadingFailed.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the image source can not be loaded.
        /// </summary>
        public event EventHandler LoadingFailed;

    }
}
