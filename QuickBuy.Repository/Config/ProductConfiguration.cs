using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure (EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);


            // Builder utiliza o padrão Fluent

            builder
              .Property(p => p.Name)
              .IsRequired()
              .HasMaxLength(50);


            builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
              .Property(p => p.Price)
              .IsRequired();



        }
    }
}
