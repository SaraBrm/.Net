using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DLA.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tbl_Product", schema:"prod");
            builder.Property(p=>p.Name).IsRequired();
            builder.Ignore(p => p.Temp);
            builder.Property(p => p.Id).HasColumnName("Product_Id");
            builder.Property(p => p.Name).HasColumnType("varchar(150)");
            builder.Property(p => p.Description).HasMaxLength(500);


        }
    }
}
