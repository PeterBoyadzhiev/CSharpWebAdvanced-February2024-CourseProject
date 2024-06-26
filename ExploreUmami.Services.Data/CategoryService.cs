﻿using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public CategoryService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectCategoryViewModel>> GetAllCategoriesAsync()
        {
            IEnumerable<SelectCategoryViewModel> categories = await this.dbContext
                .Categories
                .OrderBy(c => c.Name)
                .AsNoTracking()
                .Select(c => new SelectCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();

            return categories;
        }

        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            return this.dbContext.Categories.AnyAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<string>> AllCategoryNamesAsync()
        {
            IEnumerable<string> categoryNames = await this.dbContext
                .Categories
                .Select(c => c.Name)
                .ToArrayAsync();

            return categoryNames;
        }

        public async Task AddCategoryAsync(CategoryFormModel model)
        {
            Category category = new Category
            {
                Name = model.Name,
            };

            await this.dbContext.Categories.AddAsync(category);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<CategoryFormModel> GetCategoryToEdit(int id)
        {
            Category category = await this.dbContext.Categories
                .FirstAsync(c => c.Id == id);

            return new CategoryFormModel
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public async Task EditCategoryAsync(CategoryFormModel model)
        {
            Category category = await this.dbContext.Categories
                .FirstAsync(c => c.Id == model.Id);

            category.Name = model.Name;

            await this.dbContext.SaveChangesAsync();
        }

    }
}
