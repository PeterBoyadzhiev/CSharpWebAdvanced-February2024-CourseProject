using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.BusinessOwner;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class BusinessOwnerService : IBusinessOwnerService
    {
        public readonly ExploreUmamiDbContext dbContext;

        public BusinessOwnerService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> IsOwnerByUserIdAsync(string userId)
        {
            bool result = await this.dbContext
                .BusinessOwners
                .AnyAsync(x => x.UserId.ToString() == userId);

            return result;
        }

        public async Task AddOwnerAsync(string userId, SwitchFormModel model)
        {
            ApplicationUser user = await dbContext.Users.FirstAsync(x => x.Id == Guid.Parse(userId));

            BusinessOwner businessOwner = new BusinessOwner
            {
                UserId = Guid.Parse(userId),
                NameOfBusiness = model.NameOfBusiness,
                PhoneNumber = model.PhoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            await dbContext.BusinessOwners.AddAsync(businessOwner);
            await dbContext.SaveChangesAsync();
        }

        public async Task<string?> GetOwnerIdByUserIdAsync(string userId)
        {
            string? ownerId = await this.dbContext
                .BusinessOwners
                .Where(x => x.UserId.ToString() == userId)
                .Select(x => x.Id.ToString())
                .FirstOrDefaultAsync();

            return ownerId;
        }
    }
}
