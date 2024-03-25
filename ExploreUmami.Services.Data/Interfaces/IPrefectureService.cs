using ExploreUmami.Web.ViewModels.Prefectures;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IPrefectureService
    {
        Task<IEnumerable<SelectPrefectureFormModel>> GetAllPrefecturesAsync();
    }
}
