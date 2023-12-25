using MVC.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Models.Repositories
{
    public class AccountRepository
    {
        private readonly List<Account> _account = new List<Account>();

        public AccountRepository()
        {
            _account.Add(new Account
            {
                Age = 25,
                Email = "nbhr@gmail.com",
                Id = 1,
                Mobile = "09112000000",
                Name = "بهار"
            });

            _account.Add(new Account
            {
                Age = 30,
                Email = "az@gmail.com",
                Id = 2,
                Mobile = "09375000000",
                Name = "آذر"
            });
        }
        public List<Account> Get()
        {
            return _account;
        }
        public Account Find()
        {
            return _account.FirstOrDefault();
        }
    }
}
