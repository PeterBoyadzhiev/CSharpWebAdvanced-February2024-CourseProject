using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Business.Enums;
using ExploreUmami.Web.ViewModels.BusinessOwner;
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

        public async Task AddBusinessAsync(BusinessFormModel business, string ownerId)
        {
            Business newBusiness = new Business
            {
                Title = business.Title,
                Description = business.Description,
                Address = business.Address,
                PhoneNumber = business.PhoneNumber,
                WebsiteUrl = business.WebsiteUrl,
                ImageUrl = business.ImageUrl,
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
                                EF.Functions.Like(b.WebsiteUrl ?? "", wildCardSearchTerm));
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
                .Where(b => b.IsActive == true)
                .Skip((filterModel.CurrentPage - 1) * filterModel.BusinessPerPage)
                .Take(filterModel.BusinessPerPage)
                .Select(b => new BusinessAllViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                })
                .ToArrayAsync();

            int totalBusinesses = await businessesQuery.CountAsync();

            return new FilterAndPageModel
            {
                TotalBusinessesCount = totalBusinesses,
                Businesses = businesses,
            };
        }

        public async Task<IEnumerable<BusinessAllViewModel>> AllBusinessesByOwnerIdAsync(string ownerId)
        {
            
            IEnumerable<BusinessAllViewModel> businesses = await this.dbContext
                .Businesses
                .Where(b => b.IsActive == true && b.BusinessOwnerId == Guid.Parse(ownerId))
                .Select(b => new BusinessAllViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                })
                .ToArrayAsync();

            return businesses;
        }

        public async Task<IEnumerable<BusinessAllViewModel>> AllBusinessesByReviewerIdAsync(string reviewerId)
        {
            
            IEnumerable<BusinessAllViewModel> businesses = await this.dbContext
                .Businesses
                .Where(b => b.Reviews.Any(r => r.ReviewerId == Guid.Parse(reviewerId)))
                .Select(b => new BusinessAllViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    Description = b.Description,
                    ImageUrl = b.ImageUrl,
                })
                .ToArrayAsync();

            return businesses;

        }

        public async Task<BusinessDetailsViewModel> GetBusinessDetailsByIdAsync(string businessId)
        {
            Business business = await this.dbContext
                .Businesses
                .Include(b => b.Category)
                .Include(b => b.Prefecture)
                .Include(b => b.BusinessOwner)
                .ThenInclude(bo => bo.User)
                .Include(b => b.Reviews) // TO DO
                .FirstAsync(b => b.Id.ToString() == businessId);

            return new BusinessDetailsViewModel()
            {
                Id = business.Id.ToString(),
                Title = business.Title,
                Description = business.Description,
                Address = business.Address,
                PhoneNumber = business.PhoneNumber,
                WebsiteUrl = business.WebsiteUrl ?? "",
                ImageUrl = business.ImageUrl,
                Category = business.Category.Name,
                Prefecture = business.Prefecture.Name,
                Owner = new OwnerInfoModel()
                { 
                    FullName = business.BusinessOwner.FirstName + " " + business.BusinessOwner.LastName,
                    PhoneNumber = business.BusinessOwner.PhoneNumber,
                    Email = business.BusinessOwner.User.Email,
                }
                
            };
        }

        public async Task<bool> ExistsByIdAsync(string businessId)
        {
            return await this.dbContext
                .Businesses
                .Where(b => b.IsActive)
                .AnyAsync(b => b.Id.ToString() == businessId);
        }

        public async Task<BusinessFormModel> GetBusinessToEditAsync(string businessId)
        {
            Business business = await this.dbContext
                .Businesses
                .Include(b => b.Category)
                .Include(b => b.Prefecture)
                .FirstAsync(b => b.Id.ToString() == businessId);

            return new BusinessFormModel()
            {
                Title = business.Title,
                Description = business.Description,
                Address = business.Address,
                PhoneNumber = business.PhoneNumber,
                WebsiteUrl = business.WebsiteUrl ?? "",
                ImageUrl = business.ImageUrl,
                CategoryId = business.CategoryId,
                PrefectureId = business.PrefectureId,
            };
        }

        public async Task<bool> IsUserOwnerOfBusinessByIdsAsync(string userId, string businessId)
        {
            Business business = await this.dbContext
                .Businesses
                .Where(b => b.IsActive)
                .FirstAsync(b => b.Id.ToString() == businessId);

            return business.BusinessOwnerId == Guid.Parse(userId);
        }
    }
}
