using NUnit.Framework;
using System;
using System.IO;
using Assignment3;
using System.Text.RegularExpressions;

namespace Assignment3.Tests
{
    [TestFixture]
    public partial class ProgramTests
    {
        private Program _program;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
        }

        [Test]
        [TestCase(1, "1 x 1 = 1\n2 x 1 = 2\n3 x 1 = 3\n4 x 1 = 4\n5 x 1 = 5\n6 x 1 = 6\n7 x 1 = 7\n8 x 1 = 8\n9 x 1 = 9\n10 x 1 = 10\n")]
        [TestCase(2, "1 x 2 = 2\n2 x 2 = 4\n3 x 2 = 6\n4 x 2 = 8\n5 x 2 = 10\n6 x 2 = 12\n7 x 2 = 14\n8 x 2 = 16\n9 x 2 = 18\n10 x 2 = 20\n")]
        [TestCase(5, "1 x 5 = 5\n2 x 5 = 10\n3 x 5 = 15\n4 x 5 = 20\n5 x 5 = 25\n6 x 5 = 30\n7 x 5 = 35\n8 x 5 = 40\n9 x 5 = 45\n10 x 5 = 50\n")]
        [TestCase(10, "1 x 10 = 10\n2 x 10 = 20\n3 x 10 = 30\n4 x 10 = 40\n5 x 10 = 50\n6 x 10 = 60\n7 x 10 = 70\n8 x 10 = 80\n9 x 10 = 90\n10 x 10 = 100\n")]
        public void PrintMultiplicationTable_PrintsCorrectTable(int number, string expectedOutput)
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _program.PrintMultiplicationTable(number);

            // Assert
            var consoleOutput = output.ToString();

            var normalizedActual = LineBreakPattern().Replace(consoleOutput, "\n");
            var normalizedExpected = LineBreakPattern().Replace(expectedOutput, "\n");

            normalizedActual = SpacePattern().Replace(normalizedActual, "");
            normalizedExpected = SpacePattern().Replace(normalizedExpected, "");

            Assert.That(normalizedActual, Is.EqualTo(normalizedExpected));
        }

        [GeneratedRegex(@"\r\n?|\n")]
        private static partial Regex LineBreakPattern();

        [GeneratedRegex(@"[ \t]+")]
        private static partial Regex SpacePattern();
    }
}
