using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public interface IGetUserListService
    {
        List<UserDto> Execute();
    }
    public class GetUserListService : IGetUserListService
    {
        private readonly IDataBaseContext _context;

        public GetUserListService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<UserDto> Execute()
        {
            var users = _context.Users.Select(p =>
               new UserDto
               {
                   Id = p.Id,
                   Username = p.Username
               }).ToList();

            return users;
        }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
