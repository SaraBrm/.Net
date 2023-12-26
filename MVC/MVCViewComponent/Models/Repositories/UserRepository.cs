using MVCViewComponent.Models.Entities;
using MVCViewComponent.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MVCViewComponent.Models.Repositories
{
    public class UserRepository
    {
        private readonly List<Users> _users;

        public UserRepository()
        {
            _users = new List<Users>();

            //add fake user


            _users.Add(new Users
            {
                Address = "رشت",
                Email = "sam@gmail.com",
                Id = 1,
                Job = "مدیر فنی",
                LastName = "حسنی",
                Name = "سامین",
                PhoneNumber = "09110000000",
            });
            _users.Add(new Users
            {
                Address = "فومن",
                Email = "af@gmail.com",
                Id = 2,
                Job = "مدیر مارکتینگ",
                LastName = "فردی",
                Name = "آذر",
                PhoneNumber = "09370000000",
            });

            _users.Add(new Users
            {
                Address = "لاهیجان",
                Email = "pf@gmail.com",
                Id = 3,
                Job = "برنامه نویس وب",
                LastName = "فرازمند",
                Name = "پیمان",
                PhoneNumber = "09120000001",
            });

        }


        public List<UserListViewModel> GetUserList()
        {
            List<UserListViewModel> users = _users.Select(p => new UserListViewModel
            {
                Id = p.Id,
                Email = p.Email,
            }).ToList();
            return users;
        }

        public UserDetailViewModel Find(long Id)
        {
            var user = _users.Where(p => p.Id == Id).FirstOrDefault();
            return new UserDetailViewModel()
            {
                Address = user.Address,
                Email = user.Email,
                Id = user.Id,
                Job = user.Job,
                LastName = user.LastName,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
            };
        }
    }
}
