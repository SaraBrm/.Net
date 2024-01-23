using Store_CleanArchitecture.Common.Dto;

namespace Store_CleanArchitecture.Application.Services.Users.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEdituserDto request);
    }
}
