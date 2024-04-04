namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IUserVisitService
    {
        Task AddUserVisitForCompletedReservationAsync(Guid reservationId, string? notes);
    }
}
