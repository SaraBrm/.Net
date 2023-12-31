using Microsoft.AspNetCore.Mvc;
using TDD.Controllers;
using Xunit;

namespace TDDTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
