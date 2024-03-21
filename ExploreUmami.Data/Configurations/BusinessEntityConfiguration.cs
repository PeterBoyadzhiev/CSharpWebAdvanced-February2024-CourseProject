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
                .HasOne(b => b.Prefecture)
                .WithMany(p => p.Businesses)
                .HasForeignKey(b => b.PrefectureId)
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
                PrefectureId = 1,
                BusinessOwnerId = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0")
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
                PrefectureId = 2,
                BusinessOwnerId = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0")
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
                PrefectureId = 3,
                BusinessOwnerId = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0")
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
                PrefectureId = 4,
                BusinessOwnerId = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0")
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
                PrefectureId = 5,
                BusinessOwnerId = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF")
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
                PrefectureId = 6,
                BusinessOwnerId = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF")
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
                PrefectureId = 1,
                BusinessOwnerId = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF")
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
                PrefectureId = 1,
                BusinessOwnerId = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF")
            };
            businesses.Add(business);

            return businesses.ToArray();
        }
    }
}
