using ExploreUmami.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static ExploreUmami.Common.ValidationConstants.Review;

namespace ExploreUmami.Data.Configurations
{
    public class ReviewEntityConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasOne(r => r.Business)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BusinessId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(r => r.Reviewer)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.ReviewerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(r => new { r.BusinessId, r.ReviewerId }).IsUnique();

            builder
                .Property(b => b.TimeStamp)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(r => r.IsActive)
                .HasDefaultValue(true);

            builder.HasData(GenerateReviews());
        }

        private Review[] GenerateReviews()
        {
            ICollection<Review> reviews = new HashSet<Review>();

            Review review;

            review = new Review
            {
                Id = Guid.Parse("1B49D0AA-F195-4896-B1B9-8F852CF337F3"),
                Subject = "Great food!",
                Content = "The food was incredible, best chefs in the prefecture",
                Rating = 5,
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                ReviewerId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83")
            };
            reviews.Add(review);

            review = new Review
            {
                Id = Guid.Parse("C24C77AF-568C-4021-85AC-7CACA0FD0D84"),
                Subject = "Great coffee!",
                Content = "The coffee was amazing, I had a very pleasant coffee experience",
                Rating = 5,
                BusinessId = Guid.Parse("8F87F835-3DEB-43B4-AA01-852C5D287984"),
                ReviewerId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83")
            };
            reviews.Add(review);

            review = new Review
            {
                Id = Guid.Parse("4DACBD5B-F210-43BD-B998-4EA74609F89D"),
                Subject = "Nice place but dirty.",
                Content = "It had everything I was looking for but there were squished fruits on the floor",
                Rating = 4,
                BusinessId = Guid.Parse("4222168E-C018-418E-812F-F8D41B322522"),
                ReviewerId = Guid.Parse("8F5D89A1-DDA8-4400-BF47-690AE86F1846")
            };
            reviews.Add(review);

            return reviews.ToArray();
        }
    }
}
