using ExploreUmami.Web.ViewModels.BusinessOwner;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessOwnerService
    {
        Task<bool> IsOwnerByUserIdAsync(string userId);

        Task<bool> OwnerExistsByDetailsAsync(string businessName, string businessPhoneNumber, string ownerFirstName, string ownerLastName);

        Task AddOwnerAsync(string userId, SwitchFormModel model);

        Task<string?> GetOwnerIdByUserIdAsync(string userId);
    }
}
