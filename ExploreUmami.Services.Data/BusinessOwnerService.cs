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

        public async Task<bool> OwnerExistsByDetailsAsync(string businessName, string businessPhoneNumber, string ownerFirstName, string ownerLastName)
        {
            
                // ... (Your logic to access data repository)

                var existingOwner = await dbContext.BusinessOwners
                    .Where(owner =>
                        (owner.NameOfBusiness == businessName) ||
                        (owner.PhoneNumber == businessPhoneNumber) ||
                        (owner.FirstName == ownerFirstName && owner.LastName == ownerLastName))
                    .FirstOrDefaultAsync();

                if (existingOwner != null)
                {
                    if (existingOwner.NameOfBusiness == businessName)
                    {
                        throw new ArgumentException("A business owner with the provided business name already exists.");
                    }
                    if (existingOwner.PhoneNumber == businessPhoneNumber)
                    {

                        throw new ArgumentException("A business owner with the provided phone number already exists.");
                    }
                    if (existingOwner.FirstName == ownerFirstName && existingOwner.LastName == ownerLastName)
                    {
                        throw new ArgumentException("A business owner with the provided first and last name combination already exists.");
                    }
                }

                return existingOwner == null;
        }

        public async Task AddOwnerAsync(string userId, SwitchFormModel model)
        {
            BusinessOwner businessOwner = new BusinessOwner
            {
                UserId = Guid.Parse(userId),
                NameOfBusiness = model.NameOfBusiness,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };

            await dbContext.BusinessOwners.AddAsync(businessOwner);
            await dbContext.SaveChangesAsync();
        }

        public async Task<string?> GetOwnerIdByUserId(string userId)
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
