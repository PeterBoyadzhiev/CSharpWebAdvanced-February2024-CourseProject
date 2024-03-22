using ExploreUmami.Data;
using ExploreUmami.Services.Data.Interfaces;
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

        public async Task<bool> IsOwnerByUserId(string userId)
        {
            bool result = await this.dbContext
                .BusinessOwners
                .AnyAsync(x => x.UserId.ToString() == userId);

            return result;
        }
    }
}
