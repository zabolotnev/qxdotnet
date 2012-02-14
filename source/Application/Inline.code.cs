using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Application
{
    public partial class Inline : AbstractGui
    {

        private UI.Layout.Canvas _canvas;

        public Inline()
        {
            _canvas = new UI.Layout.Canvas();
        }

        public new UI.Container.Composite GetRoot()
        {
            return (UI.Container.Composite) base.GetRoot();
        }

        protected internal override qxDotNet.UI.Layout.Abstract getLayout()
        {
            return _canvas;
        }
    }
}
