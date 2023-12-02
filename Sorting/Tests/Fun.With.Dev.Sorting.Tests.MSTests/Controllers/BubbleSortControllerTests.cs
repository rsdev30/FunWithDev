using Fun.With.Dev.Sorting.API.Controllers;
using Fun.With.Dev.Sorting.Contracts.Interfaces;
using Fun.With.Dev.Sorting.Domains.Sorting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Fun.With.Dev.Sorting.Tests.MSTests.Controllers
{
    [TestClass]
    public class BubbleSortControllerTests
    {
        private MockRepository mockRepository;

        private Mock<ILogger<BubbleSortController>> mockLogger;
        private IBubbleSort<IList<int>, IList<int>> mockBubbleSort;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Loose);

            this.mockLogger = this.mockRepository.Create<ILogger<BubbleSortController>>();
            this.mockBubbleSort = new BubbleSort();
        }

        private BubbleSortController CreateBubbleSortController()
        {
            return new BubbleSortController(
                this.mockLogger.Object,
                this.mockBubbleSort);
        }

        [TestMethod]
        public void Post_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var bubbleSortController = this.CreateBubbleSortController();
            int[] value = [5,4,3,2,1];
            int[] expected = [1, 2, 3, 4, 5];
            // Act
            var result = bubbleSortController.Post(value).GetAwaiter().GetResult();

            // Assert
            Assert.IsTrue( Enumerable.SequenceEqual(expected, result));
            this.mockRepository.VerifyAll();
        }
    }
}
