using ExploreUmami.Web.ViewModels.Home;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessService
    {
        Task<IEnumerable<BusinessViewModel>> GetBusinessesAsync();
    }
}
