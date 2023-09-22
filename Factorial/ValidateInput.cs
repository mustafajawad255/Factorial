using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public static class ValidateInput
    {
        /// <summary>
        /// Validates user input as non-negative integer indicating whether it succeeded.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool ValidateUserInputAsInteger(string input)
        {
            int value;            
            var isValidInputAsNonNegativeInteger= (int.TryParse(input, out value) && value > 0);
            
            return isValidInputAsNonNegativeInteger;
        }
    }
}
