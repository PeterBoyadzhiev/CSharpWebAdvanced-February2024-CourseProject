using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public ApplicationUserService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetUserFullNameByEmailAsync(string email)
        {
            ApplicationUser? user = await this.dbContext.Users
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";
        }
    }
}
