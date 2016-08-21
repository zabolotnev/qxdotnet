using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Progressive
{
    /// <summary>
    /// Progressive.
    /// 
    /// Follow progressive instructions provided by a data model. A variable
    /// number of instructions are executed at one time, after which control is
    /// returned briefly to the browser. This allows browser rendering between
    /// batches of instructions, improving the visual experience.
    /// 
    /// Progressive may be used for various purposes. Two predefined
    /// purposes for which "renderers" are provided, are a progressively-rendered
    /// table which allows variable row height, and a program load/initialization
    /// renderer with progress bar. (Note that the term "renderer" is interpreted
    /// quite broadly. A renderer needn't actually render; rather it is just some
    /// set of activities that takes place at one time, e.g a row of table data or
    /// a single widget added to the document or a sending a request to a server,
    /// etc.)
    /// </summary>
    public partial class Progressive : qxDotNet.UI.Container.Composite
    {

        private int _batchSize = 20;
        private qxDotNet.UI.Progressive.Model.Abstract _dataModel = null;
        private bool? _flushWidgetQueueAfterBatch = false;
        private int _interElementTimeout = 0;


        /// <summary>
        /// Number of elements to render at one time. After this number of
        /// elements has been rendered, control will be yielded to the browser
        /// allowing the elements to actually be displayed. A short-interval timer
        /// will be set, to regain control to render the next batch of elements.
        /// 
        /// </summary>
        public int BatchSize
        {
            get
            {
                return _batchSize;
            }
            set
            {
               _batchSize = value;
            }
        }

        /// <summary>
        /// The data model.
        /// 
        /// </summary>
        public qxDotNet.UI.Progressive.Model.Abstract DataModel
        {
            get
            {
                return _dataModel;
            }
            set
            {
               _dataModel = value;
            }
        }

        /// <summary>
        /// Flush the widget queue after each batch is rendered. This is
        /// particularly relevant for such things as progressive loading, where
        /// the whole purpose is to be able to see the loading progressing.
        /// 
        /// </summary>
        public bool? FlushWidgetQueueAfterBatch
        {
            get
            {
                return _flushWidgetQueueAfterBatch;
            }
            set
            {
               _flushWidgetQueueAfterBatch = value;
            }
        }

        /// <summary>
        /// Delay between rendering elements. Zero is normally adequate, but
        /// there are times that the user wants more time between rendering
        /// some elements.
        /// 
        /// </summary>
        public int InterElementTimeout
        {
            get
            {
                return _interElementTimeout;
            }
            set
            {
               _interElementTimeout = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.progressive.Progressive";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("batchSize", _batchSize, 20);
            state.SetPropertyValue("dataModel", _dataModel, null);
            state.SetPropertyValue("flushWidgetQueueAfterBatch", _flushWidgetQueueAfterBatch, false);
            state.SetPropertyValue("interElementTimeout", _interElementTimeout, 0);

            if (Progress != null)
            {
                state.SetEvent("progress", false);
            }
            if (ProgressDetail != null)
            {
                state.SetEvent("progressDetail", false);
            }
            if (RenderEnd != null)
            {
                state.SetEvent("renderEnd", false);
            }
            if (RenderStart != null)
            {
                state.SetEvent("renderStart", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "progress")
            {
                OnProgress();
            }
            if (eventName == "progressDetail")
            {
                OnProgressDetail();
            }
            if (eventName == "renderEnd")
            {
                OnRenderEnd();
            }
            if (eventName == "renderStart")
            {
                OnRenderStart();
            }
        }

        /// <summary>
        /// Raises event 'Progress'
        /// </summary>
        protected virtual void OnProgress()
        {
            if (Progress != null)
            {
                Progress.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after each batch of elements is rendered, and
        /// control is about to be yielded to the browser. This is an appropriate
        /// event to listen for, to implement a progress bar.
        /// 
        /// The event data is an object with the following members:
        /// 
        ///  initial
        ///  
        ///  The number of elements that were available at the start of this
        ///  rendering request.
        ///  
        /// 
        /// remaining
        ///  
        ///  The number of elements still remaining to be rendered.
        ///  
        /// 
        /// </summary>
        public event EventHandler Progress;

        /// <summary>
        /// Raises event 'ProgressDetail'
        /// </summary>
        protected virtual void OnProgressDetail()
        {
            if (ProgressDetail != null)
            {
                ProgressDetail.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after each element is rendered.
        /// 
        /// The event data is an object with the following members:
        /// 
        ///  initial
        ///  
        ///  The number of elements that were available at the start of this
        ///  rendering request.
        ///  
        /// 
        /// remaining
        ///  
        ///  The number of elements still remaining to be rendered.
        ///  
        /// 
        /// element
        ///  
        ///  The object, returned by the data model's getNextElement() method,
        ///  that was just rendered.
        ///  
        /// 
        /// 
        /// Note: Unless batchSize is set to 1 or we happen to be at the end of a
        ///  batch, widgets will not be rendered at this time. Use this event
        ///  for programmatically processing rendered elements, but not for
        ///  such things as progress bars. Instead, where only user-visible
        ///  changes such as progress bars are being updated, use the
        ///  "progress" event.
        /// 
        /// </summary>
        public event EventHandler ProgressDetail;

        /// <summary>
        /// Raises event 'RenderEnd'
        /// </summary>
        protected virtual void OnRenderEnd()
        {
            if (RenderEnd != null)
            {
                RenderEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Event fired when rendering ends. The data is the state object.
        /// 
        /// </summary>
        public event EventHandler RenderEnd;

        /// <summary>
        /// Raises event 'RenderStart'
        /// </summary>
        protected virtual void OnRenderStart()
        {
            if (RenderStart != null)
            {
                RenderStart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Event fired when rendering begins.
        /// 
        /// The event data is an object with the following members:
        /// 
        ///  state
        ///  
        ///  The state object.
        ///  
        /// 
        /// initial
        ///  The number of elements that are available to be rendered
        ///  
        ///  
        /// 
        /// </summary>
        public event EventHandler RenderStart;

    }
}
