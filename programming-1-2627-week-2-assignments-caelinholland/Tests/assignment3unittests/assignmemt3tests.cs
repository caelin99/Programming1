using NUnit.Framework;
using Assignment3;
using System.IO;

namespace Assignment3.Tests
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

        [TestCase(5, "number is positive")]
        [TestCase(-3, "number is negative")]
        [TestCase(0, "number is zero")]
        public void CheckNumber_VariousNumbers_PrintsExpectedMessage(int number, string expected)
        {
            using StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            _program.CheckNumber(number);

            // Assert
            Assert.That(sw.ToString(), Does.Contain(expected), $"For number: {number}, expected '{expected}' to be part of the generated output: '{sw}', but no matching text (string) was found. Be sure to double-check your spelling.");
        }
    }
}

