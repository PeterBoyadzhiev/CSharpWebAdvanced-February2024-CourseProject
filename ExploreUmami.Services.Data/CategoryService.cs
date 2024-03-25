using ExploreUmami.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Category;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public CategoryService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectCategoryFormModel>> GetAllCategoriesAsync()
        {
            IEnumerable<SelectCategoryFormModel> categories = await this.dbContext
                .Categories
                .OrderBy(c => c.Name)
                .AsNoTracking()
                .Select(c => new SelectCategoryFormModel
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
    }
}
