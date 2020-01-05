using System;
using Xunit;

namespace teststestlib
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, true)]
        [InlineData(12, false)]
        [InlineData(8, true)]
        public void Test1(int value, bool expected)
        {
            Assert.Equal(expected, value < 11);
        }
    }
}
