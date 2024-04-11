using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddIsActiveToReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("253f30f2-4077-48a0-8626-687a57da40b4"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("d7cf28e0-d2f5-4e0d-b3ac-4ab037fb39ec"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("f90193ff-c7c0-4b12-9632-53e4dfd34360"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: true);

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
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("1db1f5fd-332f-418f-8f49-343368592cba"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("87e6efdd-6616-4c77-80bf-bd427fe970a8"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("ea1ec997-f956-4623-a200-944959cc423b"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c980d19-74ad-431c-9c82-4f99da19816d", "AQAAAAEAACcQAAAAEGkAzxeNmXQqdRZKoj2TVVwemdqtBjOPwrKVQn9yYn3Bf4nkEUMNcy+bEeUV0idQUA==", "A75339CEFA31A8F586006307F89E5A80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54085b6e-8752-4401-adee-46072e1c3170", "AQAAAAEAACcQAAAAEEmyD1k/fkizqpDSYMHKdE1LTIDRg9pnm205Ws+5BpAstqz2ncMl3PynDUtys91ytQ==", "A75339CEFA31A8F586006307F89E5A80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd62a385-f8ec-48f6-958d-8e39fc119826", "AQAAAAEAACcQAAAAEO1xy3CPC8CJ+dL/CKv/B/Bhdwm9+fYHNckHz2UQdz611F0qREJZ9iwAUJDhJu0Qkg==", "A75339CEFA31A8F586006307F89E5A80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ea11b8-b3b4-4f56-ae2c-7956ac73c6ae", "AQAAAAEAACcQAAAAEJm1rhPmZHDx3qGE+GVUQYnKUft89nuOBq3tt8E9LCYm8GHZe9IYrzyBP7ECmXLdoQ==", "A75339CEFA31A8F586006307F89E5A80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccf71980-224b-4622-9475-54a290ad3f40", "AQAAAAEAACcQAAAAENM/rWw1y/wvrILbptJ1kDOntvYVwbnV0YEyMQvVQZw9yWBmYKIl9fpxhm1iOIVqZw==", "A75339CEFA31A8F586006307F89E5A80" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("253f30f2-4077-48a0-8626-687a57da40b4"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", false, true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("d7cf28e0-d2f5-4e0d-b3ac-4ab037fb39ec"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("f90193ff-c7c0-4b12-9632-53e4dfd34360"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 14, 27, 1, 710, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 14, 27, 1, 710, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 14, 27, 1, 710, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 14, 27, 1, 710, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 14, 27, 1, 710, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 11, 14, 27, 1, 710, DateTimeKind.Utc).AddTicks(9629));
        }
    }
}
