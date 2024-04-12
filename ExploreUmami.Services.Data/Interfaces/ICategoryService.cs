using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Category;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<SelectCategoryViewModel>> GetAllCategoriesAsync();

        Task<bool> CategoryExistsByIdAsync(int id);

        Task<IEnumerable<string>> AllCategoryNamesAsync();

        Task AddCategoryAsync(CategoryFormModel model);

        Task<CategoryFormModel> GetCategoryToEdit(int id);

        Task EditCategoryAsync(CategoryFormModel model);
    }
}
