using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<UserÇonfiguration>
    {
        public void Configure (EntityTypeBuilder<UserÇonfiguration> builder)
        {
            builder.HasKey(u => u.Id);

            // Builder utiliza o padrão Fluent

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.LastName)
                .HasMaxLength(50);

            builder
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarchar");

            builder
               .Property(u => u.Password)
               .IsRequired()
               .HasMaxLength(400);

           /* builder
             .Property(u => u.Orders)
             .IsRequired()
             .HasMaxLength(50); */

        }
    }
}
