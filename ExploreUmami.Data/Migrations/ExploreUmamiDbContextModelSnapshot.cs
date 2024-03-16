﻿// <auto-generated />
using System;
using ExploreUmami.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    [DbContext(typeof(ExploreUmamiDbContext))]
    partial class ExploreUmamiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExploreUmami.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Business", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("BusinessOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("VisitorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WebsiteURL")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessOwnerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("439e6946-75c4-4f45-9840-1bc268f98e49"),
                            Address = "123 Main Street",
                            BusinessOwnerId = new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"),
                            CategoryId = 1,
                            Description = "A place where you can eat food",
                            ImageURL = "https://getimg.ai/img/img-GzEi9e3A35BWRRAs6efuR",
                            PhoneNumber = "123-456-7890",
                            Title = "Restaurant",
                            WebsiteURL = "https://www.restaurant.com"
                        },
                        new
                        {
                            Id = new Guid("22e63a65-2d88-4090-a6c6-f51d421854fc"),
                            Address = "456 Elm Street",
                            BusinessOwnerId = new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"),
                            CategoryId = 2,
                            Description = "A place where you can drink coffee",
                            ImageURL = "https://getimg.ai/img/img-OysDjiqns60NDYgiCOidV",
                            PhoneNumber = "123-456-7890",
                            Title = "Cafe",
                            WebsiteURL = "https://www.cafe.com"
                        },
                        new
                        {
                            Id = new Guid("cff0007d-56f6-4720-83b4-770c903f783f"),
                            Address = "789 Oak Street",
                            BusinessOwnerId = new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"),
                            CategoryId = 3,
                            Description = "A place where you can drink alcohol",
                            ImageURL = "https://getimg.ai/img/img-r3saoofM9CrvQfG1foV2P",
                            PhoneNumber = "123-456-7890",
                            Title = "Bar",
                            WebsiteURL = "https://www.bar.com"
                        },
                        new
                        {
                            Id = new Guid("a61cce1f-06a5-4fa8-822c-3a67acdca9a5"),
                            Address = "1012 Pine Street",
                            BusinessOwnerId = new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"),
                            CategoryId = 4,
                            Description = "A place where you can buy bread",
                            ImageURL = "https://getimg.ai/img/img-2PqN4NLYb5UFxWb9gFMuZ",
                            PhoneNumber = "123-456-7890",
                            Title = "Bakery",
                            WebsiteURL = "https://www.bakery.com"
                        },
                        new
                        {
                            Id = new Guid("45ab573e-e84e-4466-8c2d-cdc707430134"),
                            Address = "1314 Cedar Street",
                            BusinessOwnerId = new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"),
                            CategoryId = 5,
                            Description = "A place where you can eat food quickly",
                            ImageURL = "https://getimg.ai/img/img-PvULGwtcwlWZ5694nHPFC",
                            PhoneNumber = "123-456-7890",
                            Title = "Fast Food",
                            WebsiteURL = "https://www.fastfood.com"
                        },
                        new
                        {
                            Id = new Guid("bea1f022-d9bf-4a94-b219-0104ff363116"),
                            Address = "1516 Maple Street",
                            BusinessOwnerId = new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"),
                            CategoryId = 6,
                            Description = "A place where you can eat food on the go",
                            ImageURL = "https://getimg.ai/img/img-iwKO3ZYj0tUW9NZ4RbF3Q",
                            PhoneNumber = "123-456-7890",
                            Title = "Food Truck",
                            WebsiteURL = "https://www.foodtruck.com"
                        },
                        new
                        {
                            Id = new Guid("8b30853f-49a8-41a7-b995-50e14657430b"),
                            Address = "1718 Walnut Street",
                            BusinessOwnerId = new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"),
                            CategoryId = 7,
                            Description = "A place where you can eat dessert",
                            ImageURL = "https://getimg.ai/img/img-tqk28rgRktCvKB33e4FmM",
                            PhoneNumber = "123-456-7890",
                            Title = "Dessert Shop",
                            WebsiteURL = "https://www.dessertshop.com"
                        },
                        new
                        {
                            Id = new Guid("5d7f3f6c-0c61-42fa-a554-81be03917c4e"),
                            Address = "1920 Cherry Street",
                            BusinessOwnerId = new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"),
                            CategoryId = 8,
                            Description = "A place where you can buy food",
                            ImageURL = "https://getimg.ai/img/img-jmK84Ff5DOP68jbtpJJNb",
                            PhoneNumber = "123-456-7890",
                            Title = "Grocery Store",
                            WebsiteURL = "https://www.grocerystore.com"
                        });
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.BusinessOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BusinessOwners");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid?>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Restaurant"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cafe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bar"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bakery"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fast Food"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Food Truck"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Dessert Shop"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Grocery Store"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Market"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Food Stand"
                        });
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("BusinessId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("ReviewerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Business", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.BusinessOwner", "BusinessOwner")
                        .WithMany("OwnedBusinesses")
                        .HasForeignKey("BusinessOwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExploreUmami.Data.Models.Category", "Category")
                        .WithMany("Businesses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", "Visitor")
                        .WithMany("VisitedBusinesses")
                        .HasForeignKey("VisitorId");

                    b.Navigation("BusinessOwner");

                    b.Navigation("Category");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.BusinessOwner", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Category", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.Business", null)
                        .WithMany("Categories")
                        .HasForeignKey("BusinessId");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Review", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.Business", "Business")
                        .WithMany("Reviews")
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");

                    b.Navigation("Business");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("VisitedBusinesses");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Business", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.BusinessOwner", b =>
                {
                    b.Navigation("OwnedBusinesses");
                });

            modelBuilder.Entity("ExploreUmami.Data.Models.Category", b =>
                {
                    b.Navigation("Businesses");
                });
#pragma warning restore 612, 618
        }
    }
}
