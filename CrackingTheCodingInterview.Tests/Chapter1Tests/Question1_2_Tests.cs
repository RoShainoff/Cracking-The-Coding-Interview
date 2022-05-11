using CrackingTheCodingInterview.Code.Chapter_1;
using Xunit;

namespace CrackingTheCodingInterview.Tests.Chapter1Tests
{
    public class Question1_2_Tests
    {
        [Fact]
        public void AreStringsPermutation_CorrectTest()
        {
            // Act
            var result = Question1_2.AreStringsPermutation("123456", "123456");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AreStringsPermutation_String1IsEmpty_CorrectTest()
        {
            // Act
            var result = Question1_2.AreStringsPermutation("", "123456");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreStringsPermutation_String2IsEmpty_CorrectTest()
        {
            // Act
            var result = Question1_2.AreStringsPermutation("123456", "");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreStringsPermutationNoSort_CorrectTest()
        {
            // Act
            var result = Question1_2.AreStringsPermutationNoSort("123456", "123456");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AreStringsPermutationNoSort_String1IsEmpty_CorrectTest()
        {
            // Act
            var result = Question1_2.AreStringsPermutationNoSort("", "123456");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AreStringsPermutationNoSort_String2IsEmpty_CorrectTest()
        {
            // Act
            var result = Question1_2.AreStringsPermutationNoSort("123456", "");

            // Assert
            Assert.False(result);
        }
    }
}
