using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UT_RazorPage.Pages;
using Xunit;

namespace UT_RazorPage.Test
{
    public class IndexPageTest
    {
        [Fact]
        public void OnPost_ifInvalidModel_ReturnBadRequest()
        {
            //arrange
            var pagemodel = new IndexModel();

            //Act
            pagemodel.ModelState.AddModelError("Error", "test error");
            var result = pagemodel.OnPost();

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnPost_ifValidModel_ReturnPage()
        {
            //Arrenge
            var pagemodel = new IndexModel();

            //act
            var result = pagemodel.OnPost();

            //Assert
            Assert.IsType<PageResult>(result);
        }

        [Fact]
        public void OnGet_ReturnPage()
        {
            //Arrenge
            var pagemodel = new IndexModel();

            //act
            var result = pagemodel.OnGet();

            //Assert
            Assert.IsType<PageResult>(result);
        }
    }
}
