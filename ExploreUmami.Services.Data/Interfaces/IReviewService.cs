using ExploreUmami.Web.ViewModels.Review;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewInfoAdminModel>> GetAllReviewsAsync();

        Task AddReviewAsync(ReviewFormModel model, string businessId, string reviewerId, string? location);

        Task<bool> ReviewExistsByUserForBusinessAsync(string reviewerId, string businessId);

        Task<bool> UserHasReviewForVisitAsync(string userId, string visitId);

        Task RemoveReviewAsync(int id);

        Task AllowReviewAsync(int id);

        Task<bool> ReviewBelongsToUserAsync(string userId, int reviewId);

        Task<ReviewEditFormModel> GetReviewToEditAsync(int id);

        Task EditReviewAsync(ReviewEditFormModel model);
    }
}
