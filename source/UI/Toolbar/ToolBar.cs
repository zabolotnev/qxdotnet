using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// The Toolbar class is the main part of the toolbar widget.  It can handle added {@link Button}s, {@link CheckBox}es, {@link RadioButton}s and {@link Separator}s in its {@link #add} method. The {@link #addSpacer} method adds a spacer at the current toolbar position. This means that the widgets added after the method call of {@link #addSpacer} are aligned to the right of the toolbar.  For more details on the documentation of the toolbar widget, take a look at the documentation of the {@link qx.ui.toolbar}-Package.
    /// </summary>
    public partial class ToolBar : qxDotNet.UI.Core.Widget
    {

        private qxDotNet.UI.Menu.Menu _openMenu = null;
        private bool? _overflowHandling = false;
        private qxDotNet.UI.Core.Widget _overflowIndicator = null;
        private qxDotNet.ShowEnum _show = ShowEnum.both;
        private int _spacing = 0;


        /// <summary>
        /// Holds the currently open menu (when the toolbar is used for menus)
        /// </summary>
        public qxDotNet.UI.Menu.Menu OpenMenu
        {
            get
            {
                return _openMenu;
            }
            set
            {
               _openMenu = value;
               OnChangeOpenMenu();
            }
        }

        /// <summary>
        /// Enables the overflow handling which automatically removes items.
        /// </summary>
        public bool? OverflowHandling
        {
            get
            {
                return _overflowHandling;
            }
            set
            {
               _overflowHandling = value;
            }
        }

        /// <summary>
        /// Widget which will be shown if at least one toolbar item is hidden. Keep in mind to add this widget to the toolbar before you set it as indicator!
        /// </summary>
        public qxDotNet.UI.Core.Widget OverflowIndicator
        {
            get
            {
                return _overflowIndicator;
            }
            set
            {
               _overflowIndicator = value;
            }
        }

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

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.toolbar.ToolBar";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("openMenu", _openMenu, null);
            state.SetPropertyValue("overflowHandling", _overflowHandling, false);
            state.SetPropertyValue("overflowIndicator", _overflowIndicator, null);
            state.SetPropertyValue("show", _show, ShowEnum.both);
            state.SetPropertyValue("spacing", _spacing, 0);

            if (HideItem != null)
            {
                state.SetEvent("hideItem", false);
            }
            if (ShowItem != null)
            {
                state.SetEvent("showItem", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "hideItem")
            {
                OnHideItem();
            }
            if (eventName == "showItem")
            {
                OnShowItem();
            }
        }

        protected virtual void OnChangeOpenMenu()
        {
            if (ChangeOpenMenu != null)
            {
                ChangeOpenMenu.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #openMenu}.
        /// </summary>
        public event EventHandler ChangeOpenMenu;

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

        protected virtual void OnHideItem()
        {
            if (HideItem != null)
            {
                HideItem.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if an item will be hidden by the {@link #overflowHandling}.
        /// </summary>
        public event EventHandler HideItem;

        protected virtual void OnShowItem()
        {
            if (ShowItem != null)
            {
                ShowItem.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if an item will be show by the {@link #overflowHandling}.
        /// </summary>
        public event EventHandler ShowItem;

    }
}
