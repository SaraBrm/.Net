using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLA.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.UserID).HasName("Id");
            //builder.HasKey(p => new { p.KeyId ,p.KeyId2});

            builder.HasAlternateKey(p => p.NationalCode).HasName("AlternateKey_NationalCode");
            //builder.HasAlternateKey(p => new { p.NationalCode ,p.KeyId2});

            builder.Property(p => p.UserID).HasColumnName("Id");

            //builder.HasIndex(p => new { p.PhoneNumber, p.NationalCode });
            builder.HasIndex(p => p.PhoneNumber).IsUnique();



        }
    }
}
