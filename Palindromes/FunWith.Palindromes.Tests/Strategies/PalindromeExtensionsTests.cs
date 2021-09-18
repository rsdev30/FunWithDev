using Fun.With.Dev.Palindromes.Manager.Strategies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunWith.Palindromes.Tests.Strategies
{
    [TestClass]
    public class PalindromeExtensionTests
    {        
        [TestInitialize]
        public void TestInitialize()
        {            
        }

        [TestMethod]
        public void IsPalindrome_StateUnderTest_ReturnsTrueIfNotAPalindrome()
        {
            // Arrange            
            string input = "civic";

            // Act
            var result = input.IsPalindrome();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_StateUnderTest_ReturnsFalseIfNotAPalindrome()
        {
            // Arrange            
            string input = "abc";

            // Act
            var result = input.IsPalindrome();

            // Assert
            Assert.IsFalse(result);            
        }
    }
}
