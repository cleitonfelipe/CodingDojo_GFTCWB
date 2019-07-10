using System;
using Xunit;

namespace Tests
{
    public class TheorySample
    {
        //[Theory]
        //[InlineData(3)]
        //[InlineData(5)]
        //[InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}