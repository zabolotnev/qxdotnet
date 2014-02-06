using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Layout
{
    /// <summary>
    /// A card layout.  The card layout lays out widgets in a stack. Call show to display a widget. Only the widget which show method is called is displayed. All other widgets are excluded.  Example  Here is a little example of how to use the Card layout.   var layout = new qx.ui.mobile.layout.Card()); var container = new qx.ui.mobile.container.Composite(layout);  var label1 = new qx.ui.mobile.basic.Label(\1\); container.add(label1); var label2 = new qx.ui.mobile.basic.Label(\2\); container.add(label2);  label2.show(); 
    /// </summary>
    public partial class Card : qxDotNet.UI.Mobile.Layout.Abstract
    {

        private int _animationDuration = 350;
        private string _defaultAnimation = "slide";
        private bool? _showAnimation = true;
        private qxDotNet.UI.Mobile.Layout.CardAnimation _cardAnimation = null;


        /// <summary>
        /// Transition duration of each animation.
        /// </summary>
        public int AnimationDuration
        {
            get
            {
                return _animationDuration;
            }
            set
            {
               _animationDuration = value;
            }
        }

        /// <summary>
        /// The default animation to use for page transition
        /// </summary>
        public string DefaultAnimation
        {
            get
            {
                return _defaultAnimation;
            }
            set
            {
               _defaultAnimation = value;
            }
        }

        /// <summary>
        /// Flag which indicates, whether animation is needed, or widgets should only swap.
        /// </summary>
        public bool? ShowAnimation
        {
            get
            {
                return _showAnimation;
            }
            set
            {
               _showAnimation = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Mobile.Layout.CardAnimation CardAnimation
        {
            get
            {
                return _cardAnimation;
            }
            set
            {
               _cardAnimation = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.layout.Card";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("animationDuration", _animationDuration, 350);
            state.SetPropertyValue("defaultAnimation", _defaultAnimation, "slide");
            state.SetPropertyValue("showAnimation", _showAnimation, true);
            state.SetPropertyValue("cardAnimation", _cardAnimation, null);

            if (AnimationEnd != null)
            {
                state.SetEvent("animationEnd", false);
            }
            if (AnimationStart != null)
            {
                state.SetEvent("animationStart", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "animationEnd")
            {
                OnAnimationEnd();
            }
            if (eventName == "animationStart")
            {
                OnAnimationStart();
            }
        }

        protected virtual void OnAnimationEnd()
        {
            if (AnimationEnd != null)
            {
                AnimationEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the animation of a page transition ends
        /// </summary>
        public event EventHandler AnimationEnd;

        protected virtual void OnAnimationStart()
        {
            if (AnimationStart != null)
            {
                AnimationStart.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the animation of a page transition starts
        /// </summary>
        public event EventHandler AnimationStart;

    }
}
