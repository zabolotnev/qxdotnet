using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom
{
    /// <summary>
    /// Shortcuts can be used to globally define keyboard shortcuts.
    /// </summary>
    public partial class Shortcut : qxDotNet.Core.Object
    {

        private bool? _autoRepeat = false;
        private bool? _enabled = true;
        private string _shortcut = "";


        /// <summary>
        /// Whether the execute event should be fired repeatedly if the user keep the keys pressed.
        /// </summary>
        public bool? AutoRepeat
        {
            get
            {
                return _autoRepeat;
            }
            set
            {
               _autoRepeat = value;
            }
        }

        /// <summary>
        /// whether the command should be respected/enabled
        /// </summary>
        public bool? Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
               _enabled = value;
               OnChangeEnabled();
            }
        }

        /// <summary>
        /// The command shortcut
        /// </summary>
        public string ShortcutCommand
        {
            get
            {
                return _shortcut;
            }
            set
            {
               _shortcut = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.Shortcut";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("autoRepeat", _autoRepeat, false);
            state.SetPropertyValue("enabled", _enabled, true);
            state.SetPropertyValue("shortcut", _shortcut, "");

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

        protected virtual void OnChangeEnabled()
        {
            if (ChangeEnabled != null)
            {
                ChangeEnabled.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #enabled}.
        /// </summary>
        public event EventHandler ChangeEnabled;

        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the command is executed. Sets the "data" property of the event to the object that issued the command.
        /// </summary>
        public event EventHandler Execute;

    }
}
