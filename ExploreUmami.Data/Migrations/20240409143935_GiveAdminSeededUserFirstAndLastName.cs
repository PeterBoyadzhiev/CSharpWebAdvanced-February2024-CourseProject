using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class GiveAdminSeededUserFirstAndLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("002a2e83-3b10-46f6-aa82-abbbb249af05"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5967627b-c288-446b-9cec-082daac09922"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6c167e2a-d1fa-4887-aed1-446e7a1cdeca"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("922fbfe3-d446-420b-85c4-ebc390b59538"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("ce607792-ff36-4f9a-8897-9d9d29fd31ec"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("dc740d5f-179d-4412-8bd1-2e54ec018b36"));

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
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53458f45-e167-4629-9db9-ff8cf071d8ec", "Admin", "Adminson", "AQAAAAEAACcQAAAAENBK0GPkTqttjkUoq7zrazaW+DL2dKIDoRkg5WjRuLJK5GU/T1O9/AECZMxbFzDlcA==", "766E85CE65644F34092DD4F1B692BE94" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("22df7c5f-5dd9-48f1-bbe7-98df9de46be3"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("2332fb4d-9a0a-4180-8290-d8b5a8d1e74f"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("5c7adcb7-b08d-4ed1-b233-257e12825fc7"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("b58144fa-e4aa-4acd-b764-d22d5db91fb6"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("b6786706-daf9-4269-a22c-3533f32c8fdf"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("ffe57935-2f9c-4c7f-ada7-86e9bcc1c916"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 39, 35, 4, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 39, 35, 4, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 39, 35, 4, DateTimeKind.Utc).AddTicks(3104));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9212e6a7-f86d-45cb-a933-751f4c97d8a9", "AQAAAAEAACcQAAAAEN6FNpBbWiQabB2xprOzPZ9CPd6YC1+mqrwLKt+geOjKy8S7QFBeXY22JlS67RMbkg==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716afbb5-c787-4c32-b29b-d759c704b05d", "AQAAAAEAACcQAAAAEH45uU6dEujDE+Ge7wk6zhs+8kjrWJHj1wm5lGS6mGTZBmkjQNNfrh7HaVJC2pTH7A==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "254c1d9c-78a0-4a98-a420-728aa41c6484", "AQAAAAEAACcQAAAAECxqwMP2sFO0dXBYaslIH6ltnRLmLka8Jue6WpNFtYLRsCEC7MlZLHI5IP90mKeZXw==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9d82a8c-2a29-4704-bedb-23cc3afe9fdd", "AQAAAAEAACcQAAAAEAYoMyRbJGDXy6lB74oGfMEtJ+x8cEkiUPLUIQk4VETNK4uVF4twzuZomGsKrzIZMw==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7987c6b9-7f66-4dfe-90fa-9cc3e1aed4ea", null, null, "AQAAAAEAACcQAAAAED4FBY4kP6cM2B9UugSuT/8ocIeu1ROqI/HIDam8JigvUklDsu64VIh1O9sKUSxo0Q==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("002a2e83-3b10-46f6-aa82-abbbb249af05"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("5967627b-c288-446b-9cec-082daac09922"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("6c167e2a-d1fa-4887-aed1-446e7a1cdeca"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("922fbfe3-d446-420b-85c4-ebc390b59538"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("ce607792-ff36-4f9a-8897-9d9d29fd31ec"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("dc740d5f-179d-4412-8bd1-2e54ec018b36"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 34, 35, 252, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 34, 35, 252, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 34, 35, 252, DateTimeKind.Utc).AddTicks(6771));
        }
    }
}
