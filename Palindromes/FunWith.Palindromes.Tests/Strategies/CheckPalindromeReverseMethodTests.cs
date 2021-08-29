using FunWith.Palindromes.Manager.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace FunWith.Palindromes.Tests.Strategies
{
    [TestClass]
    public class CheckPalindromeReverseMethodTests
    {
        private MockRepository mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private CheckPalindromeReverseMethod CreateCheckPalindromeReverseMethod()
        {
            return new CheckPalindromeReverseMethod();
        }

        [TestMethod]
        public void IsPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var checkPalindromeReverseMethod = this.CreateCheckPalindromeReverseMethod();
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
            var checkPalindromeReverseMethod = this.CreateCheckPalindromeReverseMethod();
            string input = "abc";

            // Act
            var result = checkPalindromeReverseMethod.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
            this.mockRepository.VerifyAll();
        }
    }
}
