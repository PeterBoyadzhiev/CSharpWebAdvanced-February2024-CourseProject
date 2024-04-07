namespace ExploreUmami.Web.ViewModels.Business
{
    public class BusinessDetailsReservationViewModel : BusinessAllViewModel
    {
        public string Address { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Prefecture { get; set; } = null!;
    }
}
