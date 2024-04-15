﻿using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "John"),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Doe"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prefectures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefectures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessOwners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NameOfBusiness = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessOwners_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PrefectureId = table.Column<int>(type: "int", nullable: false),
                    BusinessOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Businesses_AspNetUsers_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Businesses_BusinessOwners_BusinessOwnerId",
                        column: x => x.BusinessOwnerId,
                        principalTable: "BusinessOwners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Businesses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Businesses_Prefectures_PrefectureId",
                        column: x => x.PrefectureId,
                        principalTable: "Prefectures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Pending")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    UserLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserVisits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserVisits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserVisits_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserVisits_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"), 0, "015ef6f8-895f-437e-bd81-919347045668", "businessowner@gmail.com", false, false, null, "BUSINESSOWNER@GMAIL.COM", "BUSINESSOWNER@GMAIL.COM", "AQAAAAEAACcQAAAAEKe0obrnGnI17OBfb5w6j4l/eUazABQqfq/eSxbSL/5DK/yVuUfTsu1LmK4SV5O1GA==", null, false, "8DE9BFF76769660A48823D891400A8E1", false, "businessowner@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"), 0, "030f2edc-c525-4abf-87bf-8e59968e68fd", "reviewer2@gmail.com", false, "Janette", "Dane", false, null, "REVIEWER2@GMAIL.COM", "REVIEWER2@GMAIL.COM", "AQAAAAEAACcQAAAAEFsx1jfGt5ydTYlXRZyHPouXYh+I4yJvBNdfygHZ3wbUcBWLJ6ThyRWh8Xe8Dq/VRQ==", null, false, "8DE9BFF76769660A48823D891400A8E1", false, "reviewer2@gmail.com" },
                    { new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"), 0, "7efd044d-1c61-4e5a-aebe-5e268fa6ffae", "reviewer@gmail.com", false, "Jovani", "Dawson", false, null, "REVIEWER@GMAIL.COM", "REVIEWER@GMAIL.COM", "AQAAAAEAACcQAAAAEEy1hzbzHrEP1TRUs9+mYAGuYuVybLdmnIFVea5FQn7D4+CRC5cjLleK7V0OnT/8Rg==", null, false, "8DE9BFF76769660A48823D891400A8E1", false, "reviewer@gmail.com" },
                    { new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"), 0, "ba04e225-796e-4a9b-9558-ce0e87b7db06", "businessowner2@gmail.com", false, "Jane", "Doe", false, null, "BUSINESSOWNER2@GMAIL.COM", "BUSINESSOWNER2@GMAIL.COM", "AQAAAAEAACcQAAAAEI3hnXfNaIYXHFweQ9ZdzfWQhdSiRdq6CmOANa2e76Tz6Lm94SvGmsoKTK1O2E74dA==", null, false, "8DE9BFF76769660A48823D891400A8E1", false, "businessowner2@gmail.com" },
                    { new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"), 0, "111c8203-1315-421e-a34f-97903f9f78b8", "admin@gmail.com", false, "Admin", "Adminson", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGAYbhLrJ2/SZBny3sLeES0x00DrIuFClOSOG40jl+nNbMdzZIT72TCOagR+d0eV3A==", null, false, "8DE9BFF76769660A48823D891400A8E1", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Restaurant" },
                    { 2, "Cafe" },
                    { 3, "Bar" },
                    { 4, "Bakery" },
                    { 5, "Fast Food" },
                    { 6, "Food Truck" },
                    { 7, "Dessert Shop" },
                    { 8, "Grocery Store" },
                    { 9, "Market" },
                    { 10, "Food Stand" }
                });

            migrationBuilder.InsertData(
                table: "Prefectures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hokkaido" },
                    { 2, "Aomori" },
                    { 3, "Iwate" },
                    { 4, "Miyagi" },
                    { 5, "Akita" },
                    { 6, "Yamagata" },
                    { 7, "Fukushima" },
                    { 8, "Ibaraki" },
                    { 9, "Tochigi" },
                    { 10, "Gunma" },
                    { 11, "Saitama" },
                    { 12, "Chiba" },
                    { 13, "Tokyo" },
                    { 14, "Kanagawa" },
                    { 15, "Niigata" },
                    { 16, "Toyama" },
                    { 17, "Ishikawa" },
                    { 18, "Fukui" },
                    { 19, "Yamanashi" },
                    { 20, "Nagano" },
                    { 21, "Gifu" },
                    { 22, "Shizuoka" },
                    { 23, "Aichi" },
                    { 24, "Mie" },
                    { 25, "Shiga" },
                    { 26, "Kyoto" },
                    { 27, "Osaka" }
                });

            migrationBuilder.InsertData(
                table: "Prefectures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 28, "Hyogo" },
                    { 29, "Nara" },
                    { 30, "Wakayama" },
                    { 31, "Tottori" },
                    { 32, "Shimane" },
                    { 33, "Okayama" },
                    { 34, "Hiroshima" },
                    { 35, "Yamaguchi" },
                    { 36, "Tokushima" },
                    { 37, "Kagawa" },
                    { 38, "Ehime" },
                    { 39, "Kochi" },
                    { 40, "Fukuoka" },
                    { 41, "Saga" },
                    { 42, "Nagasaki" },
                    { 43, "Kumamoto" },
                    { 44, "Oita" },
                    { 45, "Miyazaki" },
                    { 46, "Kagoshima" },
                    { 47, "Okinawa" }
                });

            migrationBuilder.InsertData(
                table: "BusinessOwners",
                columns: new[] { "Id", "FirstName", "LastName", "NameOfBusiness", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), "John", "Doe", "John's Restaurant", "12-3456-7890", new Guid("1ae80037-f648-442e-a309-4b94a3d1315c") });

            migrationBuilder.InsertData(
                table: "BusinessOwners",
                columns: new[] { "Id", "FirstName", "LastName", "NameOfBusiness", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), "Jane", "Doe", "Jane's Cafe", "12-3456-7890", new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795") });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("005caeaa-5262-43d7-9b2b-c30eaa46b6c8"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("4222168e-c018-418e-812f-f8d41b322522"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", true, true, "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("5f2516ab-1013-47c9-a521-1dc868780d64"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), "123 Main Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 1, "A place where you can eat food", "https://dummyimage.com/400x200", true, true, "12-3456-7890", 1, "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", true, true, "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("841ded07-9c44-4d5b-9f96-9d3c3a39a8c4"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), "456 Elm Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 2, "A place where you can drink coffee", "https://dummyimage.com/400x200", true, true, "12-3456-7890", 2, "Cafe", null, "https://www.cafe.com" },
                    { new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", true, true, "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("11154b62-2abd-404a-827e-f4e69ad94678"), new Guid("4222168e-c018-418e-812f-f8d41b322522"), "I'll be visiting with my grandma.", new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9356), "Confirmed", new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") },
                    { new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), "Please reserve a table for a family of 3 adults and 2 children", new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9344), "Completed", new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") },
                    { new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"), new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"), "I won't be able to make it, sorry!", new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9364), "Cancelled", new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") },
                    { new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), null, new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9331), "Completed", new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "UserId" },
                values: new object[] { new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"), new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"), "Reserve 4 tables, we are a big company", new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9351), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "Status", "UserId" },
                values: new object[] { new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"), new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), "Please reserve a table for 4 adults", new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9348), "Completed", new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") });

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationId", "UserId" },
                values: new object[] { new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1847"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), null, new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationId", "UserId" },
                values: new object[] { new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c84"), new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), null, new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") });

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationId", "UserId" },
                values: new object[] { new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c85"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), null, new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_BusinessOwnerId",
                table: "Businesses",
                column: "BusinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_CategoryId",
                table: "Businesses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_PrefectureId",
                table: "Businesses",
                column: "PrefectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_VisitorId",
                table: "Businesses",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessOwners_UserId",
                table: "BusinessOwners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BusinessId",
                table: "Reservations",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BusinessId_ReviewerId",
                table: "Reviews",
                columns: new[] { "BusinessId", "ReviewerId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVisits_BusinessId",
                table: "UserVisits",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVisits_ReservationId",
                table: "UserVisits",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVisits_UserId",
                table: "UserVisits",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UserVisits");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "BusinessOwners");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Prefectures");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
