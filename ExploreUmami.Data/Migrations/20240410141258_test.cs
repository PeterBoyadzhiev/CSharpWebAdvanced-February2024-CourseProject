using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class test : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afbf31e4-4e51-429c-9930-e5413ff18974", "AQAAAAEAACcQAAAAEAKPxlg8ffvVPPIe8i3yqdraTpIg7UGk/XM3SaV7XUyYOjjAqnnLSYQ7rtQzDTkSrQ==", "D4B861D136235CF46AAD365C423D20E9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17830813-2cea-40fe-8a5a-f8e5572d9d27", "AQAAAAEAACcQAAAAEJiXyQT6x7Mwu+HQNQzAW0FUcaOFv+n9RC6W/cRgKbiwUPO0cO9/ytntgD/0LsE9sA==", "D4B861D136235CF46AAD365C423D20E9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dc7509f-4f9c-4b65-83b9-9b42f62d0ea0", "AQAAAAEAACcQAAAAEK4i3VDcHPF/jNiJw51OHKKmm+l5ou7uOnUpMOfNLT71jAs2Hyj0i0X0RejC9F11JA==", "D4B861D136235CF46AAD365C423D20E9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c86e3420-36a9-4ad6-ba1c-41ede7242119", "AQAAAAEAACcQAAAAEN8AudCXLn7J4yP+2J85p6Fy111Uck0K/w57hLraj9Tdt3E5TERDH1SsEZLh4kBnUQ==", "D4B861D136235CF46AAD365C423D20E9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "276821b2-e9cc-4488-bbc0-86e1856d52c0", "AQAAAAEAACcQAAAAEH3+zlOGTcWMmnaTOHyrovTk/bsCn8PsBTq/eL9iRrZRB3iKIQtc/MOMnIhiBKdgXA==", "D4B861D136235CF46AAD365C423D20E9" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("5158e099-2957-4950-a437-b5753077ff58"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("73a0ca1f-082a-499f-a037-ac74653d33a3"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("c968174e-2e5d-45b7-8905-c64d4fc52817"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 14, 12, 57, 887, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 14, 12, 57, 887, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 14, 12, 57, 887, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 14, 12, 57, 887, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 14, 12, 57, 887, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 10, 14, 12, 57, 887, DateTimeKind.Utc).AddTicks(4525));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5158e099-2957-4950-a437-b5753077ff58"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("73a0ca1f-082a-499f-a037-ac74653d33a3"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("c968174e-2e5d-45b7-8905-c64d4fc52817"));

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
