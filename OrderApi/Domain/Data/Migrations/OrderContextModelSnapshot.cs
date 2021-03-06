﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderApi.Domain.Data;

namespace OrderApi.Domain.Data.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OrderApi.Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasMaxLength(100);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnName("OrderDate");

                    b.Property<int>("OrderStatus")
                        .HasColumnName("OrderStatus");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnName("OrderTotal");

                    b.Property<string>("PaymentAuthCode")
                        .HasColumnName("PaymentAuthCode")
                        .HasMaxLength(100);

                    b.Property<string>("UserName")
                        .HasColumnName("UserName")
                        .HasMaxLength(100);

                    b.HasKey("OrderId");

                    b.ToTable("ORDER");
                });

            modelBuilder.Entity("OrderApi.Domain.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderId");

                    b.Property<string>("PictureUrl")
                        .HasColumnName("PictureUrl")
                        .HasMaxLength(100);

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductId");

                    b.Property<string>("ProductName")
                        .HasColumnName("ProductName")
                        .HasMaxLength(100);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnName("UnitPrice");

                    b.Property<int>("Units")
                        .HasColumnName("Units");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("ORDER_ITEM");
                });

            modelBuilder.Entity("OrderApi.Domain.Models.OrderItem", b =>
                {
                    b.HasOne("OrderApi.Domain.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
