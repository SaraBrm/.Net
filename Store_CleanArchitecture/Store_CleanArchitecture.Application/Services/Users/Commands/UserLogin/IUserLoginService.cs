using Store_CleanArchitecture.Common.Dto;

namespace Store_CleanArchitecture.Application.Services.Users.Commands.UserLogin
{
    public interface IUserLoginService
    {
        ResultDto<ResultUserloginDto> Execute(string Username, string Password);
    }
}
