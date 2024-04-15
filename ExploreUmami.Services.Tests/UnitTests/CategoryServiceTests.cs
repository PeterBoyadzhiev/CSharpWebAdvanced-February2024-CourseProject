using ExploreUmami.Services.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Category;

namespace ExploreUmami.Services.Tests.UnitTests
{
    public class CategoryServiceTests : UnitTestsBase
    {

        private ICategoryService _categoryService;

        [SetUp]
        public void SetUp()
        {
            _categoryService = new CategoryService(_data);
        }

        [Test]
        public async Task GetAllCategoriesAsync_ShouldReturnAllCategories()
        {
            var expectedCategories = _data.Categories.OrderBy(c => c.Name).ToList();
            var actualCategories = await _categoryService.GetAllCategoriesAsync();

            Assert.That(actualCategories.Count(), Is.EqualTo(expectedCategories.Count));
        }

        [Test]
        public async Task CategoryExistsByIdAsync_ShouldReturnTrue_IfCategoryExists()
        {
            var existingCategoryId = Category.Id;
            var result = await _categoryService.CategoryExistsByIdAsync(existingCategoryId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task CategoryExistsByIdAsync_ShouldReturnFalse_IfCategoryDoesNotExist()
        {
            var nonExistingCategoryId = 999;
            var result = await _categoryService.CategoryExistsByIdAsync(nonExistingCategoryId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AllCategoryNamesAsync_ShouldReturnAllCategoryNames()
        {
            var expectedCategoryNames = _data.Categories.Select(c => c.Name).ToList();
            var actualCategoryNames = await _categoryService.AllCategoryNamesAsync();

            Assert.That(actualCategoryNames.Count(), Is.EqualTo(expectedCategoryNames.Count));
        }

        [Test]
        public async Task AddCategoryAsync_ShouldCreateCategory_WhenValidDataProvided()
        {
            var testModel = new CategoryFormModel { Name = "Test Category" };

            int expectedCount = _data.Categories.Count() + 1;

            await _categoryService.AddCategoryAsync(testModel);

            int categoryCount = _data.Categories.Count();
            Assert.That(expectedCount, Is.EqualTo(categoryCount));
        }

        [Test]
        public async Task GetCategoryToEdit_ShouldReturnCategory_WhenCategoryExists()
        {
            var existingCategoryId = Category.Id;
            var expectedCategory = _data.Categories.Find(existingCategoryId);
            var actualCategory = await _categoryService.GetCategoryToEdit(existingCategoryId);

            Assert.That(actualCategory.Id, Is.EqualTo(expectedCategory.Id));
            Assert.That(actualCategory.Name, Is.EqualTo(expectedCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldUpdateCategory_WhenValidDataProvided()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = "Updated Category" };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(testModel.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenInvalidDataProvided()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = "" };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenDuplicateNameProvided()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var duplicateCategory = _data.Categories.First(c => c.Id != existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = duplicateCategory.Name };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenEmptyNameProvided()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = "" };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenNullNameProvided()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = null };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenWhitespaceNameProvided()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = " " };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenNameExceedsMaxLength()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = new string('a', 51) };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task EditCategoryAsync_ShouldNotUpdateCategory_WhenNameContainsInvalidCharacters()
        {
            var existingCategoryId = Category.Id;
            var existingCategory = _data.Categories.Find(existingCategoryId);
            var testModel = new CategoryFormModel { Id = existingCategoryId, Name = "Test Category!" };

            await _categoryService.EditCategoryAsync(testModel);

            var updatedCategory = _data.Categories.Find(existingCategoryId);
            Assert.That(updatedCategory.Name, Is.EqualTo(existingCategory.Name));
        }

        [Test]
        public async Task GetCategoryToEdit_ShouldGetCorrectCategory_WhenCategoryExists()
        {
            var existingCategoryId = Category.Id;
            var expectedCategory = _data.Categories.Find(existingCategoryId);
            var actualCategory = await _categoryService.GetCategoryToEdit(existingCategoryId);

            Assert.That(actualCategory.Id, Is.EqualTo(expectedCategory.Id));
            Assert.That(actualCategory.Name, Is.EqualTo(expectedCategory.Name));
        }

    }
}
