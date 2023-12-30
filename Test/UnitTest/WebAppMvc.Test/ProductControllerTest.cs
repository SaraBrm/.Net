﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using WebAppMvc.Controllers;
using WebAppMvc.Models.Entites;
using WebAppMvc.Models.MockData;
using WebAppMvc.Models.Services;
using Xunit;

namespace WebAppMvc.Test
{
    public class ProductControllerTest
    {

        [Fact]
        public void Index_Test()
        {
            //Arrange
            MoqData moqdata = new MoqData();
            //List<Product> products = new List<Product>() { 
            //    new Product { Id = 1,Name="Usb", Description="usb",Price=200}
            //};

            var moq = new Mock<IProductService>();
            moq.Setup(p => p.GetAll()).Returns(moqdata.GetAll);
            ProductController productController = new ProductController(moq.Object);

            //Act
            var result = productController.Index();

            //Assert

            Assert.IsType<ViewResult>(result);
            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<List<Product>>(viewResult.ViewData.Model);
        }

        [Theory]
        [InlineData(1, -1)]
        public void Details_Test(int ValidId, int inValidId)
        {
            //Arrange
            MoqData moqData = new MoqData();
            var moq = new Mock<IProductService>();
            moq.Setup(p => p.GetById(ValidId)).Returns(moqData.GetAll().FirstOrDefault(p => p.Id == ValidId));
            ProductController productController = new ProductController(moq.Object);
            
            //Act
            var result = productController.Details(ValidId);

            //Assert
            Assert.IsType<ViewResult>(result);
            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<Product>(viewResult.ViewData.Model);

            //*************************************************************

            //Arrange
            moq.Setup(p => p.GetById(inValidId)).Returns(moqData.GetAll().FirstOrDefault(p => p.Id == inValidId));
            //Act
            var invalidResult = productController.Details(inValidId);
            //Assert
            Assert.IsType<NotFoundResult>(invalidResult);
        }

        [Fact]
        public void Create_Test()
        {
            //Areange
            var moq = new Mock<IProductService>();
            ProductController controller = new ProductController(moq.Object);
            Product product = new Product()
            {
                Id = 1,
                Description = "cccc",
                Name = "Samsung",
                Price = 4500
            };

            //Act
            var result = controller.Create(product);

            //Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirect.ActionName);
            Assert.Null(redirect.ControllerName);

            //invalid data******

            //Areange
            Product invalidProduct = new Product()
            {
                Price = 5,
            };
            controller.ModelState.AddModelError("Name", "نام را وارد کنید");

            //Act
            var invalidResult = controller.Create(invalidProduct);

            //Assert
            Assert.IsType<BadRequestObjectResult>(invalidResult);
        }
    }
}
