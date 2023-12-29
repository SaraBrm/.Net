using ConsoleApp.TestData;
using Xunit;
using Xunit.Abstractions;

namespace ConsoleApp.Test
{
    public class MathHelperTest
    {

        private readonly ITestOutputHelper _outputHelper;

        public MathHelperTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        //[Fact(Skip = "غیرفعال کردم")]
        //public void JamTest()
        //{
        //    MathHelper mathHelper = new MathHelper();
        //    int x = 4;
        //    int y = 5;
        //    int z = mathHelper.Jam(x, y);
        //    Assert.Equal(9, z);
        //}


        [Theory(Skip = "غیرفعال کردم")]
        [Trait("Service", "Cart")]
        [InlineData(5, 5, 10)]
        [InlineData(-5, -5, -10)]
        [InlineData(1000, 5000, 6000)]
        public void JamTest(int x, int y, int expected)
        {
            MathHelper mathHelper = new MathHelper();
            var result = mathHelper.Jam(x, y);
            Assert.Equal(expected, result);
            Assert.IsType<int>(result);
        }

        [Theory]
        [Trait("Service", "Order")]
        [MemberData(nameof(DataForTest.GetData), MemberType = typeof(DataForTest))]
        public void Jam_MemderData_Test(int x, int y, int expected)
        {
            MathHelper mathHelper = new MathHelper();
            var result = mathHelper.Jam(x, y);
            Assert.Equal(expected, result);
            Assert.IsType<int>(result);
        }

        [Theory]
        [Trait("Endpoint", "Order")]
        [ClassData(typeof(MemberCalssData))]
        public void Jam_ClassData_Test(int x, int y, int expected)
        {
            MathHelper mathHelper = new MathHelper();

            var result = mathHelper.Jam(x, y);
            _outputHelper.WriteLine("this is a test");
            _outputHelper.WriteLine(x.ToString());
            Assert.Equal(expected, result);
            Assert.IsType<int>(result);

        }
    }
}
