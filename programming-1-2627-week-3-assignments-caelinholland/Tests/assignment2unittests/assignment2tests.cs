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

        [Test]
        public void CalculateFactorial_WithZero_ReturnsOne()
        {
            // Arrange
            int input = 0;
            long expectedFactorial = 1;

            // Act
            long actualFactorial = _program.CalculateFactorial(input);

            // Assert
            Assert.That(actualFactorial, Is.EqualTo(expectedFactorial));
        }

        [Test]
        public void CalculateFactorial_WithOne_ReturnsOne()
        {
            // Arrange
            int input = 1;
            long expectedFactorial = 1;

            // Act
            long actualFactorial = _program.CalculateFactorial(input);

            // Assert
            Assert.That(actualFactorial, Is.EqualTo(expectedFactorial));
        }

        [Test]
        public void CalculateFactorial_WithPositiveNumber_ReturnsCorrectFactorial()
        {
            // Arrange
            int input = 5;
            long expectedFactorial = 120; // 5! = 5 * 4 * 3 * 2 * 1 = 120

            // Act
            long actualFactorial = _program.CalculateFactorial(input);

            // Assert
            Assert.That(actualFactorial, Is.EqualTo(expectedFactorial));
        }

        [Test]
        public void CalculateFactorial_WithLargeNumber_ReturnsCorrectFactorial()
        {
            // Arrange
            int input = 10;
            long expectedFactorial = 3628800; // 10! = 10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1 = 3628800

            // Act
            long actualFactorial = _program.CalculateFactorial(input);

            // Assert
            Assert.That(actualFactorial, Is.EqualTo(expectedFactorial));
        }
    }
}
