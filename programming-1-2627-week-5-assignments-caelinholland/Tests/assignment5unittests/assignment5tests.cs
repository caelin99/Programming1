// ProgramTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment5.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Constructor_ValidInput_PropertiesAreSet()
        {
            // Arrange
            string name = "John Doe";
            int age = 30;

            // Act
            var person = new Person(name, age);

            // Assert
            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(age, person.Age);
        }

        [Test]
        public void DisplayPersonInfo_ValidInput_DisplaysCorrectInfo()
        {
            // Arrange
            string name = "John Doe";
            int age = 30;
            var person = new Person(name, age);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            person.DisplayPersonInfo();

            // Assert
            var output = stringWriter.ToString();
            Assert.That(output, Does.Contain($"Name: {name}"));
            Assert.That(output, Does.Contain($"Age: {age}"));
        }
        [Test]
        public void PrintPersonArray_ValidInput_DisplaysCorrectInfo()
        {
            // Arrange
            var persons = new Person[]
            {
                new Person("John Doe", 30),
                new Person("Jane Smith", 25),
                new Person("Alice Johnson", 40)
            };

            var program = new Program();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            program.PrintPersonArray(persons);

            // Assert
            var output = stringWriter.ToString();
            Assert.That(output, Does.Contain("Displaying all persons:"));
            Assert.That(output, Does.Contain("Person 1"));
            Assert.That(output, Does.Contain("Name: John Doe"));
            Assert.That(output, Does.Contain("Age: 30"));
            Assert.That(output, Does.Contain("Person 2"));
            Assert.That(output, Does.Contain("Name: Jane Smith"));
            Assert.That(output, Does.Contain("Age: 25"));
            Assert.That(output, Does.Contain("Person 3"));
            Assert.That(output, Does.Contain("Name: Alice Johnson"));
            Assert.That(output, Does.Contain("Age: 40"));
        }
    }
}
