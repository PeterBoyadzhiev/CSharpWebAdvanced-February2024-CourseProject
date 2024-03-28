using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessService
    {
        Task AddBusinessAsync(AddBusinessFormModel business, string ownerId);

        Task<FilterAndPageModel> GetBusinessFilteredAsync(AllBusinessFilterModel filterModel);
    }
}
