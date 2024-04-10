using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessService
    {
        Task AddBusinessAsync(BusinessFormModel business, string ownerId);

        Task<BusinessFilterAndPageModel> GetBusinessFilteredAsync(BusinessAllFilterModel filterModel);

        Task<IEnumerable<BusinessAllViewModel>> AllBusinessesByOwnerIdAsync(string ownerId);

        Task<BusinessDetailsViewModel> GetBusinessDetailsByIdAsync(string businessId);

        Task<bool> ExistsByIdAsync(string businessId);

        Task<BusinessFormModel> GetBusinessToEditAsync(string businessId);

        Task<bool> IsUserOwnerOfBusinessByIdsAsync(string userId, string businessId);

        Task EditBusinessByIdAsync(string businessId, BusinessFormModel business);

        Task<BusinessDeleteViewModel> GetBusinessToDeleteAsync(string businessId);

        Task DeleteBusinessByIdAsync(string businessId);

        Task<BusinessDetailsReservationViewModel> GetBusinessDetailsForReservationAsync(string businessId);

        Task<IEnumerable<BusinessAllViewModel>> GetBusinessesPerPrefectureAsync(string prefecture);

        Task<IEnumerable<BusinessAllViewModel>> GetLastThreeBusinessesForApprovalAsync();
    }
}
