using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class RemoveUserVisitIdFromReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVisits_Reservations_ReservationId",
                table: "UserVisits");

            migrationBuilder.DropIndex(
                name: "IX_UserVisits_ReservationId",
                table: "UserVisits");

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("741a4801-c894-4c5e-882f-d8c836cab5e9"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("806ec82d-8dc8-41de-a931-db83908fbe4d"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8caae1b6-53af-4c6b-82ca-71acbcaa302d"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8d8bd86c-b010-4ffb-bed6-3769430090fb"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("96254630-e94b-44e5-994f-6249793798f9"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("f68f2054-7a02-4108-b132-e2dfaa1934cc"));

            migrationBuilder.DropColumn(
                name: "UserVisitId",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "UserVisits",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Reservations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c13e7a-e552-42c3-a323-ba9dbb21b723", "AQAAAAEAACcQAAAAEHx18GjhYrHQZ62V+X3dIukzd17YJAWcterwg5PrW8PzUaG1p+CgM7Ot3s+ZTJA3MA==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e69009e-7406-4884-8e78-38f2ea6de7d5", "AQAAAAEAACcQAAAAEHcriWHudz9jt+wYn78rDq5eoB+2zMKTy4KvGyufHskT6GcJhzCedT+07gXSj5g1Dw==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78fb8f12-9ede-480b-a799-c1c85b6cfa78", "AQAAAAEAACcQAAAAEPDDlq9IsYya1tf9GTRHJlKsa/bMhKlJZH5aYm2tlV4MbhrbNv0lNQvwURxLzWz3eg==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "721dca27-9976-40c8-96d8-7528d62780b2", "AQAAAAEAACcQAAAAELSA2EmOQZGWMmekcvr4oe9WDQdoFngMCXP8mAZ2W8YmwPVLIyYYylBO93eJXJ1N/A==", "786BCC397C88D9726197282B8E678CC6" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("24ccb77e-8672-478d-95a5-a2f61f43fbc3"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("27f80c85-603e-4121-a316-21e6cd02de4d"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("527675f9-9d82-4486-83be-1bea7d1ed73c"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("8ff860e6-86cf-4d0a-a48a-5465916a9590"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("b1eb5407-4134-40ce-a1ec-1c811780635e"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("cf5039e5-8443-46ae-a80a-3ed8bc655f36"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 16, 14, 29, 188, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 16, 14, 29, 188, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                column: "ReservationDate",
                value: new DateTime(2024, 4, 2, 16, 14, 29, 188, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.CreateIndex(
                name: "IX_UserVisits_ReservationId",
                table: "UserVisits",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserVisits_Reservations_ReservationId",
                table: "UserVisits",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVisits_Reservations_ReservationId",
                table: "UserVisits");

            migrationBuilder.DropIndex(
                name: "IX_UserVisits_ReservationId",
                table: "UserVisits");

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("24ccb77e-8672-478d-95a5-a2f61f43fbc3"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("27f80c85-603e-4121-a316-21e6cd02de4d"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("527675f9-9d82-4486-83be-1bea7d1ed73c"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8ff860e6-86cf-4d0a-a48a-5465916a9590"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("b1eb5407-4134-40ce-a1ec-1c811780635e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("cf5039e5-8443-46ae-a80a-3ed8bc655f36"));

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "UserVisits");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Reservations");

            migrationBuilder.AddColumn<Guid>(
                name: "UserVisitId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb6a2b3d-65a3-468e-a690-3ed14d6e0b3f", "AQAAAAEAACcQAAAAEJQzzOEpb/3pGmlXAhHCRFbVwxZkmmDN8mZUk/MPF497BfCMNqwfjpOCsKuetY98pg==", "34D1D89F2574512BF056629BD5AC756C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "190a9a1f-964b-491f-be32-bc3e1310ee80", "AQAAAAEAACcQAAAAENsgis3dIi/RHSfYODm1hKHrIK6zvsUQo9I5fHlm36Xu07xQKCZXz3IDnHuvqz8Ndg==", "34D1D89F2574512BF056629BD5AC756C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d580a8f0-87b0-4906-bd39-6fdc7da210b7", "AQAAAAEAACcQAAAAECici/LsPhG2DFyf0ZrsIrOEiMtL2ZbFP6iK/BpDEsL0hnPKMwUHlq56/J8pj1N/Lw==", "34D1D89F2574512BF056629BD5AC756C" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "821c5827-1cc1-4c5a-ac48-7d672eee00c8", "AQAAAAEAACcQAAAAEGZkWjgYJLEEpf1yNXYykg+Q42G4sH73AkOgq+L0SHY6v5j1efA/38pVramIEsYV+w==", "34D1D89F2574512BF056629BD5AC756C" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("741a4801-c894-4c5e-882f-d8c836cab5e9"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("806ec82d-8dc8-41de-a931-db83908fbe4d"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("8caae1b6-53af-4c6b-82ca-71acbcaa302d"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("8d8bd86c-b010-4ffb-bed6-3769430090fb"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("96254630-e94b-44e5-994f-6249793798f9"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("f68f2054-7a02-4108-b132-e2dfaa1934cc"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"),
                columns: new[] { "ReservationDate", "UserVisitId" },
                values: new object[] { new DateTime(2024, 4, 1, 20, 24, 34, 393, DateTimeKind.Utc).AddTicks(2998), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1847") });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"),
                columns: new[] { "ReservationDate", "UserVisitId" },
                values: new object[] { new DateTime(2024, 4, 1, 20, 24, 34, 393, DateTimeKind.Utc).AddTicks(2987), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c85") });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"),
                columns: new[] { "ReservationDate", "UserVisitId" },
                values: new object[] { new DateTime(2024, 4, 1, 20, 24, 34, 393, DateTimeKind.Utc).AddTicks(3002), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c84") });

            migrationBuilder.CreateIndex(
                name: "IX_UserVisits_ReservationId",
                table: "UserVisits",
                column: "ReservationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserVisits_Reservations_ReservationId",
                table: "UserVisits",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
