using System;
using Xunit;

namespace GitHubActions_POC.Test
{
    []
    public class FizzBuzzClassTest
    {
        [Fact]
        // [Trait("Category","UnitTest")]
        public void FizzBuzzShouldReturnNumberAsStringWhenNumberProvided()
        {
            var sut = new FizzBuzz();
            Assert.Equal("1", sut.Convert(1));
        }
    }
}