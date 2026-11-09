using NUnit.Framework;
using Assignment6;

namespace Assignment6.Tests
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

        [TestCase(95, "A")]
        [TestCase(85, "B")]
        [TestCase(75, "C")]
        [TestCase(65, "D")]
        [TestCase(55, "F")]
        public void GetGrade_VariousScores_ReturnsExpectedGrade(int score, string expected)
        {
            // Act
            string result = _program.GetGrade(score);

            // Assert
            Assert.AreEqual(expected, result, $"For score: {score}, expected: {expected}, but got: {result}.");
        }
    }
}

