using Store_CleanArchitecture.Common.Dto;
using System.Collections.Generic;

namespace Store_CleanArchitecture.Application.Services.Products.Queries.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<List<CategoriesDto>> Execute(long? ParentId);
    }
}



