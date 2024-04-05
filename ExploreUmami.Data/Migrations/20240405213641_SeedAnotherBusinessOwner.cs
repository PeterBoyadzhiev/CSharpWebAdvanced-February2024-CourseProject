using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class SeedAnotherBusinessOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4b2c7cf4-a2c6-4be8-a521-3e2684218528", "AQAAAAEAACcQAAAAELtMT/E6kXwEZDTt5plzdQAbC3tDzPUEC8Xf9R81Yu1LqedFdua6NdGtYvLeRg0qbA==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "221d1820-95ed-4a8a-b4bf-57253340d681", "AQAAAAEAACcQAAAAEGSy2uOBCo3yRuEI1NzjO1WhZf8t2z2Gc0vnvDnyQ60vFkHBYp4Zk3VhaqRftbxe0A==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ba0b192-d02f-4c34-88df-249dae079823", "AQAAAAEAACcQAAAAENZoxg5J7TPvFVfg0CNYN1/6A12c5vOto1F1OL7GZEJBiZpw6TGJskcni7TEUaKaGw==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b582c7a9-2008-4cae-8730-0b2c05421df5", "businessowner2@gmail.com", "BUSINESSOWNER2@GMAIL.COM", "BUSINESSOWNER2@GMAIL.COM", "AQAAAAEAACcQAAAAEMIMiBBsZcV8e3VTR9v8I1pq1h+uW2VIkO0hah3sfhEr1dRidxBAILMNXUDV2cWH9g==", "9B5729D72E2CAF7F3CB8A20B68191FCA", "businessowner2@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"), 0, "831ae9c1-5d38-4504-9102-2550fe015621", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPXy1pbR22I8ovYGcE1NXPSnwWaA31v1+oUGTUXLHBCIv6JIWS79Ne3yubLaUhgJgQ==", null, false, "9B5729D72E2CAF7F3CB8A20B68191FCA", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("08bdc115-86d5-4bd6-b588-c8601124c6bb"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("1ea6bf0c-0897-4a8e-a98f-7242b1fe9492"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("445829d3-3085-45fa-ba38-818b30f9a9ec"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("67948288-9507-46cd-a6f3-fcd14221f7bd"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("707b4a12-a932-4779-97c2-98c4b431e8b1"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("f639cbe8-22cb-4d83-be14-659e35c8259e"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 36, 41, 185, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 36, 41, 185, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 36, 41, 185, DateTimeKind.Utc).AddTicks(8596));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("08bdc115-86d5-4bd6-b588-c8601124c6bb"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("1ea6bf0c-0897-4a8e-a98f-7242b1fe9492"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("445829d3-3085-45fa-ba38-818b30f9a9ec"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("67948288-9507-46cd-a6f3-fcd14221f7bd"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("707b4a12-a932-4779-97c2-98c4b431e8b1"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("f639cbe8-22cb-4d83-be14-659e35c8259e"));

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9a0e5715-1716-47da-b43e-518316cd2465", "admin@gmail.com", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFotmbY72WBbfajx4NP8pguIhj7d6Y6thumXYaSDiHa8wvhpSU/GODEK+DbiH1GFCg==", "2FE0562C405B7719F1F36E1F4598FA94", "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("00f55338-934a-47d7-8d73-f82f4c7c2334"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("5de2eb2a-b2b8-418c-9cff-da6d77c5d0e4"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("609ffe73-9d4c-4c01-a4bb-39ae605f4024"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("7612f645-28c7-4354-9720-941c0fefb52f"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("cc2e22fb-9163-49bb-884f-efcfc01686cd"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("eeffd481-4b7b-4c75-b8f2-39ad89316b87"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 17, 46, 54, 812, DateTimeKind.Utc).AddTicks(5090));

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
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 17, 46, 54, 812, DateTimeKind.Utc).AddTicks(5095));
        }
    }
}
