using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class SeedReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("005caeaa-5262-43d7-9b2b-c30eaa46b6c8"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5f2516ab-1013-47c9-a521-1dc868780d64"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("841ded07-9c44-4d5b-9f96-9d3c3a39a8c4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e56514-6bad-48bc-9529-54e294a27ce3", "AQAAAAEAACcQAAAAEFpM8m9Lc0PbouixssuKq5dyGstnTRFo9PResMYRBzCctJZK7MOptQgcxQVcrtF/gg==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f972e454-805a-4c16-992b-569def512a2f", "AQAAAAEAACcQAAAAEGHpOdP+91yORYhiFujQA8K1qowxRnfG+yW/JzFtgZb3/ZO53iS0Es7+/2DdSDKg+g==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ee465d-3918-45bc-84a3-71649f06b7cc", "AQAAAAEAACcQAAAAEEb2HJbsLlg2vhHO7SY/s1+N+Pd+3k3h2osl3R2aubAD/zX4Xmb7L8/5o9TS57neYg==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc0e856-2411-419b-b8d2-8c4cb30e428d", "AQAAAAEAACcQAAAAEBQx5mIjEaVgmirYSRLb60phTryFWFlY5+lve9yE/i6BfCsMlWcONzTZcZ+jDCVklg==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ac31b6a-be17-4346-9c76-b833b5eac984", "AQAAAAEAACcQAAAAEFqmxayqAFuJZLvJwmZAg876uT8KQ4uuS89dX5fro5yuZEEEEhz7OvorMYkrz/3ioQ==", "0D1C82E31145A2FC088783CFA54F0D88" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[] { new Guid("96f83ecc-8818-42a1-a2b6-d9871d5871c6"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "IsActive", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("a9b00a38-d114-4ca8-ace9-2e20f6b798a5"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("abe0f7eb-bec3-4bd0-8826-629358d10483"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", true, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "Notes", "ReservationDate", "Status", "UserId" },
                values: new object[] { new Guid("bb49a06d-fbd1-4fdd-a7d4-d309445c59f8"), new Guid("4222168e-c018-418e-812f-f8d41b322522"), "Looking for delicious pastries", new DateTime(2024, 4, 12, 20, 47, 0, 288, DateTimeKind.Utc).AddTicks(3816), "Completed", new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BusinessId", "Content", "Rating", "ReviewerId", "Subject", "UserLocation" },
                values: new object[,]
                {
                    { new Guid("1b49d0aa-f195-4896-b1b9-8f852cf337f3"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), "The food was incredible, best chefs in the prefecture", 5.0, new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"), "Great food!", null },
                    { new Guid("4dacbd5b-f210-43bd-b998-4ea74609f89d"), new Guid("4222168e-c018-418e-812f-f8d41b322522"), "It had everything I was looking for but there were squished fruits on the floor", 4.0, new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"), "Nice place but dirty.", null },
                    { new Guid("c24c77af-568c-4021-85ac-7caca0fd0d84"), new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), "The coffee was amazing, I had a very pleasant coffee experience", 5.0, new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"), "Great coffee!", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("96f83ecc-8818-42a1-a2b6-d9871d5871c6"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("a9b00a38-d114-4ca8-ace9-2e20f6b798a5"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("abe0f7eb-bec3-4bd0-8826-629358d10483"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bb49a06d-fbd1-4fdd-a7d4-d309445c59f8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1b49d0aa-f195-4896-b1b9-8f852cf337f3"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4dacbd5b-f210-43bd-b998-4ea74609f89d"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c24c77af-568c-4021-85ac-7caca0fd0d84"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015ef6f8-895f-437e-bd81-919347045668", "AQAAAAEAACcQAAAAEKe0obrnGnI17OBfb5w6j4l/eUazABQqfq/eSxbSL/5DK/yVuUfTsu1LmK4SV5O1GA==", "8DE9BFF76769660A48823D891400A8E1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "030f2edc-c525-4abf-87bf-8e59968e68fd", "AQAAAAEAACcQAAAAEFsx1jfGt5ydTYlXRZyHPouXYh+I4yJvBNdfygHZ3wbUcBWLJ6ThyRWh8Xe8Dq/VRQ==", "8DE9BFF76769660A48823D891400A8E1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7efd044d-1c61-4e5a-aebe-5e268fa6ffae", "AQAAAAEAACcQAAAAEEy1hzbzHrEP1TRUs9+mYAGuYuVybLdmnIFVea5FQn7D4+CRC5cjLleK7V0OnT/8Rg==", "8DE9BFF76769660A48823D891400A8E1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba04e225-796e-4a9b-9558-ce0e87b7db06", "AQAAAAEAACcQAAAAEI3hnXfNaIYXHFweQ9ZdzfWQhdSiRdq6CmOANa2e76Tz6Lm94SvGmsoKTK1O2E74dA==", "8DE9BFF76769660A48823D891400A8E1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ded2ed0c-9d4f-4d1d-9be1-a0b183548bfc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "111c8203-1315-421e-a34f-97903f9f78b8", "AQAAAAEAACcQAAAAEGAYbhLrJ2/SZBny3sLeES0x00DrIuFClOSOG40jl+nNbMdzZIT72TCOagR+d0eV3A==", "8DE9BFF76769660A48823D891400A8E1" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "IsActive", "IsApproved", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("005caeaa-5262-43d7-9b2b-c30eaa46b6c8"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", false, true, "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("5f2516ab-1013-47c9-a521-1dc868780d64"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("841ded07-9c44-4d5b-9f96-9d3c3a39a8c4"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", true, false, "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("11154b62-2abd-404a-827e-f4e69ad94678"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2f014787-c27c-4406-9b55-4dbcef08eeff"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("cd6698f0-7d34-4b6c-b9d2-76b1335af34f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 12, 20, 38, 23, 511, DateTimeKind.Utc).AddTicks(9348));
        }
    }
}
