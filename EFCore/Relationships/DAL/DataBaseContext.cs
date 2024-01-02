using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DLA
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> productTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.; Initial Catalog=EfTest ; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne(p=>p.Category);

            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne();

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(p => p.Products)
            //    .HasForeignKey(p => p.FK_CategoryId)
            //    .HasConstraintName("FK_C_P");

            //modelBuilder.Entity<Product>()
            //    .HasOne<Category>()
            //    .WithMany()
            //    .HasForeignKey(p => p.FK_CategoryId)
            //    .IsRequired(false);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(p => p.Products)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.Category)
            //    .WithMany(p => p.Products)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.ProductImage)
            //    .WithOne(p => p.Product)
            //    .HasForeignKey<ProductImage>(p => p.FK_ProductId);

            //modelBuilder.Entity<ProductTag>()
            //    .HasKey(p=> new { p.TagId,p.ProductId });

            modelBuilder.Entity<Product>()
                .Property<DateTime>("InsertDate");

        }
         
    } 
}
