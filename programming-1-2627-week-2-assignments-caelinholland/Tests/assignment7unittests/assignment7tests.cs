using NUnit.Framework;
using Assignment7;

namespace Assignment7.Tests
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

        [TestCase(2024, true)]
        [TestCase(1900, false)]
        [TestCase(2000, true)]
        [TestCase(2019, false)]
        public void IsLeapYear_VariousYears_ReturnsExpectedResult(int year, bool expected)
        {
            // Act
            bool result = _program.IsLeapYear(year);

            // Assert
            Assert.AreEqual(expected, result, $"For year: {year}, expected: {expected}, but got: {result}.");
        }
    }
}


