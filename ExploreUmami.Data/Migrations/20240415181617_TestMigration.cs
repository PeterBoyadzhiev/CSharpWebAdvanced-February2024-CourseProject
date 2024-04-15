using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5b00fbd-c65e-4e9e-84e8-2a9d8b0aad37", "Jon", "Doe", "AQAAAAEAACcQAAAAEIzon7iounT3bFzYB5snX1Jn2rFRyLixj+Q7pKfYE93NBG/w21P/wcRsMVa/+QwEPg==", "1A854D3A51C3647D48698D30F4431A20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad013748-4426-4a27-9876-8002452507bf", "AQAAAAEAACcQAAAAEIrhn3u3Gu5k5w+ZckmE26Nj9Dy2c8MxhWyRYo3rWSOIhAS4rtpEoQTMtlfK/9SEGQ==", "93EACEAA9EAB9F8ED3965938F4BE0ED4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf7f2ce8-b2aa-4d63-a21a-afb293c914db", "AQAAAAEAACcQAAAAEGCWULDuMbl0HclSfQu+KUb5Izh0HUcH/n8+HXjl6y0l6P4X1xKpn/dXqaCL6KNWiw==", "32164FCA6194D48012BFCF3782787855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e60b8e1-a73b-4048-a0e3-0602fa264d3a", "AQAAAAEAACcQAAAAED2Zr+m+epUioWFHP43UxT8V3lKxaDSJw30XT3cajt9JdS8JJ/Q3TMPikH4l95lDig==", "D3AEAAF905CF227737B3B389291725F3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a35fcc84-dbc6-4513-b6ef-0d359ab397ad", "AQAAAAEAACcQAAAAEGiqpN1of8I+A6CYN6N+npZVdxYwQu9dopNxR+AUmqpS4m9RTFTTs7xOf4FwODfYzg==", "1928F5AA634EAD8BF3C1647437E5E77D" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("40fe3c23-e9bf-416d-8994-18d657b812ea"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("81141350-8def-4b0f-8b4a-558fa3805145"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("cb4ef459-43f8-42eb-b6fb-283047ff0000"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bb49a06d-fbd1-4fdd-a7d4-d309445c59f8"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 15, 18, 16, 17, 295, DateTimeKind.Utc).AddTicks(6969));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("40fe3c23-e9bf-416d-8994-18d657b812ea"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("81141350-8def-4b0f-8b4a-558fa3805145"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("cb4ef459-43f8-42eb-b6fb-283047ff0000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f7a7ea0-3e5e-43fb-93bb-d9e6dec10425", null, null, "AQAAAAEAACcQAAAAEBFZ3IlCrK/jn7sfWny9ECbMRR5Z9ptmFlNLs11lbd/F3dzLKsBq0YkONyMMIPy2Eg==", "B61C6B2E82B05385B6B8A18AB50ACD23" });

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
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("98d0da0e-b6b1-443a-b87c-2f853f48ad7b"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("a520c450-bcdb-408c-814a-5f53a9f17f90"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", false, true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("fc1e0c61-75b8-49da-8286-7080a757802e"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

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
        }
    }
}
