using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Page
{
    /// <summary>
    /// Specialized page. This page includes already a {@link qx.ui.mobile.navigationbar.NavigationBar} and and a {@link qx.ui.mobile.container.Scroll} container. The NavigationPage can only be used with a page manager {@link qx.ui.mobile.page.Manager}.  Example  Here is a little example of how to use the widget.     var manager = new qx.ui.mobile.page.Manager();  var page = new qx.ui.mobile.page.NavigationPage();  page.setTitle(\PageTitle\);  page.setShowBackButton(true);  page.setBackButtonText(\Back\)  page.addListener(\initialize\, function()  {  var button = new qx.ui.mobile.form.Button(\NextPage\);  page.getContent().add(button);  },this);   page.addListener(\back\, function()  {  otherPage.show({animation:\cube\, reverse:true});  },this);   manager.addDetail(page);  page.show();   This example creates a NavigationPage with a title and a back button. In the initialize lifecycle method a button is added.
    /// </summary>
    public partial class NavigationPage : qxDotNet.UI.Mobile.Page.Page, qxDotNet.UI.Mobile.Container.INavigation
    {

        private string _backButtonText = "";
        private string _buttonIcon = null;
        private string _buttonText = "";
        private string _contentCssClass = "content";
        private bool? _navigationBarHidden = false;
        private decimal _navigationBarToggleDuration = 0.8M;
        private bool? _showBackButton = false;
        private bool? _showBackButtonOnTablet = false;
        private bool? _showButton = false;
        private string _title = "";


        /// <summary>
        /// The back button text
        /// </summary>
        public string BackButtonText
        {
            get
            {
                return _backButtonText;
            }
            set
            {
               _backButtonText = value;
            }
        }

        /// <summary>
        /// The action button icon
        /// </summary>
        public string ButtonIcon
        {
            get
            {
                return _buttonIcon;
            }
            set
            {
               _buttonIcon = value;
            }
        }

        /// <summary>
        /// The action button text
        /// </summary>
        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
               _buttonText = value;
            }
        }

        /// <summary>
        /// The CSS class to add to the content per default.
        /// </summary>
        public string ContentCssClass
        {
            get
            {
                return _contentCssClass;
            }
            set
            {
               _contentCssClass = value;
            }
        }

        /// <summary>
        /// Toggles visibility of NavigationBar in wrapping container {@link qx.ui.mobile.container.Navigation}
        /// </summary>
        public bool? NavigationBarHidden
        {
            get
            {
                return _navigationBarHidden;
            }
            set
            {
               _navigationBarHidden = value;
            }
        }

        /// <summary>
        /// Sets the transition duration (in seconds) for the effect when hiding/showing the NavigationBar through boolean property navigationBarHidden.
        /// </summary>
        public decimal NavigationBarToggleDuration
        {
            get
            {
                return _navigationBarToggleDuration;
            }
            set
            {
               _navigationBarToggleDuration = value;
            }
        }

        /// <summary>
        /// Whether to show the back button.
        /// </summary>
        public bool? ShowBackButton
        {
            get
            {
                return _showBackButton;
            }
            set
            {
               _showBackButton = value;
            }
        }

        /// <summary>
        /// Indicates whether the back button should be shown on tablet.
        /// </summary>
        public bool? ShowBackButtonOnTablet
        {
            get
            {
                return _showBackButtonOnTablet;
            }
            set
            {
               _showBackButtonOnTablet = value;
            }
        }

        /// <summary>
        /// Whether to show the action button.
        /// </summary>
        public bool? ShowButton
        {
            get
            {
                return _showButton;
            }
            set
            {
               _showButton = value;
            }
        }

        /// <summary>
        /// The title of the page
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
            return "qx.ui.mobile.page.NavigationPage";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("backButtonText", _backButtonText, "");
            state.SetPropertyValue("buttonIcon", _buttonIcon, null);
            state.SetPropertyValue("buttonText", _buttonText, "");
            state.SetPropertyValue("contentCssClass", _contentCssClass, "content");
            state.SetPropertyValue("navigationBarHidden", _navigationBarHidden, false);
            state.SetPropertyValue("navigationBarToggleDuration", _navigationBarToggleDuration, 0.8M);
            state.SetPropertyValue("showBackButton", _showBackButton, false);
            state.SetPropertyValue("showBackButtonOnTablet", _showBackButtonOnTablet, false);
            state.SetPropertyValue("showButton", _showButton, false);
            state.SetPropertyValue("title", _title, "");

            if (Action != null)
            {
                state.SetEvent("action", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "action")
            {
                OnAction();
            }
        }

        protected virtual void OnAction()
        {
            if (Action != null)
            {
                Action.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the user tapped on the navigation button
        /// </summary>
        public event EventHandler Action;

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

    }
}
