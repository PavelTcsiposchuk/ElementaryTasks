using CommonLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8FibonacciSequence
{
    public class FibonacciSequence : BaseSequence
    {
        #region Constructor

        public FibonacciSequence(int leftRange, int rightRange) : base(leftRange, rightRange)
        {

        }

        #endregion

        #region Method 

        public IEnumerable<int> GetFibonacciSequence()
        {
            for(int index = LeftRange; RightRange > index*index; index++ )
            {
                yield return index;
            }
        }

        #endregion
    }
}
