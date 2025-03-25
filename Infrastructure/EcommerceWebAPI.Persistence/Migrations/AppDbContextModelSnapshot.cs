﻿// <auto-generated />
using System;
using EcommerceWebAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceWebAPI.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(2230),
                            IsDeleted = false,
                            Name = "Outdoors"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(2282),
                            IsDeleted = false,
                            Name = "Grocery & Movies"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(2293),
                            IsDeleted = true,
                            Name = "Garden"
                        });
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(6165),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(6168),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(6169),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 944, DateTimeKind.Local).AddTicks(6171),
                            IsDeleted = false,
                            Name = "Erkek",
                            ParentId = 2,
                            Priority = 1
                        });
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 946, DateTimeKind.Local).AddTicks(3017),
                            Description = "Kapının voluptas cezbelendi uzattı et.",
                            IsDeleted = false,
                            Title = "Kulu."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 946, DateTimeKind.Local).AddTicks(3060),
                            Description = "Consequatur adipisci exercitationem için quis.",
                            IsDeleted = true,
                            Title = "Kutusu umut."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 946, DateTimeKind.Local).AddTicks(3089),
                            Description = "Et ışık bilgiyasayarı sıradanlıktan consequatur.",
                            IsDeleted = false,
                            Title = "Odit."
                        });
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 947, DateTimeKind.Local).AddTicks(9382),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Discount = 2.550787003761220m,
                            IsDeleted = false,
                            Price = 218.65m,
                            Title = "Awesome Plastic Gloves"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2025, 3, 25, 11, 35, 32, 947, DateTimeKind.Local).AddTicks(9412),
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Discount = 4.64021732008390m,
                            IsDeleted = false,
                            Price = 770.39m,
                            Title = "Incredible Steel Bacon"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("EcommerceWebAPI.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceWebAPI.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Detail", b =>
                {
                    b.HasOne("EcommerceWebAPI.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Product", b =>
                {
                    b.HasOne("EcommerceWebAPI.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("EcommerceWebAPI.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
