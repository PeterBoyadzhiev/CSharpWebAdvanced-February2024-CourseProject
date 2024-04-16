using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Review;
using ExploreUmami.Web.ViewModels.User;
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

        public async Task<IEnumerable<ReviewInfoAdminModel>> GetAllReviewsAsync()
        {
            IEnumerable<ReviewInfoAdminModel> reviews = await this.dbContext.Reviews
                .Include(r => r.Business)
                .Include(r => r.Reviewer)
                .Select(r => new ReviewInfoAdminModel
                {
                    Id = r.Id.ToString(),
                    Subject = r.Subject,
                    Content = r.Content,
                    Rating = r.Rating,
                    TimeStamp = r.TimeStamp,
                    IsActive = r.IsActive,
                    Business = new BusinessDetailsViewModel()
                    {
                        Id = r.Business.Id,
                        Title = r.Business.Title,
                    },
                    Reviewer = new UserDetailsViewModel()
                    {
                        Id = r.Reviewer.Id,
                        FullName = r.Reviewer.FirstName + " " + r.Reviewer.LastName,
                    }
                })
                .ToArrayAsync();

            return reviews;
        }


        public async Task AddReviewAsync(ReviewFormModel model, string businessId, string reviewerId, string? location)
        {
            Review review = new Review
            {
                BusinessId = Guid.Parse(businessId),
                ReviewerId = Guid.Parse(reviewerId),
                Subject = model.Subject,
                Content = model.Content,
                Rating = model.Rating,
                TimeStamp = DateTime.UtcNow,
                UserLocation = location ?? "",
            };

            await this.dbContext.Reviews.AddAsync(review);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> ReviewExistsByUserForBusinessAsync(string reviewerId, string businessId)
        {
            return await this.dbContext.Reviews
                .AnyAsync(r => r.ReviewerId.ToString() == reviewerId && r.BusinessId.ToString() == businessId);
        }

        public async Task<bool> UserHasReviewForVisitAsync(string userId, string visitId)
        {
            return await dbContext.UserVisits
                .Include(uv => uv.Business)
                .ThenInclude(uv => uv.Reviews)
                .AnyAsync(uv => uv.UserId.ToString() == userId && uv.Id.ToString() == visitId && uv.Business.Reviews.Any(r => r.ReviewerId.ToString() == userId));
        }

        public async Task RemoveReviewAsync(string id)
        {
            Review review = await this.dbContext.Reviews
                .Where(r => r.Id.ToString() == id)
                .FirstAsync(r => r.Id.ToString() == id);

            review.IsActive = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task AllowReviewAsync(string id)
        {
            Review review = await this.dbContext.Reviews
                .Where(r => r.Id.ToString() == id)
                .FirstAsync(r => r.Id.ToString() == id);

            review.IsActive = true;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> ReviewBelongsToUserAsync(string userId, string reviewId)
        {
            return await this.dbContext.Reviews
                .AnyAsync(r => r.ReviewerId.ToString() == userId && r.Id.ToString() == reviewId);
        }

        public async Task<ReviewEditFormModel> GetReviewToEditAsync(string id)
        {
            Review review = await this.dbContext.Reviews
                .FirstAsync(r => r.Id.ToString() == id);

            return new ReviewEditFormModel
            {
                Id = review.Id.ToString(),
                Subject = review.Subject,
                Content = review.Content,
                Rating = review.Rating,
            };
        }

        public async Task EditReviewAsync(ReviewEditFormModel model)
        {
            Review review = await this.dbContext.Reviews
                .FirstAsync(r => r.Id.ToString() == model.Id);

            review.Subject = model.Subject;
            review.Content = model.Content;
            review.Rating = model.Rating;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
