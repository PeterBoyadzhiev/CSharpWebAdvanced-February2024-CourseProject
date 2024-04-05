using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class ChangeBOsForSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("08bdc115-86d5-4bd6-b588-c8601124c6bb"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("1ea6bf0c-0897-4a8e-a98f-7242b1fe9492"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("445829d3-3085-45fa-ba38-818b30f9a9ec"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("67948288-9507-46cd-a6f3-fcd14221f7bd"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("707b4a12-a932-4779-97c2-98c4b431e8b1"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("f639cbe8-22cb-4d83-be14-659e35c8259e"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da4631e4-a501-46e4-9c77-759be10251c8", "AQAAAAEAACcQAAAAEKtoklhafHGfQPEMVPzcR3Vn/uGO1aewdWf+GbNxndkrKiUQevBDduiBhAltj/jr7Q==", "58FE0A40607FAB46462538EBB2271695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4731b98-7ada-4a08-bc28-c4464a1ed7fc", "AQAAAAEAACcQAAAAEGfYBw7RWKh2QV4kyMtPLSwL9whEBfzEENnrZ7yEuORWJnHKXC+h5Mri8gSahh0Y1g==", "58FE0A40607FAB46462538EBB2271695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b369d06-55cc-423b-98f9-bd6ef31b50fe", "AQAAAAEAACcQAAAAEOgX0tqFxuf8IVYM8a6/ljZUDWJptZkD1Y9IsC4mmiraZ619z0NwFL+RF5CNsLHCAQ==", "58FE0A40607FAB46462538EBB2271695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8316a6cb-008e-409a-a4e9-6334e04ec983", "AQAAAAEAACcQAAAAEFsdJaWTDCpBt/nUtDu5FMgXHY/hKUkj0j+zhiCFe4/Hw2wETaCnemlWMYi/lbu8Fg==", "58FE0A40607FAB46462538EBB2271695" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5817e1fb-72ab-44de-8232-ff603dea16d0", "AQAAAAEAACcQAAAAENSy2PryaWf9V4zjZD8hhjhMfdxxeA//tM3HYw+OQUr/RwEMeNkn8sVvmk87QswRsQ==", "58FE0A40607FAB46462538EBB2271695" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                column: "BusinessOwnerId",
                value: new Guid("e826ff19-1946-4237-b266-e326cbead8ff"));

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("1f6f80e1-46f2-4bfa-8103-352bd182d6ff"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("2089de54-9f61-49a8-b1b8-443ce753f2a8"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("3aaaf681-d42c-480c-92d7-8bef2397ec3f"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("47467837-0c0e-4045-8bfb-24c85755fe14"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("9ad5fb7b-b407-4da4-a324-77b7724545d1"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("c1bc7809-f2ef-4f65-81c5-19e206244346"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 38, 50, 919, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 38, 50, 919, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 38, 50, 919, DateTimeKind.Utc).AddTicks(6449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("1f6f80e1-46f2-4bfa-8103-352bd182d6ff"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("2089de54-9f61-49a8-b1b8-443ce753f2a8"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3aaaf681-d42c-480c-92d7-8bef2397ec3f"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("47467837-0c0e-4045-8bfb-24c85755fe14"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("9ad5fb7b-b407-4da4-a324-77b7724545d1"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("c1bc7809-f2ef-4f65-81c5-19e206244346"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b2c7cf4-a2c6-4be8-a521-3e2684218528", "AQAAAAEAACcQAAAAELtMT/E6kXwEZDTt5plzdQAbC3tDzPUEC8Xf9R81Yu1LqedFdua6NdGtYvLeRg0qbA==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "221d1820-95ed-4a8a-b4bf-57253340d681", "AQAAAAEAACcQAAAAEGSy2uOBCo3yRuEI1NzjO1WhZf8t2z2Gc0vnvDnyQ60vFkHBYp4Zk3VhaqRftbxe0A==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ba0b192-d02f-4c34-88df-249dae079823", "AQAAAAEAACcQAAAAENZoxg5J7TPvFVfg0CNYN1/6A12c5vOto1F1OL7GZEJBiZpw6TGJskcni7TEUaKaGw==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b582c7a9-2008-4cae-8730-0b2c05421df5", "AQAAAAEAACcQAAAAEMIMiBBsZcV8e3VTR9v8I1pq1h+uW2VIkO0hah3sfhEr1dRidxBAILMNXUDV2cWH9g==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "831ae9c1-5d38-4504-9102-2550fe015621", "AQAAAAEAACcQAAAAEPXy1pbR22I8ovYGcE1NXPSnwWaA31v1+oUGTUXLHBCIv6JIWS79Ne3yubLaUhgJgQ==", "9B5729D72E2CAF7F3CB8A20B68191FCA" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"),
                column: "BusinessOwnerId",
                value: new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"));

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("08bdc115-86d5-4bd6-b588-c8601124c6bb"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("1ea6bf0c-0897-4a8e-a98f-7242b1fe9492"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("445829d3-3085-45fa-ba38-818b30f9a9ec"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("67948288-9507-46cd-a6f3-fcd14221f7bd"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("707b4a12-a932-4779-97c2-98c4b431e8b1"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("f639cbe8-22cb-4d83-be14-659e35c8259e"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 36, 41, 185, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 36, 41, 185, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 5, 21, 36, 41, 185, DateTimeKind.Utc).AddTicks(8596));
        }
    }
}
