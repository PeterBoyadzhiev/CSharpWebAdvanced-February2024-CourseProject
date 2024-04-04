namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IUserVisitService
    {
        Task AddUserVisitForCompletedReservationAsync(string reservationId);
    }
}
