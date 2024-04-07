using ExploreUmami.Web.ViewModels.Business;
using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class MakeReservationFormModel
    {
        public string? Notes { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        public BusinessDetailsReservationViewModel Business { get; set; } = null!;
    }
}
