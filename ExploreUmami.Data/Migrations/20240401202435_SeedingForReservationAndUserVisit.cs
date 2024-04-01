using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class SeedingForReservationAndUserVisit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("04e9e63e-73b5-4e65-b2db-c0c72240654b"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3e9a5581-00b1-49aa-817d-19bc34c21f60"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("4809bf2e-2101-4bd9-9ae3-931805032c51"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("681b003d-30cb-4743-b6ff-09e3b037e9c4"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("748f9c8b-2c3e-40a4-8980-39b55106aa18"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("cc33e3cf-7d2e-4978-8a24-8731eefa2314"));

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
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("741a4801-c894-4c5e-882f-d8c836cab5e9"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("806ec82d-8dc8-41de-a931-db83908fbe4d"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("8caae1b6-53af-4c6b-82ca-71acbcaa302d"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("8d8bd86c-b010-4ffb-bed6-3769430090fb"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("96254630-e94b-44e5-994f-6249793798f9"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("f68f2054-7a02-4108-b132-e2dfaa1934cc"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "ReservationDate", "Status", "UserId", "UserVisitId" },
                values: new object[] { new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), new DateTime(2024, 4, 1, 20, 24, 34, 393, DateTimeKind.Utc).AddTicks(2998), "Confirmed", new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1847") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "ReservationDate", "UserId", "UserVisitId" },
                values: new object[] { new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), new DateTime(2024, 4, 1, 20, 24, 34, 393, DateTimeKind.Utc).AddTicks(2987), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c85") });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BusinessId", "ReservationDate", "Status", "UserId", "UserVisitId" },
                values: new object[] { new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"), new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), new DateTime(2024, 4, 1, 20, 24, 34, 393, DateTimeKind.Utc).AddTicks(3002), "Completed", new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c84") });

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "ReservationId", "UserId" },
                values: new object[] { new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1847"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"), new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846") });

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "ReservationId", "UserId" },
                values: new object[] { new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c84"), new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") });

            migrationBuilder.InsertData(
                table: "UserVisits",
                columns: new[] { "Id", "BusinessId", "ReservationId", "UserId" },
                values: new object[] { new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c85"), new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"), new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "UserVisits",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1847"));

            migrationBuilder.DeleteData(
                table: "UserVisits",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c84"));

            migrationBuilder.DeleteData(
                table: "UserVisits",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c85"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("266a74bb-e01c-4bfc-86a6-d5aaee18574f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ccbf170d-f0a7-4dbf-8bdf-6f101548f833"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d3d3d3d3-3d3d-3d3d-3d3d-3d3d3d3d3d3d"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c9981d8-f025-4fec-ac61-3b38632243ec", "AQAAAAEAACcQAAAAEFksQDoMNImHnp2pwAZ5PORz3xjXfP/aE7y0gi0p1RxJaBfgrHOjRcRRQFTAvbce8Q==", "EFC95224D8324D8EC525991DD4C31C51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f5d89a1-dda8-4400-bf47-690ae86f1846"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "418f3edf-8ddc-4107-b297-85ffec6fd183", "AQAAAAEAACcQAAAAEM73GXGrNMcyK5VRWgWEQZ1vjaKtGVBJOwnTUAjhP7+tTct3UjV3VhpEhzLWZMGjAw==", "EFC95224D8324D8EC525991DD4C31C51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "891bbd22-2e0d-4eeb-8ee6-2045a725a208", "AQAAAAEAACcQAAAAEFbiP7Bq9TY3tXEZlvUKM+ESN96rRmOA+EK8EFp/oySVKuP6mytQGIJDrvHBs8fw/w==", "EFC95224D8324D8EC525991DD4C31C51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "397f0169-42bb-44d6-bdd2-801c22e6f9eb", "AQAAAAEAACcQAAAAEM287pSO/71F5X4Ef1pPlMoV8QsMBMFsW5hSVt1ASDZBoxASPt12V1yIjvaCE6wN9A==", "EFC95224D8324D8EC525991DD4C31C51" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteUrl" },
                values: new object[,]
                {
                    { new Guid("04e9e63e-73b5-4e65-b2db-c0c72240654b"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("3e9a5581-00b1-49aa-817d-19bc34c21f60"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("4809bf2e-2101-4bd9-9ae3-931805032c51"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("681b003d-30cb-4743-b6ff-09e3b037e9c4"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("748f9c8b-2c3e-40a4-8980-39b55106aa18"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("cc33e3cf-7d2e-4978-8a24-8731eefa2314"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" }
                });
        }
    }
}
