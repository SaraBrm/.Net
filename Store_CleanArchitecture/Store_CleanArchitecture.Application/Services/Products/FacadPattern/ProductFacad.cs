﻿using Microsoft.AspNetCore.Hosting;
using Store_CleanArchitecture.Application.Interfaces.Contexts;
using Store_CleanArchitecture.Application.Interfaces.FacadPatterns;
using Store_CleanArchitecture.Application.Services.Products.Commands.AddNewCategory;
using Store_CleanArchitecture.Application.Services.Products.Commands.AddNewProduct;
using Store_CleanArchitecture.Application.Services.Products.Queries.GetAllCategories;
using Store_CleanArchitecture.Application.Services.Products.Queries.GetCategories;

namespace Store_CleanArchitecture.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public ProductFacad(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;

        }

        private AddNewCategoryService _addNewCategory;
        public AddNewCategoryService AddNewCategoryService
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryService(_context);
            }
        }


        private IGetCategoriesService _getCategoriesService;
        public IGetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService ?? new GetCategoriesService(_context);
            }
        }

        private AddNewProductService _addNewProductService;
        public AddNewProductService AddNewProductService
        {
            get
            {
                return _addNewProductService = _addNewProductService ?? new AddNewProductService(_context, _environment);
            }
        }

        private IGetAllCategoriesService _getAllCategoriesService;
        public IGetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }
    }
}
