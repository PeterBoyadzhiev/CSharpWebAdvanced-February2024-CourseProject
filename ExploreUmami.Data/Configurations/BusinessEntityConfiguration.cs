using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExploreUmami.Data.Configurations
{
    public class BusinessEntityConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder
                .HasOne(b => b.Category)
                .WithMany(c => c.Businesses)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(b => b.BusinessOwner)
                .WithMany(bo => bo.OwnedBusinesses)
                .HasForeignKey(b => b.BusinessOwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateBusinesses());
        }

        private Business[] GenerateBusinesses()
        {
            ICollection<Business> businesses = new HashSet<Business>();

            Business business;
            
            business = new Business
            {
                Title = "Restaurant",
                Description = "A place where you can eat food",
                Address = "123 Main Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.restaurant.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 1,
                BusinessOwnerId = Guid.Parse("6D8562F6-6EC4-4C21-8B7A-57670C10A292")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Cafe",
                Description = "A place where you can drink coffee",
                Address = "456 Elm Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.cafe.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 2,
                BusinessOwnerId = Guid.Parse("6D8562F6-6EC4-4C21-8B7A-57670C10A292")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Bar",
                Description = "A place where you can drink alcohol",
                Address = "789 Oak Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.bar.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 3,
                BusinessOwnerId = Guid.Parse("6D8562F6-6EC4-4C21-8B7A-57670C10A292")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Bakery",
                Description = "A place where you can buy bread",
                Address = "1012 Pine Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.bakery.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 4,
                BusinessOwnerId = Guid.Parse("28BEC72C-A405-4303-9F92-8B84C161B93E")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Fast Food",
                Description = "A place where you can eat food quickly",
                Address = "1314 Cedar Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.fastfood.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 5,
                BusinessOwnerId = Guid.Parse("28BEC72C-A405-4303-9F92-8B84C161B93E")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Food Truck",
                Description = "A place where you can eat food on the go",
                Address = "1516 Maple Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.foodtruck.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 6,
                BusinessOwnerId = Guid.Parse("28BEC72C-A405-4303-9F92-8B84C161B93E")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Dessert Shop",
                Description = "A place where you can eat dessert",
                Address = "1718 Walnut Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.dessertshop.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 7,
                BusinessOwnerId = Guid.Parse("28BEC72C-A405-4303-9F92-8B84C161B93E")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Grocery Store",
                Description = "A place where you can buy food",
                Address = "1920 Cherry Street",
                PhoneNumber = "123-456-7890",
                WebsiteURL = "https://www.grocerystore.com",
                ImageURL = "https://dummyimage.com/400x200",
                CategoryId = 8,
                BusinessOwnerId = Guid.Parse("6D8562F6-6EC4-4C21-8B7A-57670C10A292")
            };
            businesses.Add(business);

            return businesses.ToArray();
        }
    }
}
