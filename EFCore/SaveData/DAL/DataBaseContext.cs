using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DataBaseContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=. ; Initial Catalog=Ef_SaveData; integrated security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>
               ()
               .Property(p => p.Timestamp)
               .IsRowVersion();
        }



    }
}
