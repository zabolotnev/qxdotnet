using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Application
{
    public abstract partial class AbstractGui : Core.Object, IApplication
    {

        private UI.Container.Composite _container;

        public AbstractGui()
        {
            _container = new rootContainer();
        }

        protected internal abstract qxDotNet.UI.Layout.Abstract getLayout();
        

        public virtual void Main()
        {

        }

        public virtual void ProcessRequest()
        {

        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            if (isNewOnly)
            {
                yield return null;
            }
            else
            {
                yield return _container;
            }
        }

        internal override bool DisallowCreation
        {
            get
            {
                return true;
            }
        }

        public UI.Core.Widget GetRoot()
        {
            return _container;
        }

        private class rootContainer : UI.Container.Composite
        {

            protected internal override string GetReference()
            {
                return "root";
            }

            internal override bool DisallowCreation
            {
                get
                {
                    return true;
                }
            }

        }

    }
}
