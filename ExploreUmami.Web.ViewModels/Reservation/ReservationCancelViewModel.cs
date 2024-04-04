using System.ComponentModel.DataAnnotations;
using static ExploreUmami.Common.ValidationConstants.Reservation;

namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class ReservationCancelViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [MaxLength(NotesMaxLength)]
        public string? Notes { get; set; }

        public DateTime ReservationDate { get; set; }

        [Required]
        public bool Answer { get; set; }
    }
}
