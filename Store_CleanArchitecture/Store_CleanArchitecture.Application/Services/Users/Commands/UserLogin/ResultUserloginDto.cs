﻿namespace Store_CleanArchitecture.Application.Services.Users.Commands.UserLogin
{
    public class ResultUserloginDto
    {
        public long UserId { get; set; }
        public string Roles { get; set; }
        public string Name { get; set; }
    }
}
