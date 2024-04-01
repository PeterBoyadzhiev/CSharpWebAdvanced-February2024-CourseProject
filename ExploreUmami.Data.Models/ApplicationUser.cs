using Microsoft.AspNetCore.Identity;

namespace ExploreUmami.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            Reviews = new HashSet<Review>();
            Reservations = new HashSet<Reservation>();
            UserVisits = new HashSet<UserVisit>();
        }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<UserVisit> UserVisits { get; set; }
    }
}
