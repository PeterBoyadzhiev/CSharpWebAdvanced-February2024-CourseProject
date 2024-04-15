using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ExploreUmami.Data.Configurations
{
    [ExcludeFromCodeCoverage]
    public class PrefectureEntityConfiguration : IEntityTypeConfiguration<Prefecture>
    {
        public void Configure(EntityTypeBuilder<Prefecture> builder)
        {
            builder.HasData(GeneratePrefectures());
        }

        private Prefecture[] GeneratePrefectures()
        {

            Prefecture[] prefectures = new Prefecture[]
            {
                new Prefecture { Id = 1, Name = "Hokkaido" },
                new Prefecture { Id = 2, Name = "Aomori" },
                new Prefecture { Id = 3, Name = "Iwate" },
                new Prefecture { Id = 4, Name = "Miyagi" },
                new Prefecture { Id = 5, Name = "Akita" },
                new Prefecture { Id = 6, Name = "Yamagata" },
                new Prefecture { Id = 7, Name = "Fukushima" },
                new Prefecture { Id = 8, Name = "Ibaraki" },
                new Prefecture { Id = 9, Name = "Tochigi" },
                new Prefecture { Id = 10, Name = "Gunma" },
                new Prefecture { Id = 11, Name = "Saitama" },
                new Prefecture { Id = 12, Name = "Chiba" },
                new Prefecture { Id = 13, Name = "Tokyo" },
                new Prefecture { Id = 14, Name = "Kanagawa" },
                new Prefecture { Id = 15, Name = "Niigata" },
                new Prefecture { Id = 16, Name = "Toyama" },
                new Prefecture { Id = 17, Name = "Ishikawa" },
                new Prefecture { Id = 18, Name = "Fukui" },
                new Prefecture { Id = 19, Name = "Yamanashi" },
                new Prefecture { Id = 20, Name = "Nagano" },
                new Prefecture { Id = 21, Name = "Gifu" },
                new Prefecture { Id = 22, Name = "Shizuoka" },
                new Prefecture { Id = 23, Name = "Aichi" },
                new Prefecture { Id = 24, Name = "Mie" },
                new Prefecture { Id = 25, Name = "Shiga" },
                new Prefecture { Id = 26, Name = "Kyoto" },
                new Prefecture { Id = 27, Name = "Osaka" },
                new Prefecture { Id = 28, Name = "Hyogo" },
                new Prefecture { Id = 29, Name = "Nara" },
                new Prefecture { Id = 30, Name = "Wakayama" },
                new Prefecture { Id = 31, Name = "Tottori" },
                new Prefecture { Id = 32, Name = "Shimane" },
                new Prefecture { Id = 33, Name = "Okayama" },
                new Prefecture { Id = 34, Name = "Hiroshima" },
                new Prefecture { Id = 35, Name = "Yamaguchi" },
                new Prefecture { Id = 36, Name = "Tokushima" },
                new Prefecture { Id = 37, Name = "Kagawa" },
                new Prefecture { Id = 38, Name = "Ehime" },
                new Prefecture { Id = 39, Name = "Kochi" },
                new Prefecture { Id = 40, Name = "Fukuoka" },
                new Prefecture { Id = 41, Name = "Saga" },
                new Prefecture { Id = 42, Name = "Nagasaki" },
                new Prefecture { Id = 43, Name = "Kumamoto" },
                new Prefecture { Id = 44, Name = "Oita" },
                new Prefecture { Id = 45, Name = "Miyazaki" },
                new Prefecture { Id = 46, Name = "Kagoshima" },
                new Prefecture { Id = 47, Name = "Okinawa" }
            };

            return prefectures.ToArray();

        }
    }
}
