namespace ExploreUmami.Web.ViewModels.UserVisit
{
    public class UserVisitDetailsViewModel
    {
        public Guid Id { get; set; }

        public DateTime VisitDate { get; set; }

        public string Notes { get; set; } = null!;
    }
}
