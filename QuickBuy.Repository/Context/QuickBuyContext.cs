using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ObjectValue;
using QuickBuy.Repository.Config;

namespace QuickBuy.Repository.Context
{
    public class QuickBuyContext : DbContext
    {
        public DbSet<UserÇonfiguration> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ItemOrder> ItensOrders { get; set; }
        public DbSet<FormPayment> FormPayment { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Classes de mapeamento

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration()); 
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
