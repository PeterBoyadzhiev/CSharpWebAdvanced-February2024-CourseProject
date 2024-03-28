using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddIsActiveTrueToBusinessesWithId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3125621-68eb-434b-bb55-8a7d6e46ff2d", "AQAAAAEAACcQAAAAEFyqmzzOpvQGJpnNyJguNAS/mS9wAJhWxmU95l8QAIvkqrGCFyQfwnJqz5Kr1oNkCg==", "EE5828BCB16B785CDB6E549223E421AE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bfd5833-3ae7-40fc-b6be-d706478ad3f5", "AQAAAAEAACcQAAAAEOE26v+EhRYz9/zGxBJ3dlz35GNO9XrUVQMOIrbspAGBXPjqXaChCgzP3vdQfSScLQ==", "EE5828BCB16B785CDB6E549223E421AE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38848886-3be9-4eb8-9bc1-8a3e95a04a53", "AQAAAAEAACcQAAAAEN7vbMvhiPgIHmcUFu0e1YYJj2UHdwr2ZtK1/ydBnnI+LoVHiUbgcHxKauChXn54Xg==", "EE5828BCB16B785CDB6E549223E421AE" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"),
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                column: "IsActive",
                value: true);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("316e3cf1-277c-441f-bc38-c917f735ea4f"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("3dbc8bdf-a8ab-4e32-bbf3-383aa8984571"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("72b66266-3968-405f-a186-4ba737f5d333"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("8ccf808f-b001-4ea4-b19b-2182103366c9"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("d4cea5e3-456b-418e-b057-9d3df07be672"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("eda5d4d6-ecd5-499c-ae24-e7192244dc39"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("316e3cf1-277c-441f-bc38-c917f735ea4f"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3dbc8bdf-a8ab-4e32-bbf3-383aa8984571"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("72b66266-3968-405f-a186-4ba737f5d333"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8ccf808f-b001-4ea4-b19b-2182103366c9"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("d4cea5e3-456b-418e-b057-9d3df07be672"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("eda5d4d6-ecd5-499c-ae24-e7192244dc39"));

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

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"),
                column: "IsActive",
                value: null);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                column: "IsActive",
                value: null);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("570356bd-c821-452a-98e6-b59e8a737bb1"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("98a5e7a1-519e-4083-a937-cdfb47a50596"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("a319858a-9f7e-4b27-aca8-5854b7ec2c5e"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("ba61347b-a7ae-4885-a1e1-ac5f78a648a5"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("c2b048a3-c77f-4a81-a758-3d33c054a934"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("fabacc4c-d9d0-4188-8cb4-7aa7067c6783"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });
        }
    }
}
