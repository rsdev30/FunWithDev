using Fun.With.Dev.Anagrams.Contracts;
using Fun.With.Dev.Anagrams.Managers.Strategies;
using Fun.With.Dev.Anagrams.Managers.Strategies.Contexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Fun.With.Dev.Anagrams.Tests.MSTests.Strategies.Contexts
{
    [TestClass]
    public class AnagramsContextTests
    {
        private MockRepository _mockRepository;

        private IAnagramsCheck<string, string> _anagramsCheck;

        [TestInitialize]
        public void TestInitialize()
        {
            this._mockRepository = new MockRepository(MockBehavior.Strict);

            this._anagramsCheck = new CheckAnagramVariation1();
        }

        private AnagramsContext CreateAnagramsContext()
        {
            return new AnagramsContext(
                this._anagramsCheck);
        }

        [TestMethod]
        public void IsAnagram_StateUnderTest_If_Inputs_Null_Returns_False()
        {
            // Arrange
            var anagramsContext = this.CreateAnagramsContext();
            string input1 = null;
            string input2 = null;

            // Act
            var result = anagramsContext.IsAnagram(
                input1,
                input2);

            // Assert
            Assert.IsFalse(result);
            this._mockRepository.VerifyAll();
        }

        [TestMethod]
        public void IsAnagram_StateUnderTest_If_Inputs_Null_Returns_True()
        {
            // Arrange
            var anagramsContext = this.CreateAnagramsContext();
            string input1 = "amarna";
            string input2 = "ragman";

            // Act
            var result = anagramsContext.IsAnagram(
                input1,
                input2);

            // Assert
            Assert.IsFalse(result);
            this._mockRepository.VerifyAll();
        }
    }
}
