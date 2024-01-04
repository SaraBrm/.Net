using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=. ; Initial Catalog=EfTest ; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Global query filters
            modelBuilder.Entity<User>()
                .HasQueryFilter(p => !p.IsRemoved);

        }
    }
}
