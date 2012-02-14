using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet
{
    public class Pair<L, R>
    {
        private L _leftPair;
        private R _rightPair;

        public Pair(L leftPair, R rightPair)
        {
            _leftPair = leftPair;
            _rightPair = rightPair;
        }

        public L LeftPair
        {
            get
            {
                return _leftPair;
            }
            set
            {
                _leftPair = value;
            }
        }

        public R RightPair
        {
            get
            {
                return _rightPair;
            }
            set
            {
                _rightPair = value;
            }
        }

    }
}
