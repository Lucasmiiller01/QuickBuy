﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Migrations
{
    [DbContext(typeof(QuickBuyContext))]
    partial class QuickBuyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuy.Domain.Entities.ItemOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int?>("OrderId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("ItensOrders");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<DateTime>("ExpectedDeliveryDate");

                    b.Property<int>("FormPaymentId");

                    b.Property<string>("FullAdress")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NumberAddress");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FormPaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuickBuy.Domain.ObjectValue.FormPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FormPayment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Forma de pagamento Boleto",
                            Name = "Billet"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Forma de pagamento CreditCard",
                            Name = "CreditCard"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Forma de pagamento Deposit",
                            Name = "Deposit"
                        });
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.ItemOrder", b =>
                {
                    b.HasOne("QuickBuy.Domain.Entities.Order")
                        .WithMany("ItensOrders")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("QuickBuy.Domain.Entities.Order", b =>
                {
                    b.HasOne("QuickBuy.Domain.ObjectValue.FormPayment", "FormPayment")
                        .WithMany()
                        .HasForeignKey("FormPaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuickBuy.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
