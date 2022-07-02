using Fun.With.Dev.Palindromes.Manager.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Fun.With.Dev.Palindromes.Tests.Strategies
{
    [TestClass]
    public class CheckPalindromeIndexCheckVariation2Tests
    {
        private MockRepository mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private CheckPalindromeIndexCheckVariation2 CreateCheckPalindromeIndexCheckVariation2()
        {
            return new CheckPalindromeIndexCheckVariation2();
        }
 
        [TestMethod]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var checkPalindromeReverseMethod = this.CreateCheckPalindromeIndexCheckVariation2();
            string input = "civic";

            // Act
            var result = checkPalindromeReverseMethod.IsPalindrome(
                input);

            // Assert
            Assert.IsTrue(result);
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void IsPalindrome_StateUnderTest_ReturnsFalseIfNotAPalindrome()
        {
            // Arrange
            var checkPalindromeReverseMethod = this.CreateCheckPalindromeIndexCheckVariation2();
            string input = "abc";

            // Act
            var result = checkPalindromeReverseMethod.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
            this.mockRepository.VerifyAll();
        }
    }
}
