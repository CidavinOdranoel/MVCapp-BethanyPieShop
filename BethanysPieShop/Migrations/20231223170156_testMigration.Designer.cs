﻿// <auto-generated />
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BethanysPieShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231223170156_testMigration")]
    partial class testMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "pies",
                            CategoryName = "Fruit pies"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "cakes",
                            CategoryName = "Cheese cakes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "pies",
                            CategoryName = "Seasonal pies"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PieId"));

                    b.Property<string>("AllergyInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumnailUrl = "https://icons.iconarchive.com/icons/treetog/junior/128/folder-blue-pictures-icon.png",
                            ImageUrl = "https://icons.iconarchive.com/icons/treetog/junior/128/folder-blue-pictures-icon.png",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Long Apple pie!!!",
                            Name = "Apple pie",
                            Price = 13,
                            ShortDescription = "Apple pie!"
                        },
                        new
                        {
                            PieId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumnailUrl = "https://icons.iconarchive.com/icons/babasse/old-school/128/dossier-ardoise-images-icon.png",
                            ImageUrl = "https://icons.iconarchive.com/icons/babasse/old-school/128/dossier-ardoise-images-icon.png",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "Long Cheese cake!!!",
                            Name = "Cheese cake",
                            Price = 19,
                            ShortDescription = "Cheese cake!"
                        },
                        new
                        {
                            PieId = 3,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumnailUrl = "https://icons.iconarchive.com/icons/gartoon-team/gartoon-mimetype/128/image-x-lws-icon.png",
                            ImageUrl = "https://icons.iconarchive.com/icons/gartoon-team/gartoon-mimetype/128/image-x-lws-icon.png",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "Long Strawberry pie!!!",
                            Name = "Strawberry pie",
                            Price = 14,
                            ShortDescription = "Strawberry pie!"
                        },
                        new
                        {
                            PieId = 4,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumnailUrl = "https://icons.iconarchive.com/icons/hopstarter/scrap/128/Picture-PNG-icon.png",
                            ImageUrl = "https://icons.iconarchive.com/icons/hopstarter/scrap/128/Picture-PNG-icon.png",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Long Seasonal pie!!!",
                            Name = "Seasonal pie",
                            Price = 14,
                            ShortDescription = "Seasonal pie!"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartItemId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("PieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("PieId");

                    b.ToTable("ShoppingCardItems");
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BethanysPieShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pie");
                });

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Navigation("Pies");
                });
#pragma warning restore 612, 618
        }
    }
}