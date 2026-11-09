using NUnit.Framework;
using System;
using System.IO;
using Assignment4;

namespace Assignment4.Tests
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
        [TestCase(1, 10, 5, 5)]
        [TestCase(2, 5, 2, 2)]
        [TestCase(0, 0, 1, 0)]
        [TestCase(-5, 5, 5, 6)]
        [TestCase(1, 1, 0, 1)]
        public void CountEvenAndOdd_ReturnsCorrectCounts(int start, int end, int expectedEven, int expectedOdd)
        {
            // Act
            var (evenCount, oddCount) = _program.CountEvenAndOdd(start, end);

            // Assert
            Assert.That(evenCount, Is.EqualTo(expectedEven));
            Assert.That(oddCount, Is.EqualTo(expectedOdd));
        }
    }
}
