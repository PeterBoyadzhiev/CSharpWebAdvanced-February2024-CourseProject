using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class FixSeedingForUserVisitAndReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("22df7c5f-5dd9-48f1-bbe7-98df9de46be3"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("2332fb4d-9a0a-4180-8290-d8b5a8d1e74f"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5c7adcb7-b08d-4ed1-b233-257e12825fc7"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("b58144fa-e4aa-4acd-b764-d22d5db91fb6"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("b6786706-daf9-4269-a22c-3533f32c8fdf"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("ffe57935-2f9c-4c7f-ada7-86e9bcc1c916"));

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
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("025c6955-e43b-4a69-b21d-391fce0ef803"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("16b5734c-34f6-4d9c-b51d-1de1a809889b"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("4222168e-c018-418e-812f-f8d41b322522"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("e892d5fc-6e0a-4ec1-a8b5-d0d9cb384818"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                columns: new[] { "ReservationDate", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8252), "Completed" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                columns: new[] { "ReservationDate", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8241), "Completed" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "Status", "UserId" },
                values: new object[] { new Guid("11154b62-2abd-404a-827e-f4e69ad94678"), new Guid("4222168e-c018-418e-812f-f8d41b322522"), "I'll be visiting with my grandma.", new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8267), "Confirmed", new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "Status", "UserId" },
                values: new object[] { new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"), new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"), "I won't be able to make it, sorry!", new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8275), "Cancelled", new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "UserId" },
                values: new object[] { new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"), new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"), "Reserve 4 tables, we are a big company", new DateTime(2024, 4, 9, 20, 26, 24, 848, DateTimeKind.Utc).AddTicks(8262), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("4222168e-c018-418e-812f-f8d41b322522"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("7c8605e4-9e6c-474f-8c3c-a837d631c8d4"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("e39d9dc4-519f-4c74-9f59-86083df887c6"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea65254d-79fd-49c3-8acb-eb19ec77994e", "AQAAAAEAACcQAAAAEMH4XmmFi8rELwnx49y7dUW26QzXEXjguOYSqWJu75YVMYnjZeksLlBin1YmlEaSyg==", "766E85CE65644F34092DD4F1B692BE94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b77144-41b3-4e92-a026-586dc8450a85", "AQAAAAEAACcQAAAAEPJ69DbnYf/A7gxQrWNuodH5DEyHYRVQ/Boeb4fLMCAdBVs4Tti7MfilsgH/CgO7fQ==", "766E85CE65644F34092DD4F1B692BE94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18d67907-3123-4e2b-8852-affa33458514", "AQAAAAEAACcQAAAAEFavyL71nUIB4lqrtEF8w5aAE/39+0xMiDYmnq354fvgIqwjvrvGW7whw1dstaPXVQ==", "766E85CE65644F34092DD4F1B692BE94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc758d79-a2d1-4d52-9aa7-6c16a35f263b", "AQAAAAEAACcQAAAAEO8031gUz/OLvGtwR52ehdkuVZGlY+QQjWdBJps/PFflgiHv6q6uqIvTLHGuXK2Vrw==", "766E85CE65644F34092DD4F1B692BE94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53458f45-e167-4629-9db9-ff8cf071d8ec", "AQAAAAEAACcQAAAAENBK0GPkTqttjkUoq7zrazaW+DL2dKIDoRkg5WjRuLJK5GU/T1O9/AECZMxbFzDlcA==", "766E85CE65644F34092DD4F1B692BE94" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("22df7c5f-5dd9-48f1-bbe7-98df9de46be3"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("2332fb4d-9a0a-4180-8290-d8b5a8d1e74f"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("5c7adcb7-b08d-4ed1-b233-257e12825fc7"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("b58144fa-e4aa-4acd-b764-d22d5db91fb6"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("b6786706-daf9-4269-a22c-3533f32c8fdf"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("ffe57935-2f9c-4c7f-ada7-86e9bcc1c916"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                columns: new[] { "ReservationDate", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 39, 35, 4, DateTimeKind.Utc).AddTicks(3100), "Confirmed" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                columns: new[] { "ReservationDate", "Status" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 39, 35, 4, DateTimeKind.Utc).AddTicks(3089), "Pending" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 39, 35, 4, DateTimeKind.Utc).AddTicks(3104));
        }
    }
}
