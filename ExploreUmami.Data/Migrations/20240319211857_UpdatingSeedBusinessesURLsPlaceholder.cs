using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class UpdatingSeedBusinessesURLsPlaceholder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("30090888-c1a0-45fe-8779-c66a29f24ea9"), "456 Elm Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 2, "A place where you can drink coffee", "https://dummyimage.com/400x200", "123-456-7890", "Cafe", null, "https://www.cafe.com" },
                    { new Guid("3303573c-dad1-4893-8c94-83b84fd6231b"), "123 Main Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 1, "A place where you can eat food", "https://dummyimage.com/400x200", "123-456-7890", "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("3598fb65-dafe-40d7-a353-b2ca9112418f"), "1718 Walnut Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "123-456-7890", "Dessert Shop", null, "https://www.dessertshop.com" },
                    { new Guid("5192954b-ad0d-47d4-927d-b8752bd2bfc3"), "1314 Cedar Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "123-456-7890", "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("6a1e9105-2d24-4653-aca3-44c6deaf59c8"), "1516 Maple Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "123-456-7890", "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("799c77cd-8dc7-426f-ac4a-e6a1d48f9913"), "789 Oak Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "123-456-7890", "Bar", null, "https://www.bar.com" },
                    { new Guid("aa717559-22b4-438a-b95f-23457cb2d33e"), "1012 Pine Street", new Guid("28bec72c-a405-4303-9f92-8b84c161b93e"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "123-456-7890", "Bakery", null, "https://www.bakery.com" },
                    { new Guid("e685e669-cc44-457d-99d9-e12fa7db2173"), "1920 Cherry Street", new Guid("6d8562f6-6ec4-4c21-8b7a-57670c10a292"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "123-456-7890", "Grocery Store", null, "https://www.grocerystore.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("30090888-c1a0-45fe-8779-c66a29f24ea9"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3303573c-dad1-4893-8c94-83b84fd6231b"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("3598fb65-dafe-40d7-a353-b2ca9112418f"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("5192954b-ad0d-47d4-927d-b8752bd2bfc3"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("6a1e9105-2d24-4653-aca3-44c6deaf59c8"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("799c77cd-8dc7-426f-ac4a-e6a1d48f9913"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("aa717559-22b4-438a-b95f-23457cb2d33e"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("e685e669-cc44-457d-99d9-e12fa7db2173"));

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
    }
}
