using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class ChangingUrlCapitalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "WebsiteURL",
                table: "Businesses",
                newName: "WebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Businesses",
                newName: "ImageUrl");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d87a917-fddc-478d-8498-c73e26007df9", "AQAAAAEAACcQAAAAEEHMMu+unvMMgXyoCCe3fy37v9A27h8D425sB1iZcvz9Gv74ncoR5PSwe7xhAkzgog==", "1E3ADB1E857F75B7EA667A18DDACAA2C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "727c6986-0b4c-4d45-9e17-0122c6fff826", "AQAAAAEAACcQAAAAEBxtNV4o+q7CmJ71ZiS/Tvz6Gko1myV+7R3OldoUMXnk8DG/QmxxXopn/VHg6pt6ZA==", "1E3ADB1E857F75B7EA667A18DDACAA2C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f841c33-56bb-414d-b65a-5502939c5d21", "AQAAAAEAACcQAAAAEF5/MB2q3R16Y7auCLLyMW+3u+SKtTdVp3a/QyZH6LTWN+Avwr3QS66DbCheqSYJbw==", "1E3ADB1E857F75B7EA667A18DDACAA2C" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("0d2801d3-f08d-430b-b010-f41f5212a381"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("23bf1a71-bfd8-40d8-be0c-f847625bf457"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("69154e68-1cc8-41c3-99d4-5e07ee4a0cb3"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("95fdf0a9-62e9-4bae-a2b1-ba238454bf5e"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("d01464f2-f855-4e5a-b0f6-0432ad0705a9"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("d60ec3f0-1c0c-4d01-a620-3a917a28aa5b"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("0d2801d3-f08d-430b-b010-f41f5212a381"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("23bf1a71-bfd8-40d8-be0c-f847625bf457"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("69154e68-1cc8-41c3-99d4-5e07ee4a0cb3"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("95fdf0a9-62e9-4bae-a2b1-ba238454bf5e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("d01464f2-f855-4e5a-b0f6-0432ad0705a9"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("d60ec3f0-1c0c-4d01-a620-3a917a28aa5b"));

            migrationBuilder.RenameColumn(
                name: "WebsiteUrl",
                table: "Businesses",
                newName: "WebsiteURL");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Businesses",
                newName: "ImageURL");

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

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("316e3cf1-277c-441f-bc38-c917f735ea4f"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("3dbc8bdf-a8ab-4e32-bbf3-383aa8984571"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("72b66266-3968-405f-a186-4ba737f5d333"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("8ccf808f-b001-4ea4-b19b-2182103366c9"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("d4cea5e3-456b-418e-b057-9d3df07be672"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("eda5d4d6-ecd5-499c-ae24-e7192244dc39"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });
        }
    }
}
