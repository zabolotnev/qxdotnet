using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Media
{
    /// <summary>
    /// EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION  Media element. Other media types can derive from this class.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {

        private bool? _autoplay = false;
        private decimal _currentTime = 0m;
        private string _id = "";
        private string _preload = "";
        private string _source = "";
        private decimal _volume = 0m;


        /// <summary>
        /// 
        /// </summary>
        public bool? Autoplay
        {
            get
            {
                return _autoplay;
            }
            set
            {
               _autoplay = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal CurrentTime
        {
            get
            {
                return _currentTime;
            }
            set
            {
               _currentTime = value;
            }
        }

        /// <summary>
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
        /// 
        /// </summary>
        public string Preload
        {
            get
            {
                return _preload;
            }
            set
            {
               _preload = value;
            }
        }

        /// <summary>
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
        /// 
        /// </summary>
        public decimal Volume
        {
            get
            {
                return _volume;
            }
            set
            {
               _volume = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.media.Abstract";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("autoplay", _autoplay, false);
            state.SetPropertyValue("currentTime", _currentTime, 0m);
            state.SetPropertyValue("id", _id, "");
            state.SetPropertyValue("preload", _preload, "");
            state.SetPropertyValue("source", _source, "");
            state.SetPropertyValue("volume", _volume, 0m);

            if (Ended != null)
            {
                state.SetEvent("ended", false);
            }
            if (Loadeddata != null)
            {
                state.SetEvent("loadeddata", false);
            }
            if (Loadedmetadata != null)
            {
                state.SetEvent("loadedmetadata", false);
            }
            if (Pause != null)
            {
                state.SetEvent("pause", false);
            }
            if (Play != null)
            {
                state.SetEvent("play", false);
            }
            if (Timeupdate != null)
            {
                state.SetEvent("timeupdate", false);
            }
            if (Volumechange != null)
            {
                state.SetEvent("volumechange", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "ended")
            {
                OnEnded();
            }
            if (eventName == "loadeddata")
            {
                OnLoadeddata();
            }
            if (eventName == "loadedmetadata")
            {
                OnLoadedmetadata();
            }
            if (eventName == "pause")
            {
                OnPause();
            }
            if (eventName == "play")
            {
                OnPlay();
            }
            if (eventName == "timeupdate")
            {
                OnTimeupdate();
            }
            if (eventName == "volumechange")
            {
                OnVolumechange();
            }
        }

        protected virtual void OnEnded()
        {
            if (Ended != null)
            {
                Ended.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the media has finished to play
        /// </summary>
        public event EventHandler Ended;

        protected virtual void OnLoadeddata()
        {
            if (Loadeddata != null)
            {
                Loadeddata.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the media is laoded enough to start play
        /// </summary>
        public event EventHandler Loadeddata;

        protected virtual void OnLoadedmetadata()
        {
            if (Loadedmetadata != null)
            {
                Loadedmetadata.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the media is laoded enough to start play
        /// </summary>
        public event EventHandler Loadedmetadata;

        protected virtual void OnPause()
        {
            if (Pause != null)
            {
                Pause.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the media is paused
        /// </summary>
        public event EventHandler Pause;

        protected virtual void OnPlay()
        {
            if (Play != null)
            {
                Play.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the media starts to play
        /// </summary>
        public event EventHandler Play;

        protected virtual void OnTimeupdate()
        {
            if (Timeupdate != null)
            {
                Timeupdate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the current time of the media has changed
        /// </summary>
        public event EventHandler Timeupdate;

        protected virtual void OnVolumechange()
        {
            if (Volumechange != null)
            {
                Volumechange.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the volume property is changed
        /// </summary>
        public event EventHandler Volumechange;

    }
}
