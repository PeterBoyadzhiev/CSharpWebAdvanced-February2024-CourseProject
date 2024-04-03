using ExploreUmami.Web.ViewModels.Business.Enums;
using ExploreUmami.Web.ViewModels.Business;
using System.ComponentModel.DataAnnotations;
using ExploreUmami.Data.Models.Enums;

namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class ReservationFilterViewModel
    {
        public ReservationFilterViewModel()
        {
            this.CurrentPage = 1;
            this.ReservationsPerPage = 3;

            this.Reservations = new HashSet<ReservationDetailsViewModel>();
        }


        [Display(Name = "Search")]
        public string? SearchTerm { get; set; }

        public string Status { get; set; } = null!;

        public int CurrentPage { get; set; }

        public int ReservationsPerPage { get; set; }

        public int TotalReservations { get; set; }

        public IEnumerable<ReservationDetailsViewModel> Reservations { get; set; }
    }
}

