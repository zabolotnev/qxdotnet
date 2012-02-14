using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// A part is a container for multiple toolbar buttons. Each part comes with a handle which may be used in later versions to drag the part around and move it to another position. Currently mainly used for structuring large toolbars beyond the capabilities of the {@link Separator}.
    /// </summary>
    public partial class Part : qxDotNet.UI.Core.Widget
    {

        private qxDotNet.ShowEnum _show = ShowEnum.both;
        private int _spacing = 0;


        /// <summary>
        /// Whether icons, labels, both or none should be shown.
        /// </summary>
        public qxDotNet.ShowEnum Show
        {
            get
            {
                return _show;
            }
            set
            {
               _show = value;
               OnChangeShow();
            }
        }

        /// <summary>
        /// The spacing between every child of the toolbar
        /// </summary>
        public int Spacing
        {
            get
            {
                return _spacing;
            }
            set
            {
               _spacing = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.toolbar.Part";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("show", _show, ShowEnum.both);
            state.SetPropertyValue("spacing", _spacing, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeShow()
        {
            if (ChangeShow != null)
            {
                ChangeShow.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #show}.
        /// </summary>
        public event EventHandler ChangeShow;

    }
}
