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

                    b.Property<int>("PrefectureId")
                        .HasColumnType("int");

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

                    b.HasIndex("PrefectureId");

                    b.HasIndex("VisitorId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("464473d3-5e31-4c0d-a476-ddb37f2edf07"),
                            Address = "123 Main Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 1,
                            Description = "A place where you can eat food",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 1,
                            Title = "Restaurant",
                            WebsiteURL = "https://www.restaurant.com"
                        },
                        new
                        {
                            Id = new Guid("0d496894-8eda-47d8-804d-4ea5995736e5"),
                            Address = "456 Elm Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 2,
                            Description = "A place where you can drink coffee",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 2,
                            Title = "Cafe",
                            WebsiteURL = "https://www.cafe.com"
                        },
                        new
                        {
                            Id = new Guid("9bce1175-0b12-4c75-9851-17d1a69f2f10"),
                            Address = "789 Oak Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 3,
                            Description = "A place where you can drink alcohol",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 3,
                            Title = "Bar",
                            WebsiteURL = "https://www.bar.com"
                        },
                        new
                        {
                            Id = new Guid("922a6a8d-3be2-442b-9af6-b07b41af536d"),
                            Address = "1012 Pine Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 4,
                            Description = "A place where you can buy bread",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 4,
                            Title = "Bakery",
                            WebsiteURL = "https://www.bakery.com"
                        },
                        new
                        {
                            Id = new Guid("1fbdb890-0e0b-4f0e-8db5-4d900fdbbbaf"),
                            Address = "1314 Cedar Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 5,
                            Description = "A place where you can eat food quickly",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 5,
                            Title = "Fast Food",
                            WebsiteURL = "https://www.fastfood.com"
                        },
                        new
                        {
                            Id = new Guid("bf97e3c5-5e74-4292-a0da-b64200350522"),
                            Address = "1516 Maple Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 6,
                            Description = "A place where you can eat food on the go",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 6,
                            Title = "Food Truck",
                            WebsiteURL = "https://www.foodtruck.com"
                        },
                        new
                        {
                            Id = new Guid("f5417133-5ed7-4847-87d1-837b3473be55"),
                            Address = "1718 Walnut Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 7,
                            Description = "A place where you can eat dessert",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 1,
                            Title = "Dessert Shop",
                            WebsiteURL = "https://www.dessertshop.com"
                        },
                        new
                        {
                            Id = new Guid("8382f044-01c3-4330-a07d-d2c7d540ff68"),
                            Address = "1920 Cherry Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 8,
                            Description = "A place where you can buy food",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "123-456-7890",
                            PrefectureId = 1,
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

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

            modelBuilder.Entity("ExploreUmami.Data.Models.Prefecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Prefectures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hokkaido"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aomori"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Iwate"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Miyagi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Akita"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Yamagata"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Fukushima"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ibaraki"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Tochigi"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Gunma"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Saitama"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Chiba"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Tokyo"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Kanagawa"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Niigata"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Toyama"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Ishikawa"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Fukui"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Yamanashi"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Nagano"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Gifu"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Shizuoka"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Aichi"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Mie"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Shiga"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Kyoto"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Osaka"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Hyogo"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Nara"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Wakayama"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Tottori"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Shimane"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Okayama"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Hiroshima"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Yamaguchi"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Tokushima"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Kagawa"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Ehime"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Kochi"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Fukuoka"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Saga"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Nagasaki"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Kumamoto"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Oita"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Miyazaki"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Kagoshima"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Okinawa"
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

                    b.HasOne("ExploreUmami.Data.Models.Prefecture", "Prefecture")
                        .WithMany("Businesses")
                        .HasForeignKey("PrefectureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", "Visitor")
                        .WithMany("VisitedBusinesses")
                        .HasForeignKey("VisitorId");

                    b.Navigation("BusinessOwner");

                    b.Navigation("Category");

                    b.Navigation("Prefecture");

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

            modelBuilder.Entity("ExploreUmami.Data.Models.Prefecture", b =>
                {
                    b.Navigation("Businesses");
                });
#pragma warning restore 612, 618
        }
    }
}
