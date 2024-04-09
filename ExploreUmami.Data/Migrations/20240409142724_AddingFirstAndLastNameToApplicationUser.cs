using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class AddingFirstAndLastNameToApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_BusinessOwners_BusinessOwnerId",
                table: "Businesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Categories_CategoryId",
                table: "Businesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Prefectures_PrefectureId",
                table: "Businesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Businesses_BusinessId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Businesses_BusinessId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UserVisits_AspNetUsers_UserId",
                table: "UserVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_UserVisits_Businesses_BusinessId",
                table: "UserVisits");

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

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Reviews",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "John");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Doe");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfadd943-2633-4d89-a3df-d2c0953032ef", "AQAAAAEAACcQAAAAEFhaeMWcmzHxOQvQpGjgoCXJBuPCOMIS6Zd6NKLoojtIy5meJ6JSRfXTw7peFlZnrQ==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "626a5563-59de-4b2e-9632-1027bcb8f16c", "AQAAAAEAACcQAAAAEKRtRHQmLmk1EG74ZGoZtTdEOH4a37AJXthKQyBi5ocFMQn5Q871NwZTnS3WidU7Hg==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7a121a-089b-4c2f-a71b-3c88ce0ecfef", "AQAAAAEAACcQAAAAEP4ophmvWOoUkSPLqgMz3MFMQvypb81o5v4NmgHchd4q+huojbLTICpjUof7Zv/l3A==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c113f1d8-a909-4e5f-9f6f-93912abd1884", "AQAAAAEAACcQAAAAEH7907lmRF3LvlQzrh5Dhl8g2UIOnpEmeb1RPoUx2awrGqjQE7KQJufcmVI5xHePcQ==", "D1CE9FF340BCF09F3747FFE6A7D7D67E" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("1a87341d-a8fd-4dc4-ae30-b03b63b578ed"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("24a0ea6c-38ee-43ec-8a66-592cb8e9a93e"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("77b7e206-452f-4fff-9fb6-9f490da3b625"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("c25f4f31-a2cb-4f19-acf8-2741c9fee042"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("dd3d137e-624f-473e-83ce-a6df0e043000"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("e6cf9d79-d9d0-4977-810d-439ac1aeb481"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
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

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_BusinessOwners_BusinessOwnerId",
                table: "Businesses",
                column: "BusinessOwnerId",
                principalTable: "BusinessOwners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_Categories_CategoryId",
                table: "Businesses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_Prefectures_PrefectureId",
                table: "Businesses",
                column: "PrefectureId",
                principalTable: "Prefectures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Businesses_BusinessId",
                table: "Reservations",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews",
                column: "ReviewerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Businesses_BusinessId",
                table: "Reviews",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserVisits_AspNetUsers_UserId",
                table: "UserVisits",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserVisits_Businesses_BusinessId",
                table: "UserVisits",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_BusinessOwners_BusinessOwnerId",
                table: "Businesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Categories_CategoryId",
                table: "Businesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Businesses_Prefectures_PrefectureId",
                table: "Businesses");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Businesses_BusinessId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Businesses_BusinessId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_UserVisits_AspNetUsers_UserId",
                table: "UserVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_UserVisits_Businesses_BusinessId",
                table: "UserVisits");

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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Reviews",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

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

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("1f6f80e1-46f2-4bfa-8103-352bd182d6ff"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("2089de54-9f61-49a8-b1b8-443ce753f2a8"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("3aaaf681-d42c-480c-92d7-8bef2397ec3f"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("47467837-0c0e-4045-8bfb-24c85755fe14"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("9ad5fb7b-b407-4da4-a324-77b7724545d1"), "1314 Cedar Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("c1bc7809-f2ef-4f65-81c5-19e206244346"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" }
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

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_BusinessOwners_BusinessOwnerId",
                table: "Businesses",
                column: "BusinessOwnerId",
                principalTable: "BusinessOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_Categories_CategoryId",
                table: "Businesses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Businesses_Prefectures_PrefectureId",
                table: "Businesses",
                column: "PrefectureId",
                principalTable: "Prefectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Businesses_BusinessId",
                table: "Reservations",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews",
                column: "ReviewerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Businesses_BusinessId",
                table: "Reviews",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserVisits_AspNetUsers_UserId",
                table: "UserVisits",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserVisits_Businesses_BusinessId",
                table: "UserVisits",
                column: "BusinessId",
                principalTable: "Businesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
