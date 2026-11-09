using NUnit.Framework;
using Assignment1;

namespace Assignment1.Tests
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

        [Test]
        public void CalculateSum_WithPositiveNumber_ReturnsCorrectSum()
        {
            // Arrange
            int input = 5;
            int expectedSum = 15; // 1 + 2 + 3 + 4 + 5 = 15

            // Act
            int actualSum = _program.CalculateSum(input);

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }

        [Test]
        public void CalculateSum_WithZero_ReturnsZero()
        {
            // Arrange
            int input = 0;
            int expectedSum = 0;

            // Act
            int actualSum = _program.CalculateSum(input);

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }

        [Test]
        public void CalculateSum_WithNegativeNumber_ReturnsZero()
        {
            // Arrange
            int input = -5;
            int expectedSum = 0;

            // Act
            int actualSum = _program.CalculateSum(input);

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }
    }
}
