using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Business;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Business.Enums;
using ExploreUmami.Web.ViewModels.BusinessOwner;
using ExploreUmami.Web.ViewModels.Review;
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

        public async Task<FilterAndPageModel> GetBusinessFilteredAsync(BusinessAllFilterModel filterModel)
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
                .Include(b => b.Reviews)
                .ThenInclude(b => b.Reviewer)// TO DO
                .FirstAsync(b => b.Id.ToString() == businessId);

            var averageRating = business.Reviews.Any()
                ? business.Reviews.Average(r => r.Rating)
                : 0.0;

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
                AverageRating = averageRating,
                Owner = new OwnerInfoModel()
                { 
                    FullName = business.BusinessOwner.FirstName + " " + business.BusinessOwner.LastName,
                    PhoneNumber = business.BusinessOwner.PhoneNumber,
                    Email = business.BusinessOwner.User.Email,
                },
                Reviews = business.Reviews
                    .Select(r => new ReviewInfoModel()
                    {
                        Subject = r.Subject,
                        Content = r.Content,
                        Rating = r.Rating,
                        TimeStamp = r.TimeStamp,
                        Reviewer = r.Reviewer!.UserName,
                    })
                    .ToArray(),
            };
        }

        public async Task<bool> ExistsByIdAsync(string businessId)
        {
            return await this.dbContext
                .Businesses
                .Where(b => b.Id.ToString() == businessId && b.IsActive == true)
                .AnyAsync();
        }

        public async Task<bool> IsUserOwnerOfBusinessByIdsAsync(string userId, string businessId)
        {
            Business business = await this.dbContext.Businesses
                .Where(b => b.Id.ToString() == businessId && b.IsActive == true)
                .FirstAsync();

            return business.BusinessOwnerId == Guid.Parse(userId);
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

        public async Task EditBusinessByIdAsync(string businessId, BusinessFormModel business)
        {
            Business businessToEdit = await this.dbContext
                .Businesses
                .Where(b => b.Id.ToString() == businessId && b.IsActive == true)
                .FirstAsync();

            businessToEdit.Title = business.Title;
            businessToEdit.Description = business.Description;
            businessToEdit.Address = business.Address;
            businessToEdit.PhoneNumber = business.PhoneNumber;
            businessToEdit.WebsiteUrl = business.WebsiteUrl;
            businessToEdit.ImageUrl = business.ImageUrl;
            businessToEdit.CategoryId = business.CategoryId;
            businessToEdit.PrefectureId = business.PrefectureId;

            await this.dbContext.SaveChangesAsync();
        }
        public async Task<BusinessDeleteViewModel> GetBusinessToDeleteAsync(string businessId)
        {
            Business business = await this.dbContext
                .Businesses
                .Include(b => b.Prefecture)
                .Where(b => b.Id.ToString() == businessId && b.IsActive == true)
                .FirstAsync();

            return new BusinessDeleteViewModel()
            {
                Title = business.Title,
                Address = business.Address,
                ImageUrl = business.ImageUrl,
                Prefecture = business.Prefecture.Name,
            };
        }

        public async Task DeleteBusinessByIdAsync(string businessId)
        {
            Business businessToDelete = await this.dbContext
                .Businesses
                .Where(b => b.Id.ToString() == businessId && b.IsActive == true)
                .FirstAsync();

            businessToDelete.IsActive = false;

            await this.dbContext.SaveChangesAsync();
        }

        
    }
}
