using Entities.BackingFields;
using Entities.GeneratedValues;
using Entities.Inheritance;
using Entities.Sequence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

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

        public DbSet<Blog> Blogs { get; set; }



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


            //Backing Fields******************
            modelBuilder.Entity<Blog>()
                .Property(p => p.Url)
                .HasField("_Url");


            //Value Conversions******************
            modelBuilder.Entity<Order>()
                .Property(p => p.OrderStatus)
                .HasConversion(p => p.ToString(), p => (OrderStatus)Enum.Parse(typeof(OrderStatus), p));

            //Microsoft.EntityFrameworkCore.Storage.ValueConversion
            var boolToString = new BoolToStringConverter("No", "Yes");
            modelBuilder.Entity<Order>()
                .Property(p => p.Done)
                .HasConversion(boolToString);

            modelBuilder.Entity<User>()
                .Property(p => p.Email)
                .HasConversion(p => Base64Encode(p), p => Base64Decode(p));


            //DataSeeding******************
            modelBuilder.Entity<User>()
                .HasData(new User
                {
                    Id = 1,
                    Email = "sa@gmail.com"
                });

            modelBuilder.Entity<Order>()
                .HasData(new Order
                {
                    Id = 1,
                    OrderStatus = OrderStatus.Processing,
                    UserId = 1
                });

            modelBuilder.Entity<Order>()
                .HasData(new Order
                {
                    Id = 2,
                    OrderStatus = OrderStatus.Sent,
                    UserId = 1
                });


            //Owned Entity Types******************
            modelBuilder.Entity<User>()
                .OwnsOne(p => p.Home);

            modelBuilder.Entity<User>()
                .OwnsOne(p => p.Workplace);


        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodeData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodeData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
