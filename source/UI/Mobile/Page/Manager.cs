using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Page
{
    /// <summary>
    /// The page manager decides automatically whether the added pages should be displayed in a master/detail view (for tablet) or as a plain card layout (for smartphones).  Example  Here is a little example of how to use the manager.    var manager = new qx.ui.mobile.page.Manager();  var page1 = new qx.ui.mobile.page.NavigationPage();  var page2 = new qx.ui.mobile.page.NavigationPage();  var page3 = new qx.ui.mobile.page.NavigationPage();  manager.addMaster(page1);  manager.addDetail([page2,page3]);   page1.show(); 
    /// </summary>
    public partial class Manager : qxDotNet.Core.Object
    {

        private bool? _allowMasterHideOnLandscape = true;
        private string _hideMasterButtonCaption = "Hide";
        private bool? _hideMasterOnDetailStart = true;
        private bool? _masterContainerHidden = false;
        private string _masterTitle = "Master";


        /// <summary>
        /// This flag controls whether the MasterContainer can be hidden on Landscape.
        /// </summary>
        public bool? AllowMasterHideOnLandscape
        {
            get
            {
                return _allowMasterHideOnLandscape;
            }
            set
            {
               _allowMasterHideOnLandscape = value;
            }
        }

        /// <summary>
        /// The caption/label of the Hide Master Button.
        /// </summary>
        public string HideMasterButtonCaption
        {
            get
            {
                return _hideMasterButtonCaption;
            }
            set
            {
               _hideMasterButtonCaption = value;
            }
        }

        /// <summary>
        /// This flag controls whether the MasterContainer hides on portrait view,  when a Detail Page fires the lifecycle event "start".
        /// </summary>
        public bool? HideMasterOnDetailStart
        {
            get
            {
                return _hideMasterOnDetailStart;
            }
            set
            {
               _hideMasterOnDetailStart = value;
            }
        }

        /// <summary>
        /// This flag indicates whether the masterContainer is hidden or not.
        /// </summary>
        public bool? MasterContainerHidden
        {
            get
            {
                return _masterContainerHidden;
            }
            set
            {
               _masterContainerHidden = value;
            }
        }

        /// <summary>
        /// The caption/label of the Master Button and Popup Title.
        /// </summary>
        public string MasterTitle
        {
            get
            {
                return _masterTitle;
            }
            set
            {
               _masterTitle = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.page.Manager";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("allowMasterHideOnLandscape", _allowMasterHideOnLandscape, true);
            state.SetPropertyValue("hideMasterButtonCaption", _hideMasterButtonCaption, "Hide");
            state.SetPropertyValue("hideMasterOnDetailStart", _hideMasterOnDetailStart, true);
            state.SetPropertyValue("masterContainerHidden", _masterContainerHidden, false);
            state.SetPropertyValue("masterTitle", _masterTitle, "Master");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
