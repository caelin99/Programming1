// LibraryTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment8.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        [Test]
        public void AddBook_ExceedsCapacity_DisplaysMessage()
        {
            // Arrange
            var library = new Library(1);
            var book1 = new Book("Title1", "Author1");
            var book2 = new Book("Title2", "Author2");
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            library.AddBook(book1);
            library.AddBook(book2);

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.That(output, Does.Contain("Library is full. Cannot add more books."));
        }

        [Test]
        public void DisplayBooks_ValidBooks_DisplaysCorrectInfo()
        {
            // Arrange
            var library = new Library(2);
            var book1 = new Book("Title1", "Author1");
            var book2 = new Book("Title2", "Author2");
            library.AddBook(book1);
            library.AddBook(book2);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            library.DisplayBooks();

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.That(output, Does.Contain("Title1 by Author1"));
            Assert.That(output, Does.Contain("Title2 by Author2"));
        }
    }
}

