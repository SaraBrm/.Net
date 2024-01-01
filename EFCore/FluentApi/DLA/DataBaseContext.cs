using DLA.Config;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DLA
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.; Initial Catalog=EfTest ; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("shoping");

            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();

            Config(modelBuilder);
        }

        private static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
        }
    }
}
