using ExploreUmami.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExploreUmami.Data.Models
{
    public class Reservation
    {
        public Reservation()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Business))]
        public Guid BusinessId { get; set; }

        public Business Business { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public ReservationStatus Status { get; set; }

        [Required]
        [ForeignKey(nameof(UserVisit))]
        public Guid UserVisitId { get; set; }

        public UserVisit UserVisit { get; set; } = null!;
    }
}
