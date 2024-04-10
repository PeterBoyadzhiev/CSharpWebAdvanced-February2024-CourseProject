using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class ChangeNameOfIsConfirmedInBusinessToIsApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("2a3e9757-aece-449a-be6b-4b7df91a2953"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("7d7d7846-b4f9-4efc-b25b-b3d590c678b4"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8e9b72b9-36e8-4c6c-a84c-3ede1a67abdd"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dc6688e-59ba-4239-a328-5f357a5471a8", "AQAAAAEAACcQAAAAEDlpZoHliat0Juj2OkjK8xQ/B+kdq0PE9miSf91ao7W95N+efWHjVQ21ATl4CDxyRg==", "DF001A15268383E583190B0DC6DCE070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88d23cb9-6aa2-4acf-8e86-4ac410251025", "AQAAAAEAACcQAAAAEE0o7A4H1NxrSlSzSLiuNtQppyZj9b6IMvtuDGNlq1/JW0/7v7kunPT+AQ9/13gtqw==", "DF001A15268383E583190B0DC6DCE070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "035f8b45-8383-415c-8bf7-98490f2f389d", "AQAAAAEAACcQAAAAEMFdR/OOhYj7gdT8SD12Yhfo0auZS+87378/+Zt+TPL7cw8EkiylVA0LkaQN3RlHFA==", "DF001A15268383E583190B0DC6DCE070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab09ecbe-d333-46cb-88e8-26c346baeb95", "AQAAAAEAACcQAAAAEJCTVMfgf0AU/OYwgwdGWPyN7l3d3kxJs9VAA7AwCAhMNXr8T8TtrD5/ioxPQak08A==", "DF001A15268383E583190B0DC6DCE070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b7b4e06-0cd9-472c-aaea-c7ac2c4d4ecd", "AQAAAAEAACcQAAAAEBnz4PCAhw5ZrXZ/CGDAb2veJgte28AYKajjspEASEmcJvOcvk6HYy2m/jbn7+8E/A==", "DF001A15268383E583190B0DC6DCE070" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("9f7791bd-78ba-48a6-84e2-9184c556f84b"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("b76fc24b-cf42-4d0f-b26b-62bb36520368"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("eca078d0-9556-4a28-8cda-804cc13b84cd"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 21, 3, 30, 228, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 21, 3, 30, 228, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 21, 3, 30, 228, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 21, 3, 30, 228, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 21, 3, 30, 228, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 21, 3, 30, 228, DateTimeKind.Utc).AddTicks(2951));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("9f7791bd-78ba-48a6-84e2-9184c556f84b"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("b76fc24b-cf42-4d0f-b26b-62bb36520368"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("eca078d0-9556-4a28-8cda-804cc13b84cd"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60d29cf3-0652-4d4b-b670-59119c446561", "AQAAAAEAACcQAAAAEH3C2ZaVWQSngfYqgIMxsFvYH01R9LBBKPo0vVyqQU6TFHFkMyaxCLuT/Lzw+7zNRQ==", "222892716329006D871CDAD532E9916E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e921e1b-1394-44a8-82c3-eff8dc51457e", "AQAAAAEAACcQAAAAEGxoHUzleJW40zocY2WnA/pcnIqRscp2hjTi6a+Oye3MQZX1g9zklzAARXRJMPxm8A==", "222892716329006D871CDAD532E9916E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "526587b3-7301-46c7-93cf-ae747361be46", "AQAAAAEAACcQAAAAEIAg2zpVQwfQGp7LL/l+vGHlJrgLqa8WSs8nG9aEpJFMYb0WiIbUyW+xba6CwMVoXw==", "222892716329006D871CDAD532E9916E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8102d91-5cd8-4aae-ba79-36818d67d1aa", "AQAAAAEAACcQAAAAEK8Wp6EYo9ZPCendiwpMMPHZE75imEajbURmSC218oCxG0ptuMN+vZEBFDfTQqHp2A==", "222892716329006D871CDAD532E9916E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9054352e-b9e1-48f1-a4d9-e56b14fd7478", "AQAAAAEAACcQAAAAEIjCCAsuQ1QMnQI2rDcEZ11NAcl7WaOrgZVRRmkcQCQxpjGT9dfVm6PZLqD/Zsm+Lg==", "222892716329006D871CDAD532E9916E" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("2a3e9757-aece-449a-be6b-4b7df91a2953"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", false, true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("7d7d7846-b4f9-4efc-b25b-b3d590c678b4"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("8e9b72b9-36e8-4c6c-a84c-3ede1a67abdd"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 18, 57, 27, 175, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 18, 57, 27, 175, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 18, 57, 27, 175, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 18, 57, 27, 175, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 18, 57, 27, 175, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 18, 57, 27, 175, DateTimeKind.Utc).AddTicks(9466));
        }
    }
}
