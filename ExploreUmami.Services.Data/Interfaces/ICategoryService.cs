using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Category;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<SelectCategoryFormModel>> GetAllCategoriesAsync();

        Task<bool> CategoryExistsByIdAsync(int id);

        Task<IEnumerable<string>> AllCategoryNamesAsync();

        Task AddCategoryAsync(AddCategoryFormModel model);

        Task<AddCategoryFormModel> GetCategoryToEdit(int id);

        Task EditCategoryAsync(AddCategoryFormModel model);
    }
}
