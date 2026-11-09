using NUnit.Framework;
using System;
using System.IO;
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

        [Test]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(10, false)]
        [TestCase(13, true)]
        [TestCase(17, true)]
        [TestCase(19, true)]
        [TestCase(20, false)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        [TestCase(25, false)]
        [TestCase(29, true)]
        [TestCase(31, true)]
        [TestCase(37, true)]
        [TestCase(41, true)]
        [TestCase(43, true)]
        [TestCase(47, true)]
        [TestCase(53, true)]
        [TestCase(59, true)]
        [TestCase(61, true)]
        [TestCase(67, true)]
        [TestCase(71, true)]
        [TestCase(73, true)]
        [TestCase(79, true)]
        [TestCase(83, true)]
        [TestCase(89, true)]
        [TestCase(97, true)]
        [TestCase(100, false)]
        public void IsPrime_ReturnsExpectedResult(int number, bool expectedResult)
        {
            // Act
            bool result = _program.IsPrime(number);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

