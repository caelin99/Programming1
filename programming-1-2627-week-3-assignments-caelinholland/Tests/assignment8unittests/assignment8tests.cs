using NUnit.Framework;
using Assignment8;

namespace Assignment8.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private Program program;

        [SetUp]
        public void Setup()
        {
            program = new Program();
        }

        [Test]
        [TestCase(3, new int[] { 1, 2, 3 }, 6)]
        [TestCase(4, new int[] { 1, 1, 1, 1 }, 4)]
        [TestCase(2, new int[] { 5, 5 }, 10)]
        public void CalculateSum_WithValidInput_ReturnsCorrectSum(int count, int[] inputs, int expectedSum)
        {
            // Act
            int actualSum = 0;
            for (int i = 0; i < count; i++)
            {
                actualSum += inputs[i];
            }

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }

        [Test]
        [TestCase(6, 3, 2.0)]
        [TestCase(4, 4, 1.0)]
        [TestCase(10, 2, 5.0)]
        public void CalculateAverage_WithValidInput_ReturnsCorrectAverage(int sum, int count, double expectedAverage)
        {
            // Act
            double actualAverage = program.CalculateAverage(sum, count);

            // Assert
            Assert.That(actualAverage, Is.EqualTo(expectedAverage).Within(0.001));
        }
    }
}
