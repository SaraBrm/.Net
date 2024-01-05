using Application;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DbSet<User> Users { get; set; }

        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=. ; Initial Catalog=Ef_Clean; integrated security=true");
        }
    }
}
