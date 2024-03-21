using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExploreUmami.Data.Migrations
{
    public partial class SeedingBusinessesCategoriesPrefectures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Restaurant" },
                    { 2, "Cafe" },
                    { 3, "Bar" },
                    { 4, "Bakery" },
                    { 5, "Fast Food" },
                    { 6, "Food Truck" },
                    { 7, "Dessert Shop" },
                    { 8, "Grocery Store" },
                    { 9, "Market" },
                    { 10, "Food Stand" }
                });

            migrationBuilder.InsertData(
                table: "Prefectures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hokkaido" },
                    { 2, "Aomori" },
                    { 3, "Iwate" },
                    { 4, "Miyagi" },
                    { 5, "Akita" },
                    { 6, "Yamagata" },
                    { 7, "Fukushima" },
                    { 8, "Ibaraki" },
                    { 9, "Tochigi" },
                    { 10, "Gunma" },
                    { 11, "Saitama" },
                    { 12, "Chiba" },
                    { 13, "Tokyo" },
                    { 14, "Kanagawa" },
                    { 15, "Niigata" },
                    { 16, "Toyama" },
                    { 17, "Ishikawa" },
                    { 18, "Fukui" },
                    { 19, "Yamanashi" },
                    { 20, "Nagano" },
                    { 21, "Gifu" },
                    { 22, "Shizuoka" },
                    { 23, "Aichi" },
                    { 24, "Mie" },
                    { 25, "Shiga" },
                    { 26, "Kyoto" },
                    { 27, "Osaka" },
                    { 28, "Hyogo" },
                    { 29, "Nara" },
                    { 30, "Wakayama" },
                    { 31, "Tottori" },
                    { 32, "Shimane" }
                });

            migrationBuilder.InsertData(
                table: "Prefectures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 33, "Okayama" },
                    { 34, "Hiroshima" },
                    { 35, "Yamaguchi" },
                    { 36, "Tokushima" },
                    { 37, "Kagawa" },
                    { 38, "Ehime" },
                    { 39, "Kochi" },
                    { 40, "Fukuoka" },
                    { 41, "Saga" },
                    { 42, "Nagasaki" },
                    { 43, "Kumamoto" },
                    { 44, "Oita" },
                    { 45, "Miyazaki" },
                    { 46, "Kagoshima" },
                    { 47, "Okinawa" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address", "BusinessOwnerId", "CategoryId", "Description", "ImageURL", "PhoneNumber", "PrefectureId", "Title", "VisitorId", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("0d496894-8eda-47d8-804d-4ea5995736e5"), "456 Elm Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 2, "A place where you can drink coffee", "https://dummyimage.com/400x200", "123-456-7890", 2, "Cafe", null, "https://www.cafe.com" },
                    { new Guid("1fbdb890-0e0b-4f0e-8db5-4d900fdbbbaf"), "1314 Cedar Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 5, "A place where you can eat food quickly", "https://dummyimage.com/400x200", "123-456-7890", 5, "Fast Food", null, "https://www.fastfood.com" },
                    { new Guid("464473d3-5e31-4c0d-a476-ddb37f2edf07"), "123 Main Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 1, "A place where you can eat food", "https://dummyimage.com/400x200", "123-456-7890", 1, "Restaurant", null, "https://www.restaurant.com" },
                    { new Guid("8382f044-01c3-4330-a07d-d2c7d540ff68"), "1920 Cherry Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 8, "A place where you can buy food", "https://dummyimage.com/400x200", "123-456-7890", 1, "Grocery Store", null, "https://www.grocerystore.com" },
                    { new Guid("922a6a8d-3be2-442b-9af6-b07b41af536d"), "1012 Pine Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 4, "A place where you can buy bread", "https://dummyimage.com/400x200", "123-456-7890", 4, "Bakery", null, "https://www.bakery.com" },
                    { new Guid("9bce1175-0b12-4c75-9851-17d1a69f2f10"), "789 Oak Street", new Guid("c805ddb6-bcf7-47a3-8744-3ec84036caa0"), 3, "A place where you can drink alcohol", "https://dummyimage.com/400x200", "123-456-7890", 3, "Bar", null, "https://www.bar.com" },
                    { new Guid("bf97e3c5-5e74-4292-a0da-b64200350522"), "1516 Maple Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 6, "A place where you can eat food on the go", "https://dummyimage.com/400x200", "123-456-7890", 6, "Food Truck", null, "https://www.foodtruck.com" },
                    { new Guid("f5417133-5ed7-4847-87d1-837b3473be55"), "1718 Walnut Street", new Guid("e826ff19-1946-4237-b266-e326cbead8ff"), 7, "A place where you can eat dessert", "https://dummyimage.com/400x200", "123-456-7890", 1, "Dessert Shop", null, "https://www.dessertshop.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("0d496894-8eda-47d8-804d-4ea5995736e5"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("1fbdb890-0e0b-4f0e-8db5-4d900fdbbbaf"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("464473d3-5e31-4c0d-a476-ddb37f2edf07"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("8382f044-01c3-4330-a07d-d2c7d540ff68"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("922a6a8d-3be2-442b-9af6-b07b41af536d"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("9bce1175-0b12-4c75-9851-17d1a69f2f10"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("bf97e3c5-5e74-4292-a0da-b64200350522"));

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "Id",
                keyValue: new Guid("f5417133-5ed7-4847-87d1-837b3473be55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 47);

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

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Prefectures",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
