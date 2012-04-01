using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree.Core
{
    /// <summary>
    /// The small folder open/close button
    /// </summary>
    public partial class FolderOpenButton : qxDotNet.UI.Basic.Image
    {

        private bool? _open = false;
        private qxDotNet.UI.Core.Command _command = null;


        /// <summary>
        /// Whether the button state is &#8220;open&#8221;
        /// </summary>
        public bool? Open
        {
            get
            {
                return _open;
            }
            set
            {
               _open = value;
               OnChangeOpen();
            }
        }

        /// <summary>
        /// A command called if the {@link #execute} method is called, e.g. on a button click.
        /// </summary>
        public qxDotNet.UI.Core.Command Command
        {
            get
            {
                return _command;
            }
            set
            {
               _command = value;
               OnChangeCommand();
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tree.core.FolderOpenButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("open", _open, false);
            state.SetPropertyValue("command", _command, null);

            if (Execute != null)
            {
                state.SetEvent("execute", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

        protected virtual void OnChangeOpen()
        {
            if (ChangeOpen != null)
            {
                ChangeOpen.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #open}.
        /// </summary>
        public event EventHandler ChangeOpen;

        protected virtual void OnChangeCommand()
        {
            if (ChangeCommand != null)
            {
                ChangeCommand.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #command}.
        /// </summary>
        public event EventHandler ChangeCommand;

        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the {@link #execute} method is invoked.
        /// </summary>
        public event EventHandler Execute;

    }
}
