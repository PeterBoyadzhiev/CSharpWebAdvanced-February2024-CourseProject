using ExploreUmami.Web.ViewModels.Review;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewInfoAdminModel>> GetAllReviewsAsync();

        Task AddReviewAsync(AddReviewModel model, string businessId, string reviewerId);

        Task<bool> ReviewExistsByUserForBusinessAsync(string reviewerId, string businessId);

        Task<bool> UserHasReviewForVisitAsync(string userId, string visitId);

        Task RemoveReviewAsync(int id);

        Task AllowReviewAsync(int id);
    }
}
