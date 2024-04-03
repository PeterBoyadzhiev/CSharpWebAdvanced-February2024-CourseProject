namespace ExploreUmami.Web.ViewModels.Reservation
{
    public class ReservationUpdateStatusViewModel
    {
        public string Id { get; set; } = null!;

        public string Status { get; set; } = null!;

        public string? Notes { get; set; }

        public DateTime ReservationDate { get; set; }
    }
}
