using FunWIth.Palindromes.API.Controllers;
using FunWith.Palindromes.Manager.Strategies.Contexts;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Fun.With.Dev.Palindromes.Tests.Controllers
{
    [TestClass]
    public class PalindromeControllerTests
    {
        private MockRepository mockRepository;

        private Mock<ILogger<PalindromeController>> mockLogger;
        private Mock<PalindromeContext> mockPalindromeContext;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockLogger = this.mockRepository.Create<ILogger<PalindromeController>>();
            this.mockPalindromeContext = this.mockRepository.Create<PalindromeContext>();
        }

        private PalindromeController CreatePalindromeController()
        {
            return new PalindromeController(
                this.mockLogger.Object,
                this.mockPalindromeContext.Object);
        }

        [TestMethod]
        public void GetIsPalindrome_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var palindromeController = this.CreatePalindromeController();
            string word = null;

            // Act
            var result = palindromeController.GetIsPalindrome(
                word);

            // Assert
            Assert.IsFalse(result);
            this.mockRepository.VerifyAll();
        }
    }
}
