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
                Id = -1,
                Subject = "Great food!",
                Content = "The food was incredible, best chefs in the prefecture",
                Rating = 5,
                BusinessId = Guid.Parse("6EEC121F-F98E-4008-9551-2D8A4B38DA98"),
                ReviewerId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83")
            };
            reviews.Add(review);

            review = new Review
            {
                Id = -2,
                Subject = "Great coffee!",
                Content = "The coffee was amazing, I had a very pleasant coffee experience",
                Rating = 5,
                BusinessId = Guid.Parse("8F87F835-3DEB-43B4-AA01-852C5D287984"),
                ReviewerId = Guid.Parse("AB13755F-EAEF-4FB4-86A1-9C4609641C83")
            };
            reviews.Add(review);

            return reviews.ToArray();
        }
    }
}
