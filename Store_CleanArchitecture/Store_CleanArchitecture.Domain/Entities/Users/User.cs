using Store_CleanArchitecture.Domain.Entities.Commons;
using System.Collections.Generic;

namespace Store_CleanArchitecture.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public ICollection<UserInRole> UserInRoles { get; set; }
    }
}
