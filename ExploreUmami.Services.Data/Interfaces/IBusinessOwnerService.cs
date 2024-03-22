using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IBusinessOwnerService
    {
        Task<bool> IsOwnerByUserId(string userId);
    }
}
