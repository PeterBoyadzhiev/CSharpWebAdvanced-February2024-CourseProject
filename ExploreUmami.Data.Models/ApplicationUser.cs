using Microsoft.AspNetCore.Identity;

namespace ExploreUmami.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            Reviews = new HashSet<Review>();
            VisitedBusinesses = new HashSet<Business>();
        }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Business> VisitedBusinesses { get; set; }

    }
}
