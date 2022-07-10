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
        public void IsAnagram_StateUnderTest_If_Inputs_Equal_Returns_True()
        {
            // Arrange
            var anagramsContext = this.CreateAnagramsContext();
            string input1 = "god";
            string input2 = "dog";

            // Act
            var result = anagramsContext.IsAnagram(
                input1,
                input2);

            // Assert
            Assert.IsTrue(result);
            this._mockRepository.VerifyAll();
        }

        [TestMethod]
        public void IsAnagram_StateUnderTest_If_Input1_Gt_Input2_Equal_Returns_True()
        {
            // Arrange
            var anagramsContext = this.CreateAnagramsContext();
            string input1 = "anagram";
            string input2 = "rag";

            // Act
            var result = anagramsContext.IsAnagram(
                input1,
                input2);

            // Assert
            Assert.IsTrue(result);
            this._mockRepository.VerifyAll();
        }

        [TestMethod]
        public void IsAnagram_StateUnderTest_If_Input1_Lt_Input2_Equal_Returns_True()
        {
            // Arrange
            var anagramsContext = this.CreateAnagramsContext();
            string input1 = "rag";
            string input2 = "anagram";

            // Act
            var result = anagramsContext.IsAnagram(
                input1,
                input2);

            // Assert
            Assert.IsTrue(result);
            this._mockRepository.VerifyAll();
        }
    }
}
