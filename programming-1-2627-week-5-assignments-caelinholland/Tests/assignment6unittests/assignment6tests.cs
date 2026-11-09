// VotingSystemTests.cs
using NUnit.Framework;
using System;
using System.IO;

namespace Assignment6.Tests
{
    [TestFixture]
    public class VotingSystemTests
    {
        [Test]
        public void CastVote_ExceedsArraySize_DisplaysMessage()
        {
            // Arrange
            var votingSystem = new VotingSystem(1);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            votingSystem.CastVote(VoteOption.Yes);
            votingSystem.CastVote(VoteOption.No);

            // Assert
            var output = stringWriter.ToString();
            Assert.That(output, Does.Contain("All votes have been cast."));
        }

        [Test]
        public void DisplayResults_ValidVotes_DisplaysCorrectCounts()
        {
            // Arrange
            var votingSystem = new VotingSystem(3);
            votingSystem.CastVote(VoteOption.Yes);
            votingSystem.CastVote(VoteOption.No);
            votingSystem.CastVote(VoteOption.Yes);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            votingSystem.DisplayResults();

            // Assert
            var output = stringWriter.ToString();
            Assert.That(output, Does.Contain("Yes: 2"));
            Assert.That(output, Does.Contain("No: 1"));
        }
    }
}

