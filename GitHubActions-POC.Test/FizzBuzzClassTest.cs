using Xunit;

namespace GitHubActions_POC.Test
{
    [Trait("Category","UnitTest")]
    public class FizzBuzzClassTest
    {
        [Fact]
        public void FizzBuzzShouldReturnNumberAsStringWhenNumberProvided()
        {
            var sut = new FizzBuzz();
            Assert.Equal("1", sut.Convert(1));
        }
    }
}