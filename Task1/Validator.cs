using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Validator
    {
        public static bool IsValidNumber(string number, out int result)
        {
            return Int32.TryParse(number, out result) && result >= 1 && result <= 32;
        }
    }
}
