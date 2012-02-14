using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Application
{
    public partial class Standalone : AbstractGui
    {

        private UI.Layout.Canvas _canvas;

        public Standalone()
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
