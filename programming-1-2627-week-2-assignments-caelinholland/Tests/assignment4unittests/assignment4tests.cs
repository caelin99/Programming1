using NUnit.Framework;
using Assignment4;

namespace assignment4.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        [TestCase(5, 3, 8)]
        [TestCase(10, 2, 12)]
        [TestCase(-1, -1, -2)]
        public void Add_TwoNumbers_ReturnsSum(double a, double b, double expected)
        {
            // Act
            double result = _program.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result, $"For Add with inputs {a}: and {b}, expected: {expected}, but got: {result}.");
        }

        [TestCase(5, 3, 2)]
        [TestCase(10, 2, 8)]
        [TestCase(-1, -1, 0)]
        public void Subtract_TwoNumbers_ReturnsDifference(double a, double b, double expected)
        {
            // Act
            double result = _program.Subtract(a, b);

            // Assert
            Assert.AreEqual(expected, result, $"For Subtract with inputs: {a} and {b}, expected: {expected}, but got: {result}.");
        }

        [TestCase(5, 3, 15)]
        [TestCase(10, 2, 20)]
        [TestCase(-1, -1, 1)]
        public void Multiply_TwoNumbers_ReturnsProduct(double a, double b, double expected)
        {
            // Act
            double result = _program.Multiply(a, b);

            // Assert
            Assert.AreEqual(expected, result, $"For Multiply with inputs: {a} and {b}, expected: {expected}, but got: {result}.");
        }

        [TestCase(6, 3, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(-4, -2, 2)]
        public void Divide_TwoNumbers_ReturnsQuotient(double a, double b, double expected)
        {
            // Act
            double result = _program.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, $"For Divide with inputs: {a} and {b}, expected: {expected}, but got: {result}.");
        }

        [TestCase(5, 3, "+", 8)]
        [TestCase(5, 3, "-", 2)]
        [TestCase(5, 3, "*", 15)]
        [TestCase(6, 3, "/", 2)]
        public void CalculateResult_VariousOperations_ReturnsExpectedResult(double num1, double num2, string operation, double expected)
        {
            // Act
            double result = _program.CalculateResult(num1, num2, operation);

            // Assert
            Assert.AreEqual(expected, result, $"For operation: {operation} with inputs: {num1} and {num2}, expected: {expected}, but got: {result}.");
        }
    }
}
