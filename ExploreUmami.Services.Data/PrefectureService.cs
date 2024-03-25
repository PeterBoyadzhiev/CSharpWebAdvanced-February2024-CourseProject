using ExploreUmami.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Prefectures;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class PrefectureService : IPrefectureService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public PrefectureService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<SelectPrefectureFormModel>> GetAllPrefecturesAsync()
        {
            IEnumerable<SelectPrefectureFormModel> prefectures = await this.dbContext
                .Prefectures
                .OrderBy(p => p.Name)
                .AsNoTracking()
                .Select(p => new SelectPrefectureFormModel
                {
                    Id = p.Id,
                    Name = p.Name,
                })
                .ToArrayAsync();

            return prefectures;
        }

        public Task<bool> PrefectureExistsByIdAsync(int id)
        {
            return this.dbContext.Prefectures.AnyAsync(p => p.Id == id);
        }
    }
}
