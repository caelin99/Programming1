using NUnit.Framework;
using Assignment5;

namespace Assignment5.Tests
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

        [TestCase(10, 5, 3, 10)]
        [TestCase(5, 10, 3, 10)]
        [TestCase(5, 3, 10, 10)]
        [TestCase(5, 5, 5, 5)]
        [TestCase(-5, -10, -3, -3)]
        public void FindMax_VariousInputs_ReturnsExpectedResult(int num1, int num2, int num3, int expected)
        {
            // Act
            int result = _program.FindMax(num1, num2, num3);

            // Assert
            Assert.AreEqual(expected, result, $"For inputs: {num1}, {num2}, {num3}, expected: {expected}, but got: {result}.");
        }
    }
}
