using Store_CleanArchitecture.Common.Dto;

namespace Store_CleanArchitecture.Application.Services.Products.Commands.AddNewCategory
{
    public interface IAddNewCategoryService
    {
        ResultDto Execute(long? ParentId, string Name);
    }
}
