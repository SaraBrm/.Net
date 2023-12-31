using TDD.Models;
using Xunit;

namespace TDDTest
{
    public class SumTest
    {
        [Theory]
        [InlineData("1,5", 6)]
        [InlineData("", 0)]
        [InlineData("0", 0)]
        [InlineData("50,30,20", 100)]
        [InlineData("50,30,20,", 100)]
        public void Execute_SumNumbers_When_StringNumbers(string numbers, int expected)
        {
            //Arrange
            Sum sum = new Sum();

            //Act
            var result = sum.Execute(numbers);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
