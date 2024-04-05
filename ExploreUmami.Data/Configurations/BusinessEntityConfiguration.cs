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

            builder
                .Property(b => b.CreatedOn)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(b => b.IsActive)
                .HasDefaultValue(true);

            builder.HasData(GenerateBusinesses());
        }

        private Business[] GenerateBusinesses()
        {
            ICollection<Business> businesses = new HashSet<Business>();

            Business business;
            
            business = new Business
            {
                Id = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                Title = "Restaurant",
                Description = "A place where you can eat food",
                Address = "123 Main Street",
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.restaurant.com",
                ImageUrl = "https://dummyimage.com/400x200",
                CategoryId = 1,
                PrefectureId = 1,
                IsActive = true,
                BusinessOwnerId = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0")
            };
            businesses.Add(business);

            business = new Business
            {
                Id = Guid.Parse("8F87F835-3DEB-43B4-AA01-852C5D287984"),
                Title = "Cafe",
                Description = "A place where you can drink coffee",
                Address = "456 Elm Street",
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.cafe.com",
                ImageUrl = "https://dummyimage.com/400x200",
                CategoryId = 2,
                PrefectureId = 2,
                IsActive = true,
                BusinessOwnerId = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Bar",
                Description = "A place where you can drink alcohol",
                Address = "789 Oak Street",
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.bar.com",
                ImageUrl = "https://dummyimage.com/400x200",
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
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.bakery.com",
                ImageUrl = "https://dummyimage.com/400x200",
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
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.fastfood.com",
                ImageUrl = "https://dummyimage.com/400x200",
                CategoryId = 5,
                PrefectureId = 5,
                BusinessOwnerId = Guid.Parse("C805DDB6-BCF7-47A3-8744-3EC84036CAA0")
            };
            businesses.Add(business);

            business = new Business
            {
                Title = "Food Truck",
                Description = "A place where you can eat food on the go",
                Address = "1516 Maple Street",
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.foodtruck.com",
                ImageUrl = "https://dummyimage.com/400x200",
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
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.dessertshop.com",
                ImageUrl = "https://dummyimage.com/400x200",
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
                PhoneNumber = "12-3456-7890",
                WebsiteUrl = "https://www.grocerystore.com",
                ImageUrl = "https://dummyimage.com/400x200",
                CategoryId = 8,
                PrefectureId = 1,
                BusinessOwnerId = Guid.Parse("E826FF19-1946-4237-B266-E326CBEAD8FF")
            };
            businesses.Add(business);

            return businesses.ToArray();
        }
    }
}
