using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessService
    {
        Task AddBusinessAsync(BusinessFormModel business, string ownerId);

        Task<FilterAndPageModel> GetBusinessFilteredAsync(AllBusinessFilterModel filterModel);

        Task<IEnumerable<BusinessAllViewModel>> AllBusinessesByOwnerIdAsync(string ownerId);

        Task<IEnumerable<BusinessAllViewModel>> AllBusinessesByReviewerIdAsync(string reviewerId);

        Task<BusinessDetailsViewModel> GetBusinessDetailsByIdAsync(string businessId);

        Task<bool> ExistsByIdAsync(string businessId);

        Task<BusinessFormModel> GetBusinessToEditAsync(string businessId);

        Task<bool> IsUserOwnerOfBusinessByIdsAsync(string userId, string businessId);
    }
}
