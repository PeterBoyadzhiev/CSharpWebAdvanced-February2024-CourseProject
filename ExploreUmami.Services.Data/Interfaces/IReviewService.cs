using ExploreUmami.Web.ViewModels.Review;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewInfoAdminModel>> GetAllReviewsAsync();

        Task AddReviewAsync(ReviewFormModel model, string businessId, string reviewerId, string? location);

        Task<bool> ReviewExistsByUserForBusinessAsync(string reviewerId, string businessId);

        Task<bool> UserHasReviewForVisitAsync(string userId, string visitId);

        Task RemoveReviewAsync(string id);

        Task AllowReviewAsync(string id);

        Task<bool> ReviewBelongsToUserAsync(string userId, string reviewId);

        Task<ReviewEditFormModel> GetReviewToEditAsync(string id);

        Task EditReviewAsync(ReviewEditFormModel model);
    }
}
