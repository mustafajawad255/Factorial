using System;

namespace Factorial
{
    static class Program
    {
        static void Main()
        {
            try
            {
                string userInput = ReadUserInput();

                if (!string.IsNullOrEmpty(userInput))
                {
                    var isValidInputToProcessFactorial = ValidateInput.ValidateUserInputAsInteger(userInput);
                    
                    if (isValidInputToProcessFactorial)
                    {
                        var factorialResult = ProcessFactorial.CalculateFactorial(int.Parse(userInput));
                        
                        Console.WriteLine("Factorial : {0}", factorialResult);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a non-negative integer value and try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a integer value and try again.");
                }
            }     
            catch (Exception ex)
            {
                throw new Exception("Factorial cannot be generated.", ex);
            }

            Console.WriteLine();
            Console.WriteLine("Any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Returning user input from Console.
        /// </summary>
        /// <returns></returns>
        private static string ReadUserInput()
        {
            Console.Write("Number : ");
            var userInput = Console.ReadLine();
            return userInput;
        }
    }

}