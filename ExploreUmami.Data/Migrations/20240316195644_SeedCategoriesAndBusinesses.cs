using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class SeedCategoriesAndBusinesses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BusinessId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Restaurant" },
                    { 2, null, "Cafe" },
                    { 3, null, "Bar" },
                    { 4, null, "Bakery" },
                    { 5, null, "Fast Food" },
                    { 6, null, "Food Truck" },
                    { 7, null, "Dessert Shop" },
                    { 8, null, "Grocery Store" },
                    { 9, null, "Market" },
                    { 10, null, "Food Stand" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("22e63a65-2d88-4090-a6c6-f51d421854fc"), "456 Elm Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 2, "A place where you can drink coffee", "https://getimg.ai/img/img-OysDjiqns60NDYgiCOidV", "123-456-7890", "Cafe", null, "https://www.cafe.com" },
                    { new Guid("439e6946-75c4-4f45-9840-1bc268f98e49"), "123 Main Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 1, "A place where you can eat food", "https://getimg.ai/img/img-GzEi9e3A35BWRRAs6efuR", "123-456-7890", "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("45ab573e-e84e-4466-8c2d-cdc707430134"), "1314 Cedar Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 5, "A place where you can eat food quickly", "https://getimg.ai/img/img-PvULGwtcwlWZ5694nHPFC", "123-456-7890", "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("5d7f3f6c-0c61-42fa-a554-81be03917c4e"), "1920 Cherry Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 8, "A place where you can buy food", "https://getimg.ai/img/img-jmK84Ff5DOP68jbtpJJNb", "123-456-7890", "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("8b30853f-49a8-41a7-b995-50e14657430b"), "1718 Walnut Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 7, "A place where you can eat dessert", "https://getimg.ai/img/img-tqk28rgRktCvKB33e4FmM", "123-456-7890", "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("a61cce1f-06a5-4fa8-822c-3a67acdca9a5"), "1012 Pine Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 4, "A place where you can buy bread", "https://getimg.ai/img/img-2PqN4NLYb5UFxWb9gFMuZ", "123-456-7890", "Bakery", null, "https://www.bakery.com" },
                    { new Guid("bea1f022-d9bf-4a94-b219-0104ff363116"), "1516 Maple Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 6, "A place where you can eat food on the go", "https://getimg.ai/img/img-iwKO3ZYj0tUW9NZ4RbF3Q", "123-456-7890", "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("cff0007d-56f6-4720-83b4-770c903f783f"), "789 Oak Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 3, "A place where you can drink alcohol", "https://getimg.ai/img/img-r3saoofM9CrvQfG1foV2P", "123-456-7890", "Bar", null, "https://www.bar.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("22e63a65-2d88-4090-a6c6-f51d421854fc"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("439e6946-75c4-4f45-9840-1bc268f98e49"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("45ab573e-e84e-4466-8c2d-cdc707430134"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5d7f3f6c-0c61-42fa-a554-81be03917c4e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8b30853f-49a8-41a7-b995-50e14657430b"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("a61cce1f-06a5-4fa8-822c-3a67acdca9a5"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("bea1f022-d9bf-4a94-b219-0104ff363116"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("cff0007d-56f6-4720-83b4-770c903f783f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
