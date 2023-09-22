using Factorial;

namespace FactorialTest
{
    [TestClass]
    public class TestFactorialValidateInput
    {
        /// <summary>
        /// To verify the factorial user input when input is empty string.
        /// </summary>
        [TestMethod]
        public void TestFactorialUserInputAsEmptyString()
        {
            // Arrange
            string userInput = string.Empty;

            // Setup
            var result = ValidateInput.ValidateUserInputAsInteger(userInput);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// To verify the factorial user input as negative integer.
        /// </summary>
        [TestMethod]
        public void TestFactorialUserInputAsNegativeInteger()
        {
            // Arrange
            const string userInput = "-4";

            // Setup
            var result = ValidateInput.ValidateUserInputAsInteger(userInput);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// To verify the factorial user input as integer.
        /// </summary>
        [TestMethod]
        public void TestFactorialUserInputAsInteger()
        {
            // Arrange
            const string userInput = "4";            

            // Setup
            var result = ValidateInput.ValidateUserInputAsInteger(userInput);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// To verify the factorial user input as non-integer.
        /// </summary>
        [TestMethod]
        public void TestFactorialUserInputAsNonInteger()
        {
            // Arrange
            const string userInput = "Hello";

            // Setup
            var result = ValidateInput.ValidateUserInputAsInteger(userInput);

            // Assert
            Assert.IsFalse(result);
        }      

    }
}