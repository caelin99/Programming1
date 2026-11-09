// RectangleTests.cs
using NUnit.Framework;
using Assignment1;

namespace Assignment1.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [TestCase(5, 10, 50)]
        [TestCase(0, 0, 0)]
        [TestCase(3.5, 2, 7)]
        public void CalculateArea_ValidDimensions_ReturnsCorrectArea(double width, double height, double expectedArea)
        {
            // Arrange
            var rectangle = new Rectangle { Width = width, Height = height };

            // Act
            double area = rectangle.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(expectedArea));
        }

        [TestCase(5, 10, 30)]
        [TestCase(0, 0, 0)]
        [TestCase(3.5, 2, 11)]
        public void CalculatePerimeter_ValidDimensions_ReturnsCorrectPerimeter(double width, double height, double expectedPerimeter)
        {
            // Arrange
            var rectangle = new Rectangle { Width = width, Height = height };

            // Act
            double perimeter = rectangle.CalculatePerimeter();

            // Assert
            Assert.That(perimeter, Is.EqualTo(expectedPerimeter));
        }
    }
}
