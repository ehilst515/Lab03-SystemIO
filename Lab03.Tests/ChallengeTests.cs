using System;
using Lab03;
using Xunit;
namespace Lab03Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new[] { 3, 4, 5 }, 60)]
        [InlineData(new[] { 7, 8 }, 0)]
        public void Challenge1_multiplies_3_nums_in_array_only(int[] inputArray, int expected)
        {
            //Act
            int result = Program.Challenge1(inputArray);

            //Assert
            Assert.Equal(result, expected);
        }
    }
}