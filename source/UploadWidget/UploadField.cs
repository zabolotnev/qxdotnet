using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UploadWidget
{
    public class UploadField : qxDotNet.UI.Core.Widget
    {

        private string _FieldName;
        private string _FileName;
        private int _FileSize;
        private string _Label;
        private string _Icon;

        public string FieldName
        {
            get
            {
                return _FieldName;
            }
            set
            {
                _FieldName = value;
            }
        }

        public string FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
            }
        }

        public int FileSize
        {
            get
            {
                return _FileSize;
            }
            set
            {
                _FileSize = value;
            }
        }

        public string Label
        {
            get
            {
                return _Label;
            }
            set
            {
                _Label = value;
            }
        }

        public string Icon
        {
            get
            {
                return _Icon;
            }
            set
            {
                _Icon = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "uploadwidget.UploadField";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            state.SetPropertyValue("fieldName", _FieldName, null);
            state.SetPropertyValue("fileName", _FileName, null);
            state.SetPropertyValue("fileSize", _FileSize, 0);
            state.SetPropertyValue("label", _Label, null);
            state.SetPropertyValue("icon", _Icon, null);

            var eventChangeFileName = state.SetEvent("changeFileName", true, "FileName");

            var parentForm = FindParent<UploadForm>(this);

            if (parentForm != null)
            {
                eventChangeFileName.CustomCallServerExpression = "ctr[" + parentForm.clientId + "].send();";
            }
        }

        public event EventHandler ChangeFileName;

        protected virtual void OnChangeFileName()
        {
            if (ChangeFileName != null)
            {
                ChangeFileName.Invoke(this, System.EventArgs.Empty);
            }
        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeFileName")
            {
                OnChangeFileName();
            }
        }

    }
}
