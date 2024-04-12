using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class SeedUserVisits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("96f83ecc-8818-42a1-a2b6-d9871d5871c6"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("a9b00a38-d114-4ca8-ace9-2e20f6b798a5"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("abe0f7eb-bec3-4bd0-8826-629358d10483"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f7a7ea0-3e5e-43fb-93bb-d9e6dec10425", "AQAAAAEAACcQAAAAEBFZ3IlCrK/jn7sfWny9ECbMRR5Z9ptmFlNLs11lbd/F3dzLKsBq0YkONyMMIPy2Eg==", "B61C6B2E82B05385B6B8A18AB50ACD23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9c8d4e1-8607-466c-81a5-55b762304d94", "AQAAAAEAACcQAAAAEM+2r+vqBBOFAbvGRtrK6PIbtiGxak3qECDAGhyqVeJTYGZxjyMVoJDtxIh7xoaXvw==", "B61C6B2E82B05385B6B8A18AB50ACD23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86292649-8e0c-40a8-933c-4239ae6aab46", "AQAAAAEAACcQAAAAECSUcHUkqdNwRndH4B5Y7N0HSprpwa6AA9MfdMfz+VS+98/KQrGsdgP7zl2dSPvF+Q==", "B61C6B2E82B05385B6B8A18AB50ACD23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b2b0ed6-dc4d-4500-b57f-97412b4e76e0", "AQAAAAEAACcQAAAAEPjYtw+7ppVoZe/EDdqS7V9v29B/PEN5cZaaDUadADxDBNCnRTNezAHmX5CrzZmEoA==", "B61C6B2E82B05385B6B8A18AB50ACD23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1376d361-1a15-49e9-9ad4-2ff307694e91", "AQAAAAEAACcQAAAAEC4+xlr/FnrsM4TP922E5i72vOum6qz1pZ4c3rbboyIi//s+s9SIrDZZJEGffG8/EA==", "B61C6B2E82B05385B6B8A18AB50ACD23" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("98d0da0e-b6b1-443a-b87c-2f853f48ad7b"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("a520c450-bcdb-408c-814a-5f53a9f17f90"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("fc1e0c61-75b8-49da-8286-7080a757802e"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bb49a06d-fbd1-4fdd-a7d4-d309445c59f8"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 50, 22, 82, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationId", "UserId" },
                values: new object[] { new Guid("4f8e6201-2013-428a-8ddb-c75312ca9bff"), new Guid("4222168e-c018-418e-812f-f8d41b322522"), null, new Guid("bb49a06d-fbd1-4fdd-a7d4-d309445c59f8"), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("98d0da0e-b6b1-443a-b87c-2f853f48ad7b"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("a520c450-bcdb-408c-814a-5f53a9f17f90"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("fc1e0c61-75b8-49da-8286-7080a757802e"));

            migrationBuilder.DeleteData(
                table: "UserVisits",
                keyColumn: "Id",
                keyValue: new Guid("4f8e6201-2013-428a-8ddb-c75312ca9bff"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e56514-6bad-48bc-9529-54e294a27ce3", "AQAAAAEAACcQAAAAEFpM8m9Lc0PbouixssuKq5dyGstnTRFo9PResMYRBzCctJZK7MOptQgcxQVcrtF/gg==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f972e454-805a-4c16-992b-569def512a2f", "AQAAAAEAACcQAAAAEGHpOdP+91yORYhiFujQA8K1qowxRnfG+yW/JzFtgZb3/ZO53iS0Es7+/2DdSDKg+g==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ee465d-3918-45bc-84a3-71649f06b7cc", "AQAAAAEAACcQAAAAEEb2HJbsLlg2vhHO7SY/s1+N+Pd+3k3h2osl3R2aubAD/zX4Xmb7L8/5o9TS57neYg==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc0e856-2411-419b-b8d2-8c4cb30e428d", "AQAAAAEAACcQAAAAEBQx5mIjEaVgmirYSRLb60phTryFWFlY5+lve9yE/i6BfCsMlWcONzTZcZ+jDCVklg==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ac31b6a-be17-4346-9c76-b833b5eac984", "AQAAAAEAACcQAAAAEFqmxayqAFuJZLvJwmZAg876uT8KQ4uuS89dX5fro5yuZEEEEhz7OvorMYkrz/3ioQ==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("96f83ecc-8818-42a1-a2b6-d9871d5871c6"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", false, true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("a9b00a38-d114-4ca8-ace9-2e20f6b798a5"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("abe0f7eb-bec3-4bd0-8826-629358d10483"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bb49a06d-fbd1-4fdd-a7d4-d309445c59f8"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3799));
        }
    }
}
