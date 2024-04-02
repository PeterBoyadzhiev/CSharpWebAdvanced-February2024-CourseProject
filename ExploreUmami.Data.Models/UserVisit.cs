using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ExploreUmami.Common.ValidationConstants.UserVisit;

namespace ExploreUmami.Data.Models
{
    public class UserVisit
    {
        public UserVisit()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [MaxLength(NotesMaxLength)]
        public string? Notes { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Business))]
        public Guid BusinessId { get; set; }

        public Business Business { get; set; } = null!;

        public DateTime VisitDate { get; set; }

        [Required]
        [ForeignKey(nameof(Reservation))]
        public Guid ReservationId { get; set; }

        public Reservation Reservation { get; set; } = null!;
    }
}
