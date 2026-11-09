using NUnit.Framework;
using System;
using System.IO;
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

        [Test]
        [TestCase(3, 2, 5)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 0, 0)]
        public void Add_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Act
            int result = _program.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(-1, -1, 0)]
        [TestCase(0, 5, -5)]
        public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
        {
            // Act
            int result = _program.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(3, 2, 6)]
        [TestCase(-1, -1, 1)]
        [TestCase(0, 5, 0)]
        public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
        {
            // Act
            int result = _program.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(6, 2, 3)]
        [TestCase(-4, -2, 2)]
        [TestCase(5, 2, 2.5)]
        public void Divide_ReturnsCorrectQuotient(int a, int b, double expected)
        {
            // Act
            double result = _program.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void PerformCalculation_ExitsOnChoiceFive()
        {
            // Arrange
            var input = new StringReader("5\n");
            Console.SetIn(input);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            var task = Task.Run(() => _program.PerformCalculation());

            // Assert
            Assert.IsTrue(task.Wait(1000), "PerformCalculation did not exit in a timely manner.");
        }
    }
}


