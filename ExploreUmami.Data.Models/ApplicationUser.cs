using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.ApplicationUser;

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

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<UserVisit> UserVisits { get; set; }
    }
}
