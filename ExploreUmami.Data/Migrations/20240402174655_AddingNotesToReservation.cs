using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddingNotesToReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("24ccb77e-8672-478d-95a5-a2f61f43fbc3"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("27f80c85-603e-4121-a316-21e6cd02de4d"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("527675f9-9d82-4486-83be-1bea7d1ed73c"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8ff860e6-86cf-4d0a-a48a-5465916a9590"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("b1eb5407-4134-40ce-a1ec-1c811780635e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("cf5039e5-8443-46ae-a80a-3ed8bc655f36"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bd403d9-257e-4eed-8a56-7b293fa773ab", "AQAAAAEAACcQAAAAEOW53v6Ns567zFG0zOA8O49eC9lj4crLQ9bfvxu2/0UX2P6e7Xr0e1MXgUN8yAAQgQ==", "2FE0562C405B7719F1F36E1F4598FA94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c44094b3-fe35-4577-89b7-b3198db4569a", "AQAAAAEAACcQAAAAEEIElyWr1YD7471nsaJJDDltny08TRwA46h+zfKQ86AgaOItf490qkabOXF2bvMytg==", "2FE0562C405B7719F1F36E1F4598FA94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "458f7092-5ebd-4ab2-98d3-f63e5ccb1e15", "AQAAAAEAACcQAAAAEPuZRE2sxYFLGHJKa03nTY/Ty9NFPdVBh4eMmFRidGRozBLIaMZkSrH0FD04B36RlA==", "2FE0562C405B7719F1F36E1F4598FA94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0e5715-1716-47da-b43e-518316cd2465", "AQAAAAEAACcQAAAAEFotmbY72WBbfajx4NP8pguIhj7d6Y6thumXYaSDiHa8wvhpSU/GODEK+DbiH1GFCg==", "2FE0562C405B7719F1F36E1F4598FA94" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("00f55338-934a-47d7-8d73-f82f4c7c2334"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("5de2eb2a-b2b8-418c-9cff-da6d77c5d0e4"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("609ffe73-9d4c-4c01-a4bb-39ae605f4024"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("7612f645-28c7-4354-9720-941c0fefb52f"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("cc2e22fb-9163-49bb-884f-efcfc01686cd"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("eeffd481-4b7b-4c75-b8f2-39ad89316b87"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                columns: new[] { "Notes", "ReservationDate" },
                values: new object[] { "Please reserve a table for a family of 3 adults and 2 children", new DateTime(2024, 4, 2, 17, 46, 54, 812, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 17, 46, 54, 812, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                columns: new[] { "Notes", "ReservationDate" },
                values: new object[] { "Please reserve a table for 4 adults", new DateTime(2024, 4, 2, 17, 46, 54, 812, DateTimeKind.Utc).AddTicks(5095) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("00f55338-934a-47d7-8d73-f82f4c7c2334"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5de2eb2a-b2b8-418c-9cff-da6d77c5d0e4"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("609ffe73-9d4c-4c01-a4bb-39ae605f4024"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("7612f645-28c7-4354-9720-941c0fefb52f"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("cc2e22fb-9163-49bb-884f-efcfc01686cd"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("eeffd481-4b7b-4c75-b8f2-39ad89316b87"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c13e7a-e552-42c3-a323-ba9dbb21b723", "AQAAAAEAACcQAAAAEHx18GjhYrHQZ62V+X3dIukzd17YJAWcterwg5PrW8PzUaG1p+CgM7Ot3s+ZTJA3MA==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e69009e-7406-4884-8e78-38f2ea6de7d5", "AQAAAAEAACcQAAAAEHcriWHudz9jt+wYn78rDq5eoB+2zMKTy4KvGyufHskT6GcJhzCedT+07gXSj5g1Dw==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78fb8f12-9ede-480b-a799-c1c85b6cfa78", "AQAAAAEAACcQAAAAEPDDlq9IsYya1tf9GTRHJlKsa/bMhKlJZH5aYm2tlV4MbhrbNv0lNQvwURxLzWz3eg==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "721dca27-9976-40c8-96d8-7528d62780b2", "AQAAAAEAACcQAAAAELSA2EmOQZGWMmekcvr4oe9WDQdoFngMCXP8mAZ2W8YmwPVLIyYYylBO93eJXJ1N/A==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("24ccb77e-8672-478d-95a5-a2f61f43fbc3"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("27f80c85-603e-4121-a316-21e6cd02de4d"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("527675f9-9d82-4486-83be-1bea7d1ed73c"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("8ff860e6-86cf-4d0a-a48a-5465916a9590"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("b1eb5407-4134-40ce-a1ec-1c811780635e"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("cf5039e5-8443-46ae-a80a-3ed8bc655f36"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                columns: new[] { "Notes", "ReservationDate" },
                values: new object[] { null, new DateTime(2024, 4, 2, 16, 14, 29, 188, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 16, 14, 29, 188, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                columns: new[] { "Notes", "ReservationDate" },
                values: new object[] { null, new DateTime(2024, 4, 2, 16, 14, 29, 188, DateTimeKind.Utc).AddTicks(6109) });
        }
    }
}
