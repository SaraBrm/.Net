using Store_CleanArchitecture.Common.Dto;

namespace Store_CleanArchitecture.Application.Services.Users.Commands.UserStatusChange
{
    public interface IUserSatusChangeService
    {
        ResultDto Execute(long UserId);
    }
}
