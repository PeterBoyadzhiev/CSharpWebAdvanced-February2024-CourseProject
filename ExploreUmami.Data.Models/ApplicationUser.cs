using Microsoft.AspNetCore.Identity;

namespace ExploreUmami.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            VisitedBusinesses = new HashSet<Business>();
        }

        public ICollection<Business> VisitedBusinesses { get; set; }

    }
}
