using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.User;
using ExploreUmami.Web.ViewModels.UserVisit;

namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class ReservationDetailsViewModel
    {
        public Guid Id { get; set; }

        public BusinessDetailsReservationViewModel Business { get; set; } = null!;

        public UserDetailsViewModel User { get; set; } = null!;

        public DateTime ReservationDate { get; set; }

        public ReservationStatus Status { get; set; }

        public string? Notes { get; set; }

        public UserVisitDetailsViewModel? UserVisit { get; set; }
    }
}
