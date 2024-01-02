
using Entities.GeneratedValues;
using Entities.Inheritance;
using Entities.Sequence;
using Microsoft.EntityFrameworkCore;

namespace DLA
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> People { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1ABI49L; Initial Catalog=EfTest ; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //GeneratedValues******************
            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .UseIdentityColumn(1000, 10);

            modelBuilder.Entity<User>()
                .Property(p => p.Score)
                .HasDefaultValue(100);

            modelBuilder.Entity<User>()
                .Property(p => p.InsertDate)
                .HasDefaultValueSql("getdate()");

            //S-2024-02-1
            modelBuilder.Entity<Order>()
                .Property(p => p.OrderNumber)
                .HasComputedColumnSql
                ("'S-' + CAST(Year(getdate()) AS varchar) + '-' + CAST(MONTH(getdate()) AS varchar) + '-' + CAST([Id] AS varchar)");

            modelBuilder.Entity<User>()
               .Property(p => p.FullName)
               .HasComputedColumnSql("[FirstName] + '-' + [LastName]");


            //Inheritance******************
            modelBuilder.Entity<Person>().ToTable("Person");

            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("Person_type")
                .HasValue<Student>("S")
                .HasValue<Teacher>("T");


            //Sequence******************
            modelBuilder.HasSequence<int>("ProductNumber", schema: "common")
                .StartsAt(100)
                .IncrementsBy(1);

            modelBuilder.Entity<Product>()
                .Property(p => p.ProductNumber)
                .HasDefaultValueSql("SELECT Next Value For common.ProductNumber");
        }

    }
}
