using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddUserLocationPropertyToReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("1db1f5fd-332f-418f-8f49-343368592cba"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("87e6efdd-6616-4c77-80bf-bd427fe970a8"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("ea1ec997-f956-4623-a200-944959cc423b"));

            migrationBuilder.AddColumn<string>(
                name: "UserLocation",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ce83292-b0a5-4b53-81d9-4fad935c070e", "AQAAAAEAACcQAAAAEH1SKZL7cJmMJQFqVHxtR3otKA25kNtyLgt+cqs8QgmOfdjrJzwfE31wz/c+yEtltw==", "278533273C6ADAB2DB96746D9455A081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bc20e8a-abca-4de4-bb60-2dad2243aa84", "AQAAAAEAACcQAAAAEEBxbEiFi63Y8PVf2L6KmjxTPmoYn8YrCzg9Pt7727oz7cGaB0tJ+VEMvgyIIXIx2w==", "278533273C6ADAB2DB96746D9455A081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b85e3c63-f5a8-4fbd-a613-11cc98b62758", "AQAAAAEAACcQAAAAENJaJp5iu9iqmNtx3l3nKIUugUmpFmb7LbUeodrMzJibn9RTs2STYtWXCyPi5fkDnw==", "278533273C6ADAB2DB96746D9455A081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6770adf-1b73-4c16-8b4a-74acc1052398", "AQAAAAEAACcQAAAAECWYcCjT9e1/2S3pb+qkwzSp8yPIpwgBOWznwQAddsDkQo8rlPqrYolBnNIuLsIaLg==", "278533273C6ADAB2DB96746D9455A081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23c4500-2c5b-410b-bb78-6825bfaa3035", "AQAAAAEAACcQAAAAEOXagJI+qiLuHDKmx1Vx69ieWyHUZK6i4l5DMqofDv5hKy2adXDM8S0Jxketuwuv5A==", "278533273C6ADAB2DB96746D9455A081" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("4aa23283-c8b4-4235-b524-feb71f3b7fad"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("6cc778b1-a0f0-4261-8f0e-0b779af021c9"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("6d650e35-7757-4993-becf-b74a89666517"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 21, 10, 10, 609, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 21, 10, 10, 609, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 21, 10, 10, 609, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 21, 10, 10, 609, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 21, 10, 10, 609, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 21, 10, 10, 609, DateTimeKind.Utc).AddTicks(7886));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("4aa23283-c8b4-4235-b524-feb71f3b7fad"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6cc778b1-a0f0-4261-8f0e-0b779af021c9"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6d650e35-7757-4993-becf-b74a89666517"));

            migrationBuilder.DropColumn(
                name: "UserLocation",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f158a501-6a38-4717-93b7-0d92bb23cf2b", "AQAAAAEAACcQAAAAEO0pNxluZr5p9ONM0OM2VLDQK0+HS1Hy91Hf4jns3QDgUsFmXL0SWYJyDKo2awT9fg==", "F7C80302B3C4BB255BC36BA0EE700566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b702537-0ef8-4498-aed9-7627827c5b85", "AQAAAAEAACcQAAAAENRBbclMZgFmQ1LMK4bTfbpfr3GnDs1kVB+w0Dzgwhb70ez2Gv6akzkZSZZ19ytkdQ==", "F7C80302B3C4BB255BC36BA0EE700566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51739be2-5d34-4310-9ff2-abe910f947ac", "AQAAAAEAACcQAAAAEPmxLg+UUKmzOeQes2cPod6FyDLniTYJrWVq79oabgEnsknO3iuBipdH2qZ6fJS8hg==", "F7C80302B3C4BB255BC36BA0EE700566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4609d123-12ef-4c14-beaf-23998d3ccfd6", "AQAAAAEAACcQAAAAEM5Vem66KPRonrUDR7uQ9tiXYv1CrTciX27DUSMoKnVJ8txzfIT65FJWEc4hYRGeYA==", "F7C80302B3C4BB255BC36BA0EE700566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c01ecea2-667c-4448-aa2d-0c84180003f6", "AQAAAAEAACcQAAAAEFIXEzJs2w1UmnpbXzvwjcKLN37rBcWvWlM0d/nX/6Kq/dNNrW8crVDQgWEdHrIAxA==", "F7C80302B3C4BB255BC36BA0EE700566" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("1db1f5fd-332f-418f-8f49-343368592cba"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("87e6efdd-6616-4c77-80bf-bd427fe970a8"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("ea1ec997-f956-4623-a200-944959cc423b"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", false, true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 15, 11, 43, 270, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 15, 11, 43, 270, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 15, 11, 43, 270, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 15, 11, 43, 270, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 15, 11, 43, 270, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 15, 11, 43, 270, DateTimeKind.Utc).AddTicks(5448));
        }
    }
}
