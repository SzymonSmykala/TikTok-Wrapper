using FluentAssertions;
using NUnit.Framework;
using TikTokWrapper.Core;
using TikTokWrapper.Core.Factories;

namespace TikToWrapper.FunctionalTests
{
    [TestFixture]
    public class TrendingTests
    {
        private ITikTokManager _sut;

        [SetUp]
        public void SetUp()
        {
            var factory = new TikTokManagerFactory();
            _sut = factory.Create();
        }

        [Test]
        public void ShouldGetTrendingData()
        {
            // Arrange
            var expectedNumberOfTikToks = 10;

            // Act
            var actual = _sut.GetTrending();

            // Assert
            actual.Count.Should().Be(expectedNumberOfTikToks);
            actual.ForEach(x => x.id.Should().NotBeNullOrEmpty());
        }
        
    }
}