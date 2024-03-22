﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
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
                    WebsiteURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Businesses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Businesses_Prefectures_PrefectureId",
                        column: x => x.PrefectureId,
                        principalTable: "Prefectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BusinessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"), 0, "309b1121-002e-422d-9115-8b54bb0b93ef", "businessowner@gmail.com", false, false, null, "BUSINESSOWNER@GMAIL.COM", "BUSINESSOWNER@GMAIL.COM", "AQAAAAEAACcQAAAAEG8cvbIwuq55S0FvLcT7e+U2tMq7dmwqbD9FbQanGUNO0FXkk17p4MxHGwkpVn8gZg==", null, false, "6C94B3E70009FE549F746E84FE82B7A4", false, "businessowner@gmail.com" },
                    { new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"), 0, "28e6eb1f-faee-42af-9d90-475d062b2583", "reviewer@gmail.com", false, false, null, "REVIEWER@GMAIL.COM", "REVIEWER@GMAIL.COM", "AQAAAAEAACcQAAAAEHaejeRdRkGCm4zQDS2FeuZ/wmDPqc928eZJBl7+t/SMxFYge6xOO5yir+q1QNs0tg==", null, false, "6C94B3E70009FE549F746E84FE82B7A4", false, "reviewer@gmail.com" },
                    { new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"), 0, "de669ae7-6236-44e1-8243-8e82accfda43", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ/01P1j7BXAwRAMolOEyVKdH1vy1Gi4T6wBhGHa+QdHqAiSno9NtOgJUD8Y6lpiwQ==", null, false, "6C94B3E70009FE549F746E84FE82B7A4", false, "admin@gmail.com" }
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
                    { 27, "Osaka" },
                    { 28, "Hyogo" },
                    { 29, "Nara" }
                });

            migrationBuilder.InsertData(
                table: "Prefectures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
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
                values: new object[] { new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), "John", "Doe", "John's Restaurant", "123-456-7890", new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795") });

            migrationBuilder.InsertData(
                table: "BusinessOwners",
                columns: new[] { "Id", "FirstName", "LastName", "NameOfBusiness", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), "Jane", "Doe", "Jane's Cafe", "123-456-7890", new Guid("1ae80037-f648-442e-a309-4b94a3d1315c") });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("10a63976-d018-4e76-bb0d-5fb2bef31f4e"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "123-456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("3c3e6a68-e749-4ede-a918-f4fab6715385"), "123 Main Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 1, "A place where you can eat food", "https://dummyimage.com/400x200", "123-456-7890", 1, "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("45400dcb-0dd9-4fa8-9c29-550be9b5036a"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "123-456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("4dadc4e2-43e0-4e5f-9cec-639cfbd35999"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "123-456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("8565f995-a200-46b7-bc84-67c2fbc93b21"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "123-456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("afc00a63-3a15-4c79-a7b0-08c3d68a50c7"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "123-456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("ca480780-dca2-4527-b54a-054da1477393"), "456 Elm Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 2, "A place where you can drink coffee", "https://dummyimage.com/400x200", "123-456-7890", 2, "Cafe", null, "https://www.cafe.com" },
                    { new Guid("edcc329d-a02c-4afe-b045-50772f6fcae0"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "123-456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

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
                name: "IX_Reviews_BusinessId",
                table: "Reviews",
                column: "BusinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");
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
                name: "AspNetRoles");

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
