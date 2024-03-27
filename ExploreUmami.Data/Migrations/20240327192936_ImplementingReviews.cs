using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class ImplementingReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Businesses_BusinessId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BusinessId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("10a63976-d018-4e76-bb0d-5fb2bef31f4e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3c3e6a68-e749-4ede-a918-f4fab6715385"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("45400dcb-0dd9-4fa8-9c29-550be9b5036a"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("4dadc4e2-43e0-4e5f-9cec-639cfbd35999"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8565f995-a200-46b7-bc84-67c2fbc93b21"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("afc00a63-3a15-4c79-a7b0-08c3d68a50c7"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("ca480780-dca2-4527-b54a-054da1477393"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("edcc329d-a02c-4afe-b045-50772f6fcae0"));

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "363d18ea-f183-48b6-96f7-81734acc0747", "AQAAAAEAACcQAAAAEM98Ms0jZ7pVQUhw71QFOEvY9gIyNiDt+S3Y4dWDGObbWfvmwmfJxp+ise+NLoqdrw==", "F978E4929842DBD851D0D5E212264BDD" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07f69d7b-8bb5-4f53-b82b-814af2aa7fae", "AQAAAAEAACcQAAAAECjA9fl693oR6m2Zy0YUfRDYQV9//+Ie5f9KucQIY3iwKKCzAygYv9CmiPuoXylt7w==", "F978E4929842DBD851D0D5E212264BDD" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f8e0761-af26-423a-ab31-810baede1c73", "AQAAAAEAACcQAAAAEIyaNuM+HiTWnyKK43T6ILAyUJqGLtePz1UVSWk7rp1/D77mn79nSj6YlVgpXo0mfA==", "F978E4929842DBD851D0D5E212264BDD" });

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                column: "PhoneNumber",
                value: "12-3456-7890");

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                column: "PhoneNumber",
                value: "12-3456-7890");

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("3fc800ef-9837-4ac9-8945-a9a2dc8c0614"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "12-3456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("620bd39e-f272-4819-bcaf-dc7871be5f1d"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "12-3456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("65a232dd-633b-4f0b-bc6b-f7f1fb8981ea"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"), "123 Main Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 1, "A place where you can eat food", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("7fbc53b5-c5e0-492a-b3ac-170ad5ae66ef"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "12-3456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"), "456 Elm Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 2, "A place where you can drink coffee", "https://dummyimage.com/400x200", "12-3456-7890", 2, "Cafe", null, "https://www.cafe.com" },
                    { new Guid("d6749d45-a7a3-43f9-ba9f-87af0d6cb41a"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "12-3456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("fedcf5f0-8cfd-40a2-9e18-a8c3031b0fc3"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "12-3456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BusinessId_ReviewerId",
                table: "Reviews",
                columns: new[] { "BusinessId", "ReviewerId" },
                unique: true,
                filter: "[ReviewerId] IS NOT NULL");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_ReviewerId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Businesses_BusinessId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BusinessId_ReviewerId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3fc800ef-9837-4ac9-8945-a9a2dc8c0614"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("620bd39e-f272-4819-bcaf-dc7871be5f1d"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("65a232dd-633b-4f0b-bc6b-f7f1fb8981ea"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6eec121f-f98e-4008-9551-2d8a4b38da98"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("7fbc53b5-c5e0-492a-b3ac-170ad5ae66ef"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8f87f835-3deb-43b4-aa01-852c5d287984"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("d6749d45-a7a3-43f9-ba9f-87af0d6cb41a"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("fedcf5f0-8cfd-40a2-9e18-a8c3031b0fc3"));

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ae80037-f648-442e-a309-4b94a3d1315c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "309b1121-002e-422d-9115-8b54bb0b93ef", "AQAAAAEAACcQAAAAEG8cvbIwuq55S0FvLcT7e+U2tMq7dmwqbD9FbQanGUNO0FXkk17p4MxHGwkpVn8gZg==", "6C94B3E70009FE549F746E84FE82B7A4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ab13755f-eaef-4fb4-86a1-9c4609641c83"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28e6eb1f-faee-42af-9d90-475d062b2583", "AQAAAAEAACcQAAAAEHaejeRdRkGCm4zQDS2FeuZ/wmDPqc928eZJBl7+t/SMxFYge6xOO5yir+q1QNs0tg==", "6C94B3E70009FE549F746E84FE82B7A4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b43c3753-de4e-4417-b2ad-1c029c7b9795"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de669ae7-6236-44e1-8243-8e82accfda43", "AQAAAAEAACcQAAAAEJ/01P1j7BXAwRAMolOEyVKdH1vy1Gi4T6wBhGHa+QdHqAiSno9NtOgJUD8Y6lpiwQ==", "6C94B3E70009FE549F746E84FE82B7A4" });

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"),
                column: "PhoneNumber",
                value: "123-456-7890");

            migrationBuilder.UpdateData(
                table: "BusinessOwners",
                keyColumn: "Id",
                keyValue: new Guid("e826ff19-1946-4237-b266-e326cbead8ff"),
                column: "PhoneNumber",
                value: "123-456-7890");

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("10a63976-d018-4e76-bb0d-5fb2bef31f4e"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "123-456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("3c3e6a68-e749-4ede-a918-f4fab6715385"), "123 Main Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 1, "A place where you can eat food", "https://dummyimage.com/400x200", "123-456-7890", 1, "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("45400dcb-0dd9-4fa8-9c29-550be9b5036a"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "123-456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("4dadc4e2-43e0-4e5f-9cec-639cfbd35999"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "123-456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("8565f995-a200-46b7-bc84-67c2fbc93b21"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "123-456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("afc00a63-3a15-4c79-a7b0-08c3d68a50c7"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "123-456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("ca480780-dca2-4527-b54a-054da1477393"), "456 Elm Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 2, "A place where you can drink coffee", "https://dummyimage.com/400x200", "123-456-7890", 2, "Cafe", null, "https://www.cafe.com" },
                    { new Guid("edcc329d-a02c-4afe-b045-50772f6fcae0"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "123-456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BusinessId",
                table: "Reviews",
                column: "BusinessId");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
