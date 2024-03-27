using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddCreatedOnAndIsActivePropertiesToBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("159fd9e4-1414-4d03-bd32-385cb7c59f90"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("40292fea-7748-4fe3-9944-987ef2410eda"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("51834097-9c17-44cb-acc4-c4dacd6170a4"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("73176956-6a9b-4f7c-9421-1dd8bc6633fa"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8a172b65-2a13-41f7-8e97-94b8fdc2d854"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("9310fc7e-d090-48b6-be15-89e4449463f7"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Businesses",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Businesses",
                type: "bit",
                nullable: true,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2cceaf0-439d-4db4-ba7f-45f151538408", "AQAAAAEAACcQAAAAEOmBCS/I9I0B0qufllnQBM6F1+TIVNEgiDOAzZzy4Nl1dTh5HpvO6+sD+SZRJKw7oA==", "D8E74E8D9682871BBEEF799C353E1780" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "513d2b1b-6d22-42a5-9eb3-20cbeae19e6b", "AQAAAAEAACcQAAAAEBup8irTOFm7PQCybBZHw2OqyvdGRdlr+Ix2fSrCSPNgNuUe+Dwdjd/RHL/trqdV9Q==", "D8E74E8D9682871BBEEF799C353E1780" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b25d0e-78ef-491e-9590-8184783edcfe", "AQAAAAEAACcQAAAAENBymn8lVp9qo3w9wtnr9p1yrPgrfYkPOSTAMcz1HK6Q2ipUJkMPdFH7ds3uJ90QXw==", "D8E74E8D9682871BBEEF799C353E1780" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("570356bd-c821-452a-98e6-b59e8a737bb1"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("98a5e7a1-519e-4083-a937-cdfb47a50596"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("a319858a-9f7e-4b27-aca8-5854b7ec2c5e"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("ba61347b-a7ae-4885-a1e1-ac5f78a648a5"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("c2b048a3-c77f-4a81-a758-3d33c054a934"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("fabacc4c-d9d0-4188-8cb4-7aa7067c6783"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("570356bd-c821-452a-98e6-b59e8a737bb1"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("98a5e7a1-519e-4083-a937-cdfb47a50596"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("a319858a-9f7e-4b27-aca8-5854b7ec2c5e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("ba61347b-a7ae-4885-a1e1-ac5f78a648a5"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("c2b048a3-c77f-4a81-a758-3d33c054a934"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("fabacc4c-d9d0-4188-8cb4-7aa7067c6783"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Businesses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d085571-f597-441a-a398-593926e298de", "AQAAAAEAACcQAAAAEGxBoNK52+spDyVp9GldfH8Z9u8Gb23gbnC/752215SuO0g7G9NLBJw+ZKetnkoTgw==", "49E3F745CBBF9193D54BD99DBD098F45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "604aa6a9-b3ac-410d-a8cc-9e7c9e88897d", "AQAAAAEAACcQAAAAEEH9K973I4u7IcY4Qfkjr4lNWBJvwxx4aAz5SwWTnTfnAdJTDcDYliw8YKrkpVJbBg==", "49E3F745CBBF9193D54BD99DBD098F45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84e5e5de-45d4-4d22-a3c4-1efdef094d3a", "AQAAAAEAACcQAAAAELhxZRSa9nMNTjKuwOFFV0UmYmKZwdw1yhYYYDAfMYie4XMmt6MdMiGO4NWhKyew/A==", "49E3F745CBBF9193D54BD99DBD098F45" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("159fd9e4-1414-4d03-bd32-385cb7c59f90"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("40292fea-7748-4fe3-9944-987ef2410eda"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("51834097-9c17-44cb-acc4-c4dacd6170a4"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("73176956-6a9b-4f7c-9421-1dd8bc6633fa"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("8a172b65-2a13-41f7-8e97-94b8fdc2d854"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("9310fc7e-d090-48b6-be15-89e4449463f7"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" }
                });
        }
    }
}
