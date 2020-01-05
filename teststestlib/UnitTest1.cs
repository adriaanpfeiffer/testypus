using System;
using Xunit;

namespace teststestlib
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(8)]
        public void Test1(int value)
        {
            Assert.True(value < 11);
        }
    }
}
