namespace ExploreUmami.Web.ViewModels.UserVisit
{
    internal class UserVisitDetailsViewModel
    {
        public Guid Id { get; set; }

        public DateTime VisitDate { get; set; }

        public string Notes { get; set; } = null!;
    }
}
