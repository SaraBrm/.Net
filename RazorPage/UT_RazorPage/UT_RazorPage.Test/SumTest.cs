using UT_RazorPage.Models;
using Xunit;

namespace UT_RazorPage.Test
{
    public class SumTest
    {
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(5, 55, 60)]
        [InlineData(100, 100, 200)]
        public void OnValue1Value2_ReturnSumResult(int value1, int value2, int expectedResult)
        {
            Sum sum = new Sum();
            var result = sum.Execute(value1, value2);

            Assert.Equal(expectedResult, result);
        }
    }
}
