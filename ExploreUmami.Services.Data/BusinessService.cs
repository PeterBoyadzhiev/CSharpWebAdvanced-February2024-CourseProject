using ExploreUmami.Data;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Services.Data
{
    public class BusinessService : IBusinessService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public BusinessService(ExploreUmamiDbContext dbContext)
        {
             this.dbContext = dbContext;
        }

        public async Task<IEnumerable<BusinessViewModel>> GetBusinessesAsync()
        {
            IEnumerable<BusinessViewModel> businesses = await this.dbContext
                .Businesses
                .OrderByDescending(b => b.Title)
                .Take(10)
                .Select(b => new BusinessViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    ImageURL = b.ImageURL,
                })
                .ToArrayAsync();
                
            return businesses;
        }
    }
}
