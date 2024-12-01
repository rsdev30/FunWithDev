using Fun.With.Dev.GCD.Api.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using System.Runtime.InteropServices.Marshalling;

namespace Fun.With.Dev.GCD.Api.Tests.Controllers
{
    [TestFixture]
    public class GcdControllerTests
    {
        private MockRepository? mockRepository;

        private Mock<ILogger<GcdController>>? mockLogger;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockLogger = this.mockRepository.Create<ILogger<GcdController>>();
        }

        private GcdController CreateGcdController()
        {
            return new GcdController(
                mockLogger?.Object);
        }

        [Test]
        public async Task Get_StateUnderTest_ExpectedBehavior_All_Zero()
        {
            // Arrange
            var gcdController = this.CreateGcdController();
            uint M = 0;
            uint N = 0;

            // Act
            var result = await gcdController.Get(
                M,
                N);
            
            // Assert
            Assert.IsNotNull(result);            
            Assert.That(result?.Value?.M, Is.EqualTo(0));
            Assert.That(result?.Value?.N, Is.EqualTo(0));
            Assert.That(result?.Value?.Gcd, Is.EqualTo(0));
            mockRepository?.VerifyAll();
        }

        /// <summary>
        /// Very crude test.
        /// TODO: Add attributes for various scenarios.
        /// </summary>
        [Test]
        public async Task Get_StateUnderTest_ExpectedBehavior_Returns_The_Correct_GCD_M_45_N_45()
        {
            // Arrange
            var gcdController = this.CreateGcdController();
            uint M = 45;
            uint N = 5;
            uint expectedRemainder = 5;

            // Act
            var result = await gcdController.Get(
                M,
                N);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result?.Value?.M, Is.EqualTo(M));
            Assert.That(result?.Value?.N, Is.EqualTo(N));
            Assert.That(result?.Value?.Gcd, Is.EqualTo(expectedRemainder));
            mockRepository?.VerifyAll();
        }

        [Test]
        public async Task Get_StateUnderTest_ExpectedBehavior_Returns_The_Correct_GCD_M_Less_Than_N()
        {
            // Arrange
            var gcdController = this.CreateGcdController();
            uint M = 5;
            uint N = 45;

            // Act
            var result = await gcdController.Get(
                M,
                N);

            // Assert
            //It should swap the values since M was less than N
            Assert.IsNotNull(result);
            Assert.That(result?.Value?.M, Is.EqualTo(N));
            Assert.That(result?.Value?.N, Is.EqualTo(M));
            Assert.That(result?.Value?.Gcd, Is.EqualTo(5));
            mockRepository?.VerifyAll();
        }
    }
}
