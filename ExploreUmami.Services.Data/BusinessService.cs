using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Business.Enums;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class BusinessService : IBusinessService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public BusinessService(ExploreUmamiDbContext dbContext)
        {
             this.dbContext = dbContext;
        }

        public async Task AddBusinessAsync(AddBusinessFormModel business, string ownerId)
        {
            Business newBusiness = new Business
            {
                Title = business.Title,
                Description = business.Description,
                Address = business.Address,
                PhoneNumber = business.PhoneNumber,
                WebsiteURL = business.WebsiteURL,
                ImageURL = business.ImageURL,
                CategoryId = business.CategoryId,
                PrefectureId = business.PrefectureId,
                BusinessOwnerId = Guid.Parse(ownerId),
            };

            await this.dbContext.Businesses.AddAsync(newBusiness);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<FilterAndPageModel> GetBusinessFilteredAsync(AllBusinessFilterModel filterModel)
        {
            IQueryable<Business> businessesQuery = this.dbContext
                .Businesses
                .AsQueryable();

            if (!string.IsNullOrEmpty(filterModel.Category)) 
            {
                businessesQuery = businessesQuery
                    .Where(b => b.Category.Name == filterModel.Category);
            }

            if (!string.IsNullOrEmpty(filterModel.Prefecture))
            {
                businessesQuery = businessesQuery
                    .Where(b => b.Prefecture.Name == filterModel.Prefecture);
            }

            if (!string.IsNullOrEmpty(filterModel.SearchTerm))
            {
                string wildCardSearchTerm = $"%{filterModel.SearchTerm.ToLower()}%";

                businessesQuery = businessesQuery
                    .Where(b => EF.Functions.Like(b.Title, wildCardSearchTerm) ||
                                EF.Functions.Like(b.Description, wildCardSearchTerm) ||
                                EF.Functions.Like(b.Address, wildCardSearchTerm) ||
                                EF.Functions.Like(b.PhoneNumber, wildCardSearchTerm) ||
                                EF.Functions.Like(b.WebsiteURL ?? "", wildCardSearchTerm));
            }

            businessesQuery = filterModel.BusinessSorting switch
            {
                BusinessSorting.HighestRating => businessesQuery
                    .OrderByDescending(b => b.Reviews.Average(r => r.Rating)),
                BusinessSorting.LowestRating => businessesQuery
                    .OrderBy(b => b.Reviews.Average(r => r.Rating)),
                BusinessSorting.Latest => businessesQuery
                    .OrderByDescending(b => b.CreatedOn),
                BusinessSorting.Oldest => businessesQuery
                    .OrderBy(b => b.CreatedOn),
                _ => businessesQuery
                    .OrderBy(b => b.Title),
            };

            IEnumerable<BusinessAllViewModel> businesses = await businessesQuery
                .Skip((filterModel.CurrentPage - 1) * filterModel.BusinessPerPage)
                .Take(filterModel.BusinessPerPage)
                .Select(b => new BusinessAllViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    Description = b.Description,
                    Address = b.Address,
                    PhoneNumber = b.PhoneNumber,
                    ImageURL = b.ImageURL,
                    WebsiteUrl = b.WebsiteURL ?? "",
                })
                .ToArrayAsync();

            int totalBusinesses = await businessesQuery.CountAsync();

            return new FilterAndPageModel
            {
                TotalBusinessesCount = totalBusinesses,
                Businesses = businesses,
            };
        }
    }
}
