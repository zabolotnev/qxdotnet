using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Embed
{
    /// <summary>
    /// The Flash widget embeds the HMTL Flash element
    /// 
    /// </summary>
    public partial class Flash : qxDotNet.UI.Core.Widget
    {

        private qxDotNet.AllowScriptAccessEnum _allowScriptAccess = AllowScriptAccessEnum.sameDomain;
        private string _id = "";
        private bool? _liveConnect = true;
        private int _loadTimeout = 10000;
        private bool? _loop = false;
        private bool? _mayScript = false;
        private bool? _menu = false;
        private bool? _play = false;
        private qxDotNet.QualityEnum _quality = QualityEnum.best;
        private qxDotNet.ScaleEnum _scale = (ScaleEnum)(-1);
        private string _source = "";
        private Map _variables = null;
        private qxDotNet.WmodeEnum _wmode = WmodeEnum.opaque;


        /// <summary>
        /// Set allow script access
        /// 
        /// </summary>
        public qxDotNet.AllowScriptAccessEnum AllowScriptAccess
        {
            get
            {
                return _allowScriptAccess;
            }
            set
            {
               _allowScriptAccess = value;
            }
        }

        /// <summary>
        /// The unique Flash movie id.
        /// 
        /// </summary>
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
               _id = value;
            }
        }

        /// <summary>
        /// Enable/disable live connection
        /// 
        /// </summary>
        public bool? LiveConnect
        {
            get
            {
                return _liveConnect;
            }
            set
            {
               _liveConnect = value;
            }
        }

        /// <summary>
        /// A timeout when trying to load the flash source.
        /// 
        /// </summary>
        public int LoadTimeout
        {
            get
            {
                return _loadTimeout;
            }
            set
            {
               _loadTimeout = value;
            }
        }

        /// <summary>
        /// Set the loop attribute for the Flash movie.
        /// 
        /// </summary>
        public bool? Loop
        {
            get
            {
                return _loop;
            }
            set
            {
               _loop = value;
            }
        }

        /// <summary>
        /// Set the mayscript attribute for the Flash movie.
        /// 
        /// </summary>
        public bool? MayScript
        {
            get
            {
                return _mayScript;
            }
            set
            {
               _mayScript = value;
            }
        }

        /// <summary>
        /// Set the menu attribute for the Flash movie.
        /// 
        /// </summary>
        public bool? Menu
        {
            get
            {
                return _menu;
            }
            set
            {
               _menu = value;
            }
        }

        /// <summary>
        /// Set the play attribute for the Flash movie.
        /// 
        /// </summary>
        public bool? Play
        {
            get
            {
                return _play;
            }
            set
            {
               _play = value;
            }
        }

        /// <summary>
        /// Set the quality attribute for the Flash movie.
        /// 
        /// </summary>
        public qxDotNet.QualityEnum Quality
        {
            get
            {
                return _quality;
            }
            set
            {
               _quality = value;
            }
        }

        /// <summary>
        /// Set the scale attribute for the Flash movie.
        /// 
        /// </summary>
        public qxDotNet.ScaleEnum Scale
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
        /// The URL of the Flash movie.
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
            }
        }

        /// <summary>
        /// Set the 'FlashVars' to pass variables to the Flash movie.
        /// 
        /// </summary>
        public Map Variables
        {
            get
            {
                return _variables;
            }
            set
            {
               _variables = value;
            }
        }

        /// <summary>
        /// Set the wmode attribute for the Flash movie.
        /// 
        /// </summary>
        public qxDotNet.WmodeEnum Wmode
        {
            get
            {
                return _wmode;
            }
            set
            {
               _wmode = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.embed.Flash";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("allowScriptAccess", _allowScriptAccess, AllowScriptAccessEnum.sameDomain);
            state.SetPropertyValue("id", _id, "");
            state.SetPropertyValue("liveConnect", _liveConnect, true);
            state.SetPropertyValue("loadTimeout", _loadTimeout, 10000);
            state.SetPropertyValue("loop", _loop, false);
            state.SetPropertyValue("mayScript", _mayScript, false);
            state.SetPropertyValue("menu", _menu, false);
            state.SetPropertyValue("play", _play, false);
            state.SetPropertyValue("quality", _quality, QualityEnum.best);
            state.SetPropertyValue("scale", _scale, (ScaleEnum)(-1));
            state.SetPropertyValue("source", _source, "");
            state.SetPropertyValue("variables", _variables, null);
            state.SetPropertyValue("wmode", _wmode, WmodeEnum.opaque);

            if (Loaded != null)
            {
                state.SetEvent("loaded", false);
            }
            if (Loading != null)
            {
                state.SetEvent("loading", false);
            }
            if (Timeout != null)
            {
                state.SetEvent("timeout", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "loaded")
            {
                OnLoaded();
            }
            if (eventName == "loading")
            {
                OnLoading();
            }
            if (eventName == "timeout")
            {
                OnTimeout();
            }
        }

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
        /// Fired after the flash object has been loaded.
        /// 
        /// The loaded action can be prevented by calling
        /// {@link qx.event.type.Event#preventDefault} on the event object
        /// 
        /// </summary>
        public event EventHandler Loaded;

        /// <summary>
        /// Raises event 'Loading'
        /// </summary>
        protected virtual void OnLoading()
        {
            if (Loading != null)
            {
                Loading.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the flash object still is loading.
        /// 
        /// The loading action can be prevented by calling
        /// {@link qx.event.type.Event#preventDefault} on the event object
        /// 
        /// </summary>
        public event EventHandler Loading;

        /// <summary>
        /// Raises event 'Timeout'
        /// </summary>
        protected virtual void OnTimeout()
        {
            if (Timeout != null)
            {
                Timeout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the flash object has got a timeout.
        /// 
        /// The timeout action can be prevented by calling
        /// {@link qx.event.type.Event#preventDefault} on the event object
        /// 
        /// </summary>
        public event EventHandler Timeout;

    }
}
