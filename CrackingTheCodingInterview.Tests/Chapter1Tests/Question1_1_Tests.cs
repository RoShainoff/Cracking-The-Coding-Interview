using CrackingTheCodingInterview.Code.Chapter_1;
using Xunit;

namespace CrackingTheCodingInterview.Tests.Chapter1Tests
{
    public class Question1_1_Tests
    {
        [Fact]
        public void AreAllCharactersUnique_CorrectTest()
        {
            // Act
            var result = Question1_1.AreAllCharactersUnique("123456");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AreAllCharactersUnique_IncorrectTest()
        {
            // Act
            var result = Question1_1.AreAllCharactersUnique("123456_123456");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreAllCharactersUniqueNoAdditionalMemory_CorrectTest()
        {
            // Act
            var result = Question1_1.AreAllCharactersUniqueNoAdditionalMemory("123456");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AreAllCharactersUniqueNoAdditionalMemory_IncorrectTest()
        {
            // Act
            var result = Question1_1.AreAllCharactersUniqueNoAdditionalMemory("123456_123456");

            // Assert
            Assert.False(result);
        }
    }
}
