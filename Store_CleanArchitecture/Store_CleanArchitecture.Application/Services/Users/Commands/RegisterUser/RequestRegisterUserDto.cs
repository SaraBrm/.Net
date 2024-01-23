using System.Collections.Generic;

namespace Store_CleanArchitecture.Application.Services.Users.Commands.RegisterUser
{
    public class RequestRegisterUserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public List<RolesInRegisterUserDto> roles { get; set; }
    }
}
