using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Basic
{
    /// <summary>
    /// The image class displays an image file
    /// 
    /// This class supports image clipping, which means that multiple images can be combined
    /// into one large image and only the relevant part is shown.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  var image = new qx.ui.basic.Image("icon/32/actions/format-justify-left.png");
    /// 
    ///  this.getRoot().add(image);
    /// 
    /// 
    /// This example create a widget to display the image
    /// icon/32/actions/format-justify-left.png.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Image : qxDotNet.UI.Core.Widget
    {

        private bool? _scale = false;
        private string _source = null;


        /// <summary>
        /// Whether the image should be scaled to the given dimensions
        /// 
        /// This is disabled by default because it prevents the usage
        /// of image clipping when enabled.
        /// 
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
        /// The URL of the image. Setting it will possibly abort loading of current image.
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.basic.Image";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scale", _scale, false);
            state.SetPropertyValue("source", _source, null);

            if (Aborted != null)
            {
                state.SetEvent("aborted", false);
            }
            if (Loaded != null)
            {
                state.SetEvent("loaded", false);
            }
            if (LoadingFailed != null)
            {
                state.SetEvent("loadingFailed", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "aborted")
            {
                OnAborted();
            }
            if (eventName == "loaded")
            {
                OnLoaded();
            }
            if (eventName == "loadingFailed")
            {
                OnLoadingFailed();
            }
        }

        /// <summary>
        /// Raises event 'Aborted'
        /// </summary>
        protected virtual void OnAborted()
        {
            if (Aborted != null)
            {
                Aborted.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the pending request has been aborted.
        /// 
        /// </summary>
        public event EventHandler Aborted;

        /// <summary>
        /// Raises event 'ChangeSource'
        /// </summary>
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

        /// <summary>
        /// Raises event 'Loaded'
        /// </summary>
        protected virtual void OnLoaded()
        {
            if (Loaded != null)
            {
                Loaded.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the image has been loaded. This is even true for managed
        /// resources (images known by generator).
        /// 
        /// </summary>
        public event EventHandler Loaded;

        /// <summary>
        /// Raises event 'LoadingFailed'
        /// </summary>
        protected virtual void OnLoadingFailed()
        {
            if (LoadingFailed != null)
            {
                LoadingFailed.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the image source can not be loaded. This event can only be
        /// fired for the first loading of an unmanaged resource (external image).
        /// 
        /// </summary>
        public event EventHandler LoadingFailed;

    }
}
