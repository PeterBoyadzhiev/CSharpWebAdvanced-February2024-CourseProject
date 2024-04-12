using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Category;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Areas.Admin.Controllers
{

    public class CategoryController : BaseAdminController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<SelectCategoryViewModel> categories = await this.categoryService.GetAllCategoriesAsync();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.categoryService.AddCategoryAsync(model);

                this.TempData["Success"] = "Category added successfully.";

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while adding category.";

                return RedirectToAction(nameof(All));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CategoryFormModel model = await this.categoryService.GetCategoryToEdit(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryFormModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.categoryService.EditCategoryAsync(model);

                this.TempData["Success"] = "Category edited successfully.";

                return RedirectToAction(nameof(All));
            }
            catch (Exception)
            {
                this.TempData["Error"] = "Unexpected error occurred while editing category.";

                return RedirectToAction(nameof(All));
            }
        }
    }
}
