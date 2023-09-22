using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public static class ProcessFactorial
    {
        /// <summary>
        /// Returns the calculated factorial of the number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int CalculateFactorial(int number)
        {
            var factorialResult = default(int);

            try
            {
                factorialResult = Enumerable.Range(1, number).Aggregate(1, (p, item) => p * item);
            }
            catch (OverflowException overflowException)
            {
                throw new OverflowException("Error: Overflow occurs with the Input.", overflowException);
            }
            catch (ArgumentOutOfRangeException outOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Error: Input argument was out of range.", outOfRangeException);
            }
            catch (FormatException formatException)
            {
                throw new FormatException("Error: Input is not in correct format.", formatException);
            }
            catch (InvalidOperationException formatException)
            {
                throw new FormatException("Error: The operation is invalid.", formatException);
            }

            return factorialResult;
        }
    }
}
