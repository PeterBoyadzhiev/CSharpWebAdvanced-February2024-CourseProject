namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IApplicationUserService
    {
        Task<string> GetUserFullNameByEmailAsync(string email);
    }
}
