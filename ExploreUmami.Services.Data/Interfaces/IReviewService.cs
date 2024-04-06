using ExploreUmami.Web.ViewModels.Review;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReviewService
    {
        Task<VisitsReviewViewModel> GetReviewPerBusinessVisitAsync(string reviewerId, string businessId);

        Task AddReviewAsync(AddReviewModel model, string businessId, string reviewerId);

        Task<bool> ReviewExistsByUserForBusinessAsync(string reviewerId, string businessId);

        Task<bool> UserHasReviewForVisitAsync(string userId, string visitId);
    }
}
