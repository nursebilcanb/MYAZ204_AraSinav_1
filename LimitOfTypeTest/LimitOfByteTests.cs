using LimitOfTypes;
using System;
using Xunit;

namespace LimitOfTypeTests
{
    public class LimitOfByteTests
    {
        [Fact]
        public void GetMaximum_Test()
        {
            
            byte max = 255;

            byte maxByte = new LimitOfTypes.LimitOfByte().GetMaximum;


            Assert.Equal(maxByte,max);
        }

        [Fact]
        public void GetMinimum_Test()
        {
            byte min = 0;

            byte minByte = new LimitOfTypes.LimitOfByte().GetMinimum;

            Assert.Equal(minByte,min);
        }


        [Theory]
        [InlineData("10000000",128)]
        [InlineData("11111111", 255)]
        [InlineData("00001000", 8)]
        [InlineData("00001001", 9)]
        [InlineData("00001111", 15)]
        [InlineData("00001010", 10)]
        public void GetUnsigned_Number(string input, int output)
        {
            var getUnsigned = new LimitOfTypes.LimitOfByte().GetUnSignedNumber(input);

            Assert.Equal(output, getUnsigned);
        }
    }
}
