namespace ExploreUmami.Web.ViewModels.User
{
    public class UserDetailsViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
