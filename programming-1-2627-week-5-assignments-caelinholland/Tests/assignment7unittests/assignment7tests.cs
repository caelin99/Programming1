// StudentTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment7.Tests
{
    [TestFixture]
    public class StudentTests
    {
        [TestCase(new int[] { 90, 80, 70 }, ExpectedResult = 80)]
        [TestCase(new int[] { 100, 100, 100 }, ExpectedResult = 100)]
        [TestCase(new int[] { 50, 60, 70 }, ExpectedResult = 60)]
        [TestCase(new int[] { 0, 0, 0 }, ExpectedResult = 0)]
        public double CalculateAverageGrade_ValidGrades_ReturnsCorrectAverage(int[] grades)
        {
            // Arrange
            var student = new Student("John Doe", grades);

            // Act
            return student.CalculateAverageGrade();
        }

        [TestCase(new int[] { 90, 80, 70 }, "John Doe", "Grades for John Doe:\n90, 80, 70\nAverage Grade: 80")]
        [TestCase(new int[] { 100, 100, 100 }, "Jane Smith", "Grades for Jane Smith:\n100, 100, 100\nAverage Grade: 100")]
        [TestCase(new int[] { 50, 60, 70 }, "Alice Johnson", "Grades for Alice Johnson:\n50, 60, 70\nAverage Grade: 60")]
        public void DisplayGrades_ValidGrades_DisplaysCorrectInfo(int[] grades, string name, string expectedOutput)
        {
            // Arrange
            var student = new Student(name, grades);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            student.DisplayGrades();

            // Assert
            var output = stringWriter.ToString().Trim();
            var normalizedOutput = NormalizeLineEndings(output);
            var normalizedExpectedOutput = NormalizeLineEndings(expectedOutput);
            Assert.That(normalizedOutput, Is.EqualTo(normalizedExpectedOutput));
        }

        private string NormalizeLineEndings(string input)
        {
            return input.Replace("\r\n", "\n").Replace("\r", "\n");
        }
    }
}
