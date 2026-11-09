using NUnit.Framework;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment7.Tests
{
    [TestFixture]
    public partial class ProgramTests
    {
        private Program program;
        private StringWriter stringWriter;

        [SetUp]
        public void SetUp()
        {
            program = new Program();
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            stringWriter.Dispose();
            Console.SetOut(Console.Out); // Reset the console output to the default
        }

        [TestCase(5, "XXXXX\nX   X\nX   X\nX   X\nXXXXX\n")]
        [TestCase(3, "XXX\nX X\nXXX\n")]
        [TestCase(1, "X\n")]
        public void PrintSquare_VariousDimensions_PrintsCorrectPattern(int dimensionSize, string expectedOutput)
        {
            // Act
            program.PrintSquare(dimensionSize);

            // Assert
            var output = stringWriter.ToString();
            var normalizedOutput = SquarePattern().Replace(output, "\n");

            Assert.That(normalizedOutput, Is.EqualTo(expectedOutput));
        }

        [GeneratedRegex(@"\r\n?|\n")]
        private static partial Regex SquarePattern();
    }
}
