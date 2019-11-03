using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure (EntityTypeBuilder<ItemOrder> builder)
        {
            builder.HasKey(i => i.Id);

            builder.
                Property(i => i.ProductId).
                IsRequired();

            builder.
              Property(i => i.Amount).
              IsRequired();

        }
    }
}
