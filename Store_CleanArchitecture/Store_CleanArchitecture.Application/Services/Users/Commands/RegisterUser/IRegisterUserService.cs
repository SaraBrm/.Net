using Store_CleanArchitecture.Common.Dto;

namespace Store_CleanArchitecture.Application.Services.Users.Commands.RegisterUser
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request);
    }
}
