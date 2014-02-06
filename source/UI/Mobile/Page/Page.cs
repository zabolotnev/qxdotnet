using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Page
{
    /// <summary>
    /// A page is a widget which provides a screen with which users can interact in order to do something. Most times a page provides a single task or a group of related tasks.  A qooxdoo mobile application is usually composed of one or more loosely bound pages. Typically there is one page that presents the "main" view.  Pages can have one or more child widgets from the {@link qx.ui.mobile} namespace. Normally a page provides a {@link qx.ui.mobile.navigationbar.NavigationBar} for the navigation between pages.  To navigate between two pages, just call the {@link #show} method of the page that should be shown. Depending on the used page manager a page transition will be animated. There are several animations available. Have a look at the {@link qx.ui.mobile.page.Manager} manager or {@link qx.ui.mobile.layout.Card} card layout for more information.  A page has predefined lifecycle methods that get called by the used page manager when a page gets shown. Each time another page is requested to be shown the currently shown page is stopped. The other page, will be, if shown for the first time, initialized and started afterwards. For all called lifecycle methods an event is fired.  Call of the {@link #show} method triggers the following lifecycle methods:   initialize: Initializes the page to show start: Gets called when the page to show is started stop: Stops the current page   IMPORTANT: Define all child widgets of a page when the {@link #initialize} lifecycle method is called, either by listening to the {@link #initialize} event or overriding the {@link #_initialize} method. This is because a page can be instanced during application startup and would then decrease performance when the widgets would be added during constructor call. The initialize event and the {@link #_initialize} lifecycle method are only called when the page is shown for the first time.
    /// </summary>
    public partial class Page : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _fireDomUpdatedOnResize = false;


        /// <summary>
        /// Whether the resize should fire the "domupdated" event. Set this to "true"  whenever other elements should react on this size change (e.g. when the size  change does not infect the size of the application, but other widgets should  react).
        /// </summary>
        public bool? FireDomUpdatedOnResize
        {
            get
            {
                return _fireDomUpdatedOnResize;
            }
            set
            {
               _fireDomUpdatedOnResize = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.page.Page";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("fireDomUpdatedOnResize", _fireDomUpdatedOnResize, false);

            if (Back != null)
            {
                state.SetEvent("back", false);
            }
            if (Initialize != null)
            {
                state.SetEvent("initialize", false);
            }
            if (Menu != null)
            {
                state.SetEvent("menu", false);
            }
            if (Pause != null)
            {
                state.SetEvent("pause", false);
            }
            if (Resume != null)
            {
                state.SetEvent("resume", false);
            }
            if (Start != null)
            {
                state.SetEvent("start", false);
            }
            if (Stop != null)
            {
                state.SetEvent("stop", false);
            }
            if (Wait != null)
            {
                state.SetEvent("wait", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "back")
            {
                OnBack();
            }
            if (eventName == "initialize")
            {
                OnInitialize();
            }
            if (eventName == "menu")
            {
                OnMenu();
            }
            if (eventName == "pause")
            {
                OnPause();
            }
            if (eventName == "resume")
            {
                OnResume();
            }
            if (eventName == "start")
            {
                OnStart();
            }
            if (eventName == "stop")
            {
                OnStop();
            }
            if (eventName == "wait")
            {
                OnWait();
            }
        }

        protected virtual void OnBack()
        {
            if (Back != null)
            {
                Back.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the method {@link #back} is called. Data indicating  whether the action was triggered by a key event or not.
        /// </summary>
        public event EventHandler Back;

        protected virtual void OnInitialize()
        {
            if (Initialize != null)
            {
                Initialize.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #initialize} is called
        /// </summary>
        public event EventHandler Initialize;

        protected virtual void OnMenu()
        {
            if (Menu != null)
            {
                Menu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the method {@link #menu} is called
        /// </summary>
        public event EventHandler Menu;

        protected virtual void OnPause()
        {
            if (Pause != null)
            {
                Pause.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #pause} is called
        /// </summary>
        public event EventHandler Pause;

        protected virtual void OnResume()
        {
            if (Resume != null)
            {
                Resume.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #resume} is called
        /// </summary>
        public event EventHandler Resume;

        protected virtual void OnStart()
        {
            if (Start != null)
            {
                Start.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #start} is called
        /// </summary>
        public event EventHandler Start;

        protected virtual void OnStop()
        {
            if (Stop != null)
            {
                Stop.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #stop} is called
        /// </summary>
        public event EventHandler Stop;

        protected virtual void OnWait()
        {
            if (Wait != null)
            {
                Wait.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the method {@link #wait} is called
        /// </summary>
        public event EventHandler Wait;

    }
}
