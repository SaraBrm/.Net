using Store_CleanArchitecture.Common.Dto;
using System.Collections.Generic;

namespace Store_CleanArchitecture.Application.Services.Products.Queries.GetAllCategories
{
    public interface IGetAllCategoriesService
    {
        ResultDto<List<AllCategoriesDto>> Execute();
    }
}
