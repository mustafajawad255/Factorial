using Factorial;

namespace FactorialTest
{
    [TestClass]
    public class TestFactorialOutput
    {

        /// <summary>
        /// To verify the factorial result when input is negative integer number.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
        "A user input of negative number is out of range.")]
        public void TestFactorialResultOfNegativeIntegerThrowsArgumentOutOfRangeException()
        {
            // Arrange
            const int userInput = -5;

            // Setup
            var result = ProcessFactorial.CalculateFactorial(userInput);

            // Assert
            Assert.Fail();
        }      

        /// <summary>
        /// To verify the factorial result when input is string.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException),
        "A user input is not an integer throws format exception.")]
        public void TestFactorialResultThowsFormatException()
        {
            // Arrange
            string userInput = "Hello";

            // Setup
            var result = ProcessFactorial.CalculateFactorial(int.Parse(userInput));

            // Assert
            Assert.Fail();
        }

        /// <summary>
        /// To verify the factorial result when input is 0.
        /// </summary>
        [TestMethod]
        public void TestFactorialZeroResult()
        {
            // Arrange
            const int userInput = 0;
            const int expectedOutput = 1;

            // Setup
            var result = ProcessFactorial.CalculateFactorial(userInput);

            // Assert
            Assert.AreEqual(result, expectedOutput);
        }

        /// <summary>
        /// To verify the factorial result when input is 11.
        /// </summary>
        [TestMethod]
        public void TestFactorialResult()
        {
            // Arrange
            const int userInput = 11;
            const int expectedOutput = 39916800;

            // Setup
            var result = ProcessFactorial.CalculateFactorial(userInput);

            // Assert
            Assert.AreEqual(result, expectedOutput);
        }

        /// <summary>
        /// To verify the factorial result when input is 5.
        /// </summary>
        [TestMethod]
        public void TestFactorialResultOfSingleDigitInteger()
        {
            // Arrange
            const int userInput = 5;
            const int expectedOutput = 120;

            // Setup
            var result = ProcessFactorial.CalculateFactorial(userInput);

            // Assert
            Assert.AreEqual(result, expectedOutput);
        }        

    }
}