using Store_CleanArchitecture.Application.Services.Products.Commands.AddNewCategory;
using Store_CleanArchitecture.Application.Services.Products.Commands.AddNewProduct;
using Store_CleanArchitecture.Application.Services.Products.Queries.GetAllCategories;
using Store_CleanArchitecture.Application.Services.Products.Queries.GetCategories;

namespace Store_CleanArchitecture.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService GetCategoriesService { get; }
        AddNewProductService AddNewProductService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
    }
}
