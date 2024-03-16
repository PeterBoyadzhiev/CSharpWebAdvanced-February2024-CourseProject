using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExploreUmami.Data.Configurations
{
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category { Id = 1, Name = "Restaurant" };
            categories.Add(category);

            category = new Category { Id = 2, Name = "Cafe" };
            categories.Add(category);

            category = new Category { Id = 3, Name = "Bar" };
            categories.Add(category);

            category = new Category { Id = 4, Name = "Bakery" };
            categories.Add(category);

            category = new Category { Id = 5, Name = "Fast Food" };
            categories.Add(category);

            category = new Category { Id = 6, Name = "Food Truck" };
            categories.Add(category);

            category = new Category { Id = 7, Name = "Dessert Shop" };
            categories.Add(category);

            category = new Category { Id = 8, Name = "Grocery Store" };
            categories.Add(category);

            category = new Category { Id = 9, Name = "Market" };
            categories.Add(category);

            category = new Category { Id = 10, Name = "Food Stand" };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
