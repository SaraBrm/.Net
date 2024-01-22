using Microsoft.EntityFrameworkCore;
using Store_CleanArchitecture.Application.Interfaces.Contexts;
using Store_CleanArchitecture.Domain.Entities.Users;

namespace Store_CleanArchitecture.Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }


    }
}
