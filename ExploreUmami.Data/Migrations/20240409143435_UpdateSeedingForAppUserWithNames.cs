using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class UpdateSeedingForAppUserWithNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("1a87341d-a8fd-4dc4-ae30-b03b63b578ed"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("24a0ea6c-38ee-43ec-8a66-592cb8e9a93e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("77b7e206-452f-4fff-9fb6-9f490da3b625"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("c25f4f31-a2cb-4f19-acf8-2741c9fee042"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("dd3d137e-624f-473e-83ce-a6df0e043000"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("e6cf9d79-d9d0-4977-810d-439ac1aeb481"));

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
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716afbb5-c787-4c32-b29b-d759c704b05d", "Janette", "Dane", "AQAAAAEAACcQAAAAEH45uU6dEujDE+Ge7wk6zhs+8kjrWJHj1wm5lGS6mGTZBmkjQNNfrh7HaVJC2pTH7A==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "254c1d9c-78a0-4a98-a420-728aa41c6484", "Jovani", "Dawson", "AQAAAAEAACcQAAAAECxqwMP2sFO0dXBYaslIH6ltnRLmLka8Jue6WpNFtYLRsCEC7MlZLHI5IP90mKeZXw==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9d82a8c-2a29-4704-bedb-23cc3afe9fdd", "Jane", "Doe", "AQAAAAEAACcQAAAAEAYoMyRbJGDXy6lB74oGfMEtJ+x8cEkiUPLUIQk4VETNK4uVF4twzuZomGsKrzIZMw==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7987c6b9-7f66-4dfe-90fa-9cc3e1aed4ea", "AQAAAAEAACcQAAAAED4FBY4kP6cM2B9UugSuT/8ocIeu1ROqI/HIDam8JigvUklDsu64VIh1O9sKUSxo0Q==", "D82865CDCBA7F0A7E014437495F12701" });

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                column: "UserId",
                value: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"));

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                column: "UserId",
                value: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"));

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("002a2e83-3b10-46f6-aa82-abbbb249af05"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("5967627b-c288-446b-9cec-082daac09922"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("6c167e2a-d1fa-4887-aed1-446e7a1cdeca"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("922fbfe3-d446-420b-85c4-ebc390b59538"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("ce607792-ff36-4f9a-8897-9d9d29fd31ec"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("dc740d5f-179d-4412-8bd1-2e54ec018b36"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c62379de-89b6-44bf-b386-9ef3ea912d69", "AQAAAAEAACcQAAAAEL/05C8ZOfQ5N3bbL2mIo/WE53kdD81KmqD+oiV1nVCI1rWRaZz7HMFurnm6SFAsiA==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfadd943-2633-4d89-a3df-d2c0953032ef", null, null, "AQAAAAEAACcQAAAAEFhaeMWcmzHxOQvQpGjgoCXJBuPCOMIS6Zd6NKLoojtIy5meJ6JSRfXTw7peFlZnrQ==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "626a5563-59de-4b2e-9632-1027bcb8f16c", null, null, "AQAAAAEAACcQAAAAEKRtRHQmLmk1EG74ZGoZtTdEOH4a37AJXthKQyBi5ocFMQn5Q871NwZTnS3WidU7Hg==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7a121a-089b-4c2f-a71b-3c88ce0ecfef", null, null, "AQAAAAEAACcQAAAAEP4ophmvWOoUkSPLqgMz3MFMQvypb81o5v4NmgHchd4q+huojbLTICpjUof7Zv/l3A==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c113f1d8-a909-4e5f-9f6f-93912abd1884", "AQAAAAEAACcQAAAAEH7907lmRF3LvlQzrh5Dhl8g2UIOnpEmeb1RPoUx2awrGqjQE7KQJufcmVI5xHePcQ==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                column: "UserId",
                value: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"));

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                column: "UserId",
                value: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"));

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("1a87341d-a8fd-4dc4-ae30-b03b63b578ed"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("24a0ea6c-38ee-43ec-8a66-592cb8e9a93e"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("77b7e206-452f-4fff-9fb6-9f490da3b625"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("c25f4f31-a2cb-4f19-acf8-2741c9fee042"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("dd3d137e-624f-473e-83ce-a6df0e043000"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("e6cf9d79-d9d0-4977-810d-439ac1aeb481"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 27, 23, 647, DateTimeKind.Utc).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 27, 23, 647, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 9, 14, 27, 23, 647, DateTimeKind.Utc).AddTicks(2791));
        }
    }
}
