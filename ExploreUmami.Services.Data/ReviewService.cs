using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Review;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class ReviewService : IReviewService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public ReviewService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<VisitsReviewViewModel> GetReviewPerBusinessVisitAsync(string reviewerId, string businessId)
        {
            VisitsReviewViewModel review = await this.dbContext.Reviews
                .Where(r => r.ReviewerId.ToString() == reviewerId && r.BusinessId.ToString() == businessId)
                .Select(r => new VisitsReviewViewModel
                {
                    Subject = r.Subject,
                    Content = r.Content,
                    Rating = r.Rating,
                    TimeStamp = r.TimeStamp,
                })
                .FirstAsync();

            return review;
        }

        public async Task AddReviewAsync(AddReviewModel model, string businessId, string reviewerId)
        {
            Review review = new Review
            {
                BusinessId = Guid.Parse(businessId),
                ReviewerId = Guid.Parse(reviewerId),
                Subject = model.Subject,
                Content = model.Content,
                Rating = model.Rating,
                TimeStamp = DateTime.UtcNow,
            };

            await this.dbContext.Reviews.AddAsync(review);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
