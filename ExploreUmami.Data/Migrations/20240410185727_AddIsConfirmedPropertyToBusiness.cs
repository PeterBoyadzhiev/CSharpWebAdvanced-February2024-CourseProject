using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddIsConfirmedPropertyToBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("025c6955-e43b-4a69-b21d-391fce0ef803"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("16b5734c-34f6-4d9c-b51d-1de1a809889b"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("e892d5fc-6e0a-4ec1-a8b5-d0d9cb384818"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Businesses",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Businesses",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("4222168e-c018-418e-812f-f8d41b322522"),
                columns: new[] { "IsActive", "IsConfirmed" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"),
                column: "IsConfirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"),
                columns: new[] { "IsActive", "IsConfirmed" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                column: "IsConfirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"),
                columns: new[] { "IsActive", "IsConfirmed" },
                values: new object[] { true, true });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsConfirmed", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("2a3e9757-aece-449a-be6b-4b7df91a2953"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("7d7d7846-b4f9-4efc-b25b-b3d590c678b4"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("8e9b72b9-36e8-4c6c-a84c-3ede1a67abdd"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Businesses");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Businesses",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3348f13f-30d8-45de-826b-52e8a45496d3", "AQAAAAEAACcQAAAAEAyfvVjdHt0yCbWNpcp0NtIZ0a6s55LZVPvIyTjE5ZG+yajgnZNRgzMwPQ354HlJFg==", "57314D1B12D60642B1249E671C803B91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aaef409-b41c-4450-a70e-7629f6dadefd", "AQAAAAEAACcQAAAAEEYu042B3HZ7edc/Zm2VAh6Hz2AI+qy0a4kXqC37SFCVFi8UcxGWlXdB1h0/ONHnEQ==", "57314D1B12D60642B1249E671C803B91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bb0626e-c280-4bf0-a85c-5cad35dd4f43", "AQAAAAEAACcQAAAAEIUKNFE0yU/Vz8GTrCv4pAZxXsLAYORaGEGkUapUoDufLwxFP2zQ/b/JlE56TiDeNA==", "57314D1B12D60642B1249E671C803B91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bc1f17a-cbd8-4fa1-9a2e-e9a2decbf965", "AQAAAAEAACcQAAAAEGUfDeZdb7Of6izOH+PE3DXKDD5qv/uO7nC07i2SSSujYn3DAltzIUhwKZnKbbQ0KQ==", "57314D1B12D60642B1249E671C803B91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c326cd32-a1e1-4cbf-913f-d9bb1de84b3d", "AQAAAAEAACcQAAAAEORtT8GNi++69rkZFmipVd2PAeNuMtDMrnSy8h89yw1xoL4aJFOHURIi5jYzZSWE0Q==", "57314D1B12D60642B1249E671C803B91" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("4222168e-c018-418e-812f-f8d41b322522"),
                column: "IsActive",
                value: null);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"),
                column: "IsActive",
                value: null);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"),
                column: "IsActive",
                value: null);

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("025c6955-e43b-4a69-b21d-391fce0ef803"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("16b5734c-34f6-4d9c-b51d-1de1a809889b"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("e892d5fc-6e0a-4ec1-a8b5-d0d9cb384818"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8258));
        }
    }
}
