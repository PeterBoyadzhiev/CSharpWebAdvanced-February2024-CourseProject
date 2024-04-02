using ExploreUmami.Web.ViewModels.Business.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class ReservationAllFilterModel
    {
        public ReservationAllFilterModel()
        {
            this.ReservationsPerPage = 3;
            this.CurrentPage = 1;
            Reservations = new HashSet<ReservationDetailsViewModel>();
        }

        [Display(Name = "Search")]
        public string? SearchTerm { get; set; }

        public string? Status { get; set; }

        public int CurrentPage { get; set; }

        public int ReservationsPerPage { get; set; }

        public int TotalReservations { get; set; }

        public IEnumerable<ReservationDetailsViewModel> Reservations { get; set; }
    }
}
