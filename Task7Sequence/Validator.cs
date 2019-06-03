using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7Sequence
{
    public class Validator
    {
        public static bool IsNaturalNumber(string number, out int naturalNumber)
        {
            return Int32.TryParse(number, out naturalNumber )
        }
    }
}
