using ExploreUmami.Web.ViewModels.BusinessOwner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessOwnerService
    {
        Task<bool> IsOwnerByUserIdAsync(string userId);

        Task<bool> OwnerExistsByDetailsAsync(string businessName, string businessPhoneNumber, string ownerFirstName, string ownerLastName);

        Task AddOwnerAsync(string userId, SwitchFormModel model);

        Task<string?> GetOwnerIdByUserId(string userId);
    }
}
