using ExploreUmami.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Business;
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

        public async Task<IEnumerable<string>> AllPrefectureNamesAsync()
        {
            IEnumerable<string> prefectureNames = await this.dbContext
                .Prefectures
                .Select(p => p.Name)
                .ToArrayAsync();

            return prefectureNames;
        }

        public async Task<PrefectureInfoModel> GetPrefectureInfoAsync(string prefecture)
        {
            var businessCount = await this.dbContext.Businesses
                    .Where(b => b.Prefecture.Name == prefecture && (b.IsActive && b.IsApproved))
                    .CountAsync();

            BusinessDetailsViewModel? highestRatedBusiness = null;


            if(businessCount > 0)
            {
                highestRatedBusiness = await this.dbContext.Businesses
                    .Where(b => b.Prefecture.Name == prefecture)
                    .Select(b => new BusinessDetailsViewModel
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Description = b.Description,
                        ImageUrl = b.ImageUrl,
                        AverageRating = b.Reviews
                                    .Any()
                                    ? b.Reviews.Where(r => r.IsActive).Average(r => r.Rating)
                                    : 0.0
                    })
                    .OrderByDescending(b => b.AverageRating)
                    .FirstOrDefaultAsync();
            }

            PrefectureInfoModel model = new PrefectureInfoModel
            {
                PrefectureName = prefecture,
                BusinessCount = businessCount,
                HighestRatedBusiness = businessCount > 0 ? highestRatedBusiness : null,
            };

            return model;
        }
    }
}
