using Store_CleanArchitecture.Common.Dto;

namespace Store_CleanArchitecture.Application.Services.Products.Commands.AddNewProduct
{
    public interface IAddNewProductService
    {
        ResultDto Execute(RequestAddNewProductDto request);
    }
}
