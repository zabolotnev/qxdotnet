using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// Creates a Carousel widget. A carousel is a widget which can switch between several sub pages {@link qx.ui.mobile.container.Composite}. A page switch is triggered by a swipe to left, for next page, or a swipe to right for previous page.  A carousel shows by default a pagination indicator at the bottom of the carousel. This pagination indicator can be hidden by property showPagination.  Example  Here is a little example of how to use the widget.     var carousel = new qx.ui.mobile.container.Carousel();  var carouselPage1 = new qx.ui.mobile.container.Composite();  var carouselPage2 = new qx.ui.mobile.container.Composite();   carouselPage1.add(new qx.ui.mobile.basic.Label(\Thisisacarousel.Pleaseswipeleft.\));  carouselPage2.add(new qx.ui.mobile.basic.Label(\Nowswiperight.\));   carousel.add(carouselPage1);  carousel.add(carouselPage2); 
    /// </summary>
    public partial class Carousel : qxDotNet.UI.Mobile.Container.Composite
    {

        private decimal _currentIndex = 0;
        private decimal _height = 200;
        private bool? _scrollLoop = true;
        private bool? _showPagination = true;
        private decimal _transitionDuration = 0.4M;
        private bool? _fireDomUpdatedOnResize = false;


        /// <summary>
        /// The current visible page index.
        /// </summary>
        public decimal CurrentIndex
        {
            get
            {
                return _currentIndex;
            }
            set
            {
               _currentIndex = value;
               OnChangeCurrentIndex();
            }
        }

        /// <summary>
        /// Defines the height of the carousel.
        /// </summary>
        public decimal Height
        {
            get
            {
                return _height;
            }
            set
            {
               _height = value;
            }
        }

        /// <summary>
        /// Defines whether the carousel should scroll back to first or last page when the start/end of carousel pages is reached
        /// </summary>
        public bool? ScrollLoop
        {
            get
            {
                return _scrollLoop;
            }
            set
            {
               _scrollLoop = value;
            }
        }

        /// <summary>
        /// Property for setting visibility of pagination indicator
        /// </summary>
        public bool? ShowPagination
        {
            get
            {
                return _showPagination;
            }
            set
            {
               _showPagination = value;
            }
        }

        /// <summary>
        /// Duration of the carousel page transition.
        /// </summary>
        public decimal TransitionDuration
        {
            get
            {
                return _transitionDuration;
            }
            set
            {
               _transitionDuration = value;
            }
        }

        /// <summary>
        /// Whether the resize should fire the "domupdated" event. Set this to "true"  whenever other elements should react on this size change (e.g. when the size  change does not infect the size of the application, but other widgets should  react).
        /// </summary>
        public bool? FireDomUpdatedOnResize
        {
            get
            {
                return _fireDomUpdatedOnResize;
            }
            set
            {
               _fireDomUpdatedOnResize = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.Carousel";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("currentIndex", _currentIndex, 0);
            state.SetPropertyValue("height", _height, 200);
            state.SetPropertyValue("scrollLoop", _scrollLoop, true);
            state.SetPropertyValue("showPagination", _showPagination, true);
            state.SetPropertyValue("transitionDuration", _transitionDuration, 0.4M);
            state.SetPropertyValue("fireDomUpdatedOnResize", _fireDomUpdatedOnResize, false);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeCurrentIndex()
        {
            if (ChangeCurrentIndex != null)
            {
                ChangeCurrentIndex.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #currentIndex}.
        /// </summary>
        public event EventHandler ChangeCurrentIndex;

    }
}
