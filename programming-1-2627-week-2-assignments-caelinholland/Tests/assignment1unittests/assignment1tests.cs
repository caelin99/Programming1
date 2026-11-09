using Microsoft.VisualStudio.TestPlatform.TestHost;
using Assignment1;
using NUnit.Framework;

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

        [TestCase(18, true)]
        [TestCase(17, false)]
        [TestCase(19, true)]
        [TestCase(0, false)]
        public void IsAdult_VariousAges_ReturnsExpectedResult(int age, bool expected)
        {
            // Act
            bool result = _program.IsAdult(age);

            // Assert
            Assert.AreEqual(expected, result, $"For age: {age}, expected: {expected}, but got: {result}.");

        }
    }
}
