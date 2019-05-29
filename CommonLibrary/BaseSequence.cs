using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public abstract class BaseSequence
    {
        #region Properties

        public int LeftRange { get; set; }
        public int RightRange { get; set; }

        #endregion

        #region Constructors

        public BaseSequence(int leftRange, int rightRange)
        {
            LeftRange = leftRange;
            RightRange = rightRange;
        }

        #endregion
    }
}
