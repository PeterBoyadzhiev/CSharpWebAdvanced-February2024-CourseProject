using ExploreUmami.Web.ViewModels.Prefectures;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IPrefectureService
    {
        Task<IEnumerable<SelectPrefectureFormModel>> GetAllPrefecturesAsync();

        Task<bool> PrefectureExistsByIdAsync(int id);

        Task<IEnumerable<string>> AllPrefectureNamesAsync();

        Task<PrefectureInfoModel> GetPrefectureInfoAsync(string prefecture);
    }
}
