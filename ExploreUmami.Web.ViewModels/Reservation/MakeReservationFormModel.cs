using ExploreUmami.Web.ViewModels.Business;
using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class MakeReservationFormModel
    {
        public string? Notes { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; } = DateTime.Today.AddDays(1);

        public BusinessDetailsReservationViewModel Business { get; set; } = null!;
    }
}
