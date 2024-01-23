using Store_CleanArchitecture.Common.Dto;
using System.Collections.Generic;

namespace Store_CleanArchitecture.Application.Services.Users.Queries.GetRoles
{
    public interface IGetRolesService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}
