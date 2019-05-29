using CommonLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7Sequence
{
    public class NaturalNumberSequence : BaseSequence
    {
        public NaturalNumberSequence(int number) : base(1, number)
        {

        }

        public IEnumerable<int> GetNaturalNumberSequence()
        {
            for(int i = LeftRange; i < RightRange*RightRange; i++ )
            {
                yield return i;
            }
        }
    }
}
