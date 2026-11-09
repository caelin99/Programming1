using NUnit.Framework;
using Assignment2;

namespace Assignment2.Tests
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

        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(0, true)]
        [TestCase(-2, true)]
        [TestCase(-3, false)]
        public void IsEven_VariousNumbers_ReturnsExpectedResult(int number, bool expected)
        {
            // Act
            bool result = _program.IsEven(number);

            // Assert
            Assert.AreEqual(expected, result, $"For number: {number}, expected: {expected}, but got: {result}.");
        }
    }
}
