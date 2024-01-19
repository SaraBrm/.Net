using DI_InMiddleware.Controllers;
using DI_InMiddleware.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace DI_InMiddleware.Test
{
    public class ProductControllerTest
    {
        [Fact]
        public void Index()
        {
            List<Product> data = new List<Product>()
             {
                  new Product { Id = 0 , Name =" this is a test product"},
                  new Product { Id = 0 , Name =" this is a test product"},
                  new Product { Id = 0 , Name =" this is a test product"},
                  new Product { Id = 0 , Name =" this is a test product"},
             };

            var moq = new Mock<IProductRepository>();
            moq.Setup(p => p.GetProducts()).Returns(data);


            ProductController productController = new ProductController(moq.Object);

            ViewResult result = productController.Index() as ViewResult;

            Assert.Equal(data, result.Model);

        }
    }
}
