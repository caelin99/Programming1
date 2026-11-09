// BookTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment4.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void Constructor_ValidInput_PropertiesAreSet()
        {
            // Arrange
            string title = "Test Title";
            string author = "Test Author";

            // Act
            var book = new Book(title, author);

            // Assert
            Assert.AreEqual(title, book.Title);
            Assert.AreEqual(author, book.Author);
        }

        [Test]
        public void DisplayBookInfo_ValidInput_DisplaysCorrectInfo()
        {
            // Arrange
            string title = "Test Title";
            string author = "Test Author";
            var book = new Book(title, author);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            book.DisplayBookInfo();

            // Assert
            var output = stringWriter.ToString();
            Assert.That(output, Does.Contain("Book information:"));
            Assert.That(output, Does.Contain("Title: " + title));
            Assert.That(output, Does.Contain("Author: " + author));
        }
    }
}
