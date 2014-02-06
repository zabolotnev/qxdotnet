using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom
{
    /// <summary>
    /// A helper for using the browser history in JavaScript Applications without reloading the main page.  Adds entries to the browser history and fires a "request" event when one of the entries was requested by the user (e.g. by clicking on the back button).  This class is an abstract template class. Concrete implementations have to provide implementations for the {@link #_readState} and {@link #_writeState} methods.  Browser history support is currently available for Internet Explorer 6/7, Firefox, Opera 9 and WebKit. Safari 2 and older are not yet supported.  This module is based on the ideas behind the YUI Browser History Manager by Julien Lecomte (Yahoo), which is described at http://yuiblog.com/blog/2007/02/21/browser-history-manager/. The Yahoo implementation can be found at http://developer.yahoo.com/yui/history/. The original code is licensed under a BSD license (http://developer.yahoo.com/yui/license.txt).
    /// </summary>
    public abstract partial class History : qxDotNet.Core.Object
    {

        private string _state = "";
        private string _title = "";


        /// <summary>
        /// Property holding the current state of the history.
        /// </summary>
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
               _state = value;
               OnChangeState();
            }
        }

        /// <summary>
        /// Property holding the current title
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
               _title = value;
               OnChangeTitle();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.History";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("state", _state, "");
            state.SetPropertyValue("title", _title, "");

            if (Request != null)
            {
                state.SetEvent("request", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "request")
            {
                OnRequest();
            }
        }

        protected virtual void OnChangeState()
        {
            if (ChangeState != null)
            {
                ChangeState.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #state}.
        /// </summary>
        public event EventHandler ChangeState;

        protected virtual void OnChangeTitle()
        {
            if (ChangeTitle != null)
            {
                ChangeTitle.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #title}.
        /// </summary>
        public event EventHandler ChangeTitle;

        protected virtual void OnRequest()
        {
            if (Request != null)
            {
                Request.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the user moved in the history. The data property of the event holds the state, which was passed to {@link #addToHistory}.
        /// </summary>
        public event EventHandler Request;

    }
}
