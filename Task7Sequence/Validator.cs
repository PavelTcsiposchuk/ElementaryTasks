using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7Sequence
{
    public class Validator
    {
        public static bool IsValidNumber(string number, out int result)
        {
            return int.TryParse(number, out result) && result > 0;
        }
    }
}
