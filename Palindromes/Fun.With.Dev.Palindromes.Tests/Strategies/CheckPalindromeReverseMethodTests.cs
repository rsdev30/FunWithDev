﻿using Fun.With.Dev.Palindromes.Manager.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Fun.With.Dev.Palindromes.Tests.Strategies
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
            // Arrange for odd
            var checkPalindromeReverseMethod = this.CreateCheckPalindromeReverseMethod();
            string input = "civic";

            // Act
            var result = checkPalindromeReverseMethod.IsPalindrome(
                input);

            // Assert
            Assert.IsTrue(result);


            // Arrange for even.            
            input = "ciic";

            // Act
            result = checkPalindromeReverseMethod.IsPalindrome(
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
