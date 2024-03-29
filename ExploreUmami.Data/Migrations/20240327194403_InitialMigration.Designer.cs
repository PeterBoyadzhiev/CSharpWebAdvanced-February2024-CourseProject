﻿// <auto-generated />
using System;
using ExploreUmami.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    [DbContext(typeof(ExploreUmamiDbContext))]
    [Migration("20240327194403_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "84e5e5de-45d4-4d22-a3c4-1efdef094d3a",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELhxZRSa9nMNTjKuwOFFV0UmYmKZwdw1yhYYYDAfMYie4XMmt6MdMiGO4NWhKyew/A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49E3F745CBBF9193D54BD99DBD098F45",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4d085571-f597-441a-a398-593926e298de",
                            Email = "businessowner@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BUSINESSOWNER@GMAIL.COM",
                            NormalizedUserName = "BUSINESSOWNER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGxBoNK52+spDyVp9GldfH8Z9u8Gb23gbnC/752215SuO0g7G9NLBJw+ZKetnkoTgw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49E3F745CBBF9193D54BD99DBD098F45",
                            TwoFactorEnabled = false,
                            UserName = "businessowner@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "604aa6a9-b3ac-410d-a8cc-9e7c9e88897d",
                            Email = "reviewer@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "REVIEWER@GMAIL.COM",
                            NormalizedUserName = "REVIEWER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEH9K973I4u7IcY4Qfkjr4lNWBJvwxx4aAz5SwWTnTfnAdJTDcDYliw8YKrkpVJbBg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "49E3F745CBBF9193D54BD99DBD098F45",
                            TwoFactorEnabled = false,
                            UserName = "reviewer@gmail.com"
                        });
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
                            Id = new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"),
                            Address = "123 Main Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 1,
                            Description = "A place where you can eat food",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 1,
                            Title = "Restaurant",
                            WebsiteURL = "https://www.restaurant.com"
                        },
                        new
                        {
                            Id = new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                            Address = "456 Elm Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 2,
                            Description = "A place where you can drink coffee",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 2,
                            Title = "Cafe",
                            WebsiteURL = "https://www.cafe.com"
                        },
                        new
                        {
                            Id = new Guid("159fd9e4-1414-4d03-bd32-385cb7c59f90"),
                            Address = "789 Oak Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 3,
                            Description = "A place where you can drink alcohol",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 3,
                            Title = "Bar",
                            WebsiteURL = "https://www.bar.com"
                        },
                        new
                        {
                            Id = new Guid("73176956-6a9b-4f7c-9421-1dd8bc6633fa"),
                            Address = "1012 Pine Street",
                            BusinessOwnerId = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            CategoryId = 4,
                            Description = "A place where you can buy bread",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 4,
                            Title = "Bakery",
                            WebsiteURL = "https://www.bakery.com"
                        },
                        new
                        {
                            Id = new Guid("51834097-9c17-44cb-acc4-c4dacd6170a4"),
                            Address = "1314 Cedar Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 5,
                            Description = "A place where you can eat food quickly",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 5,
                            Title = "Fast Food",
                            WebsiteURL = "https://www.fastfood.com"
                        },
                        new
                        {
                            Id = new Guid("9310fc7e-d090-48b6-be15-89e4449463f7"),
                            Address = "1516 Maple Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 6,
                            Description = "A place where you can eat food on the go",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 6,
                            Title = "Food Truck",
                            WebsiteURL = "https://www.foodtruck.com"
                        },
                        new
                        {
                            Id = new Guid("40292fea-7748-4fe3-9944-987ef2410eda"),
                            Address = "1718 Walnut Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 7,
                            Description = "A place where you can eat dessert",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
                            PrefectureId = 1,
                            Title = "Dessert Shop",
                            WebsiteURL = "https://www.dessertshop.com"
                        },
                        new
                        {
                            Id = new Guid("8a172b65-2a13-41f7-8e97-94b8fdc2d854"),
                            Address = "1920 Cherry Street",
                            BusinessOwnerId = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            CategoryId = 8,
                            Description = "A place where you can buy food",
                            ImageURL = "https://dummyimage.com/400x200",
                            PhoneNumber = "12-3456-7890",
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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NameOfBusiness")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BusinessOwners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                            FirstName = "John",
                            LastName = "Doe",
                            NameOfBusiness = "John's Restaurant",
                            PhoneNumber = "12-3456-7890",
                            UserId = new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795")
                        },
                        new
                        {
                            Id = new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                            FirstName = "Jane",
                            LastName = "Doe",
                            NameOfBusiness = "Jane's Cafe",
                            PhoneNumber = "12-3456-7890",
                            UserId = new Guid("1ae80037-f648-442e-a309-4b94a3d1315c")
                        });
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

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<Guid?>("ReviewerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReviewerId");

                    b.HasIndex("BusinessId", "ReviewerId")
                        .IsUnique()
                        .HasFilter("[ReviewerId] IS NOT NULL");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            BusinessId = new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"),
                            Content = "Great food!",
                            Rating = 5.0,
                            ReviewerId = new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83")
                        },
                        new
                        {
                            Id = -2,
                            BusinessId = new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                            Content = "Great coffee!",
                            Rating = 5.0,
                            ReviewerId = new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83")
                        });
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExploreUmami.Data.Models.ApplicationUser", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Restrict);

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
                    b.Navigation("Reviews");

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
