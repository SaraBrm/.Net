using Store_CleanArchitecture.Application.Interfaces.Contexts;
using Store_CleanArchitecture.Common.Dto;
using Store_CleanArchitecture.Domain.Entities.Users;
using System;
using System.Collections.Generic;

namespace Store_CleanArchitecture.Application.Services.Users.Commands.RegisterUser
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IDataBaseContext _context;

        public RegisterUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ResultRegisterUserDto> Execute(RequestRegisterUserDto request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.Email))
                {
                    return new ResultDto<ResultRegisterUserDto>()
                    {
                        Data = new ResultRegisterUserDto()
                        {
                            UserId = 0,
                        },
                        IsSuccess = false,
                        Message = "پست الکترونیک را وارد نمایید"
                    };
                }

                if (string.IsNullOrWhiteSpace(request.FullName))
                {
                    return new ResultDto<ResultRegisterUserDto>()
                    {
                        Data = new ResultRegisterUserDto()
                        {
                            UserId = 0,
                        },
                        IsSuccess = false,
                        Message = "نام را وارد نمایید"
                    };
                }
                //if (string.IsNullOrWhiteSpace(request.Password))
                //{
                //    return new ResultDto<ResultRegisterUserDto>()
                //    {
                //        Data = new ResultRegisterUserDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "رمز عبور را وارد نمایید"
                //    };
                //}
                //if (request.Password != request.RePasword)
                //{
                //    return new ResultDto<ResultRegisterUserDto>()
                //    {
                //        Data = new ResultRegisterUserDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "رمز عبور و تکرار آن برابر نیست"
                //    };
                //}

                User user = new User()
                {
                    Email = request.Email,
                    FullName = request.FullName,
                    //Password = HashPassword.Execute(request.Password),
                };

                List<UserInRole> userInRoles = new List<UserInRole>();

                foreach (var item in request.roles)
                {
                    var roles = _context.Roles.Find(item.Id);
                    userInRoles.Add(new UserInRole
                    {
                        Role = roles,
                        RoleId = roles.Id,
                        User = user,
                        UserId = user.Id,
                    });
                }
                user.UserInRoles = userInRoles;

                _context.Users.Add(user);

                _context.SaveChanges();

                return new ResultDto<ResultRegisterUserDto>()
                {
                    Data = new ResultRegisterUserDto()
                    {
                        UserId = user.Id,

                    },
                    IsSuccess = true,
                    Message = "ثبت نام کاربر انجام شد",
                };
            }
            catch (Exception)
            {
                return new ResultDto<ResultRegisterUserDto>()
                {
                    Data = new ResultRegisterUserDto()
                    {
                        UserId = 0,
                    },
                    IsSuccess = false,
                    Message = "ثبت نام انجام نشد !"
                };
            }
        }
    }
}
