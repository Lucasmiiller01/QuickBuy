using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure (EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);


            builder
              .Property(o => o.CEP)
              .IsRequired()
              .HasMaxLength(10);

            builder
              .Property(o => o.ExpectedDeliveryDate)
              .IsRequired();

            builder
             .Property(o => o.DeliveryDate)
             .IsRequired();

            builder
             .Property(o => o.City)
            .IsRequired()
            .HasMaxLength(100);

            builder
                .Property(o => o.State)
                .IsRequired()
                .HasMaxLength(100);

             builder
                .Property(o => o.FullAdress)
                .IsRequired()
                .HasMaxLength(100);


            builder
                .Property(o => o.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
              .HasOne(o => o.User);


        }
    }
}
