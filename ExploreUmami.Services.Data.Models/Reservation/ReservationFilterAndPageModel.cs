using ExploreUmami.Web.ViewModels.Reservation;

namespace ExploreUmami.Services.Data.Models.Reservation
{
    public class ReservationFilterAndPageModel
    {
        public ReservationFilterAndPageModel()
        {
            this.Reservations = new HashSet<ReservationDetailsViewModel>();
        }

        public int TotalReservationsCount { get; set; }

        public IEnumerable<ReservationDetailsViewModel> Reservations { get; set; }
    }
}
