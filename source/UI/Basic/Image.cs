using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Basic
{
    /// <summary>
    /// The image class displays an image file  This class supports image clipping, which means that multiple images can be combined into one large image and only the relevant part is shown.  Example  Here is a little example of how to use the widget.    var image = new qx.ui.basic.Image(\icon/32/actions/format-justify-left.png\);   this.getRoot().add(image);   This example create a widget to display the image icon/32/actions/format-justify-left.png.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Image : qxDotNet.UI.Core.Widget
    {

        private bool? _scale = false;
        private string _source = null;


        /// <summary>
        /// Whether the image should be scaled to the given dimensions  This is disabled by default because it prevents the usage of image clipping when enabled.
        /// </summary>
        public bool? Scale
        {
            get
            {
                return _scale;
            }
            set
            {
               _scale = value;
            }
        }

        /// <summary>
        /// The URL of the image
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
               OnChangeSource();
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.basic.Image";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scale", _scale, false);
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

        protected virtual void OnChangeSource()
        {
            if (ChangeSource != null)
            {
                ChangeSource.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #source}.
        /// </summary>
        public event EventHandler ChangeSource;

        protected virtual void OnLoaded()
        {
            if (Loaded != null)
            {
                Loaded.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the image has been loaded.  Attention: This event is only used for images which are loaded externally (aka unmanaged images).
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
        /// Fired if the image source can not be loaded.  Attention: This event is only used for images which are loaded externally (aka unmanaged images).
        /// </summary>
        public event EventHandler LoadingFailed;

    }
}
