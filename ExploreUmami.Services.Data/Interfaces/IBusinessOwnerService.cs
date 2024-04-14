using ExploreUmami.Web.ViewModels.BusinessOwner;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessOwnerService
    {
        Task<bool> IsOwnerByUserIdAsync(string userId);

        Task AddOwnerAsync(string userId, SwitchFormModel model);

        Task<string?> GetOwnerIdByUserIdAsync(string userId);
    }
}
