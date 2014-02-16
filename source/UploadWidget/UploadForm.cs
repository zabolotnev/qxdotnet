using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UploadWidget
{
    public class UploadForm : qxDotNet.UI.Container.Composite
    {
        /// <summary>
        /// The name which is assigned to the form
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The url which is used for form submission.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "uploadwidget.UploadForm";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            state.SetPropertyValue("name", Name, null);
            state.SetPropertyValue("url", Url, null);

            state.SetEvent("completed", true);
        }

        public event EventHandler Completed;

        protected virtual void OnCompleted()
        {
            if (Completed != null)
            {
                Completed.Invoke(this, System.EventArgs.Empty);
            }
        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "completed")
            {
                OnCompleted();
            }
        }

    }
}
