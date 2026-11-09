// ProgramTests.cs
using NUnit.Framework;
using System;
using System.Globalization;
using System.IO;

namespace Assignment3.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { -1, -2, -3 }, -6)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void CalculateSum_ValidInput_ReturnsCorrectSum(int[] numbers, int expectedSum)
        {
            // Arrange
            var program = new Program();

            // Act
            int sum = program.CalculateSum(numbers);

            // Assert
            Assert.That(sum, Is.EqualTo(expectedSum));
        }

        [TestCase(new int[] { 1, 2, 3 }, 2.0)]
        [TestCase(new int[] { -1, -2, -3 }, -2.0)]
        [TestCase(new int[] { 0, 0, 0 }, 0.0)]
        public void CalculateAverage_ValidInput_ReturnsCorrectAverage(int[] numbers, double expectedAverage)
        {
            // Arrange
            var program = new Program();

            // Act
            double average = program.CalculateAverage(numbers);

            // Assert
            Assert.That(average, Is.EqualTo(expectedAverage).Within(0.01));
        }

        [Test]
        public void Start_ValidInput_DisplaysCorrectSumAndAverage()
        {
            // Arrange
            var program = new Program();
            var input = $"1{Environment.NewLine}2{Environment.NewLine}3{Environment.NewLine}";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.Start();

            // Assert
            var output = stringWriter.ToString();
            var cultureInfo = CultureInfo.CurrentCulture;
            var expectedSum = "Sum: 6";
            var expectedAverage = $"Average: {2.00.ToString("0.00", cultureInfo)}";

            Assert.That(output, Does.Contain(expectedSum));
            Assert.That(output, Does.Contain(expectedAverage));
        }
    }
}
