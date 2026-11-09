// ProgramTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment2.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [TestCase("Monday", "Weekend is loading...")]
        [TestCase("Tuesday", "Weekend is loading...")]
        [TestCase("Wednesday", "Weekend is loading...")]
        [TestCase("Thursday", "Weekend is loading...")]
        [TestCase("Friday", "Weekend is loading...")]
        [TestCase("Saturday", "It's weekend!! Party time!")]
        [TestCase("Sunday", "It's weekend!! Party time!")]
        public void Start_ValidDayInput_DisplaysCorrectMessage(string input, string expectedMessage)
        {
            // Arrange
            var program = new Program();
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.Start();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.That(output, Does.Contain(expectedMessage));
        }
    }
}
