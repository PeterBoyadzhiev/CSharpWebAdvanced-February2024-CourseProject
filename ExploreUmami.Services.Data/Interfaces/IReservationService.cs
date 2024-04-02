using ExploreUmami.Web.ViewModels.Reservation;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDetailsViewModel>> AllReservationsByUserIdAsync(string userId);

        Task<IEnumerable<ReservationDetailsViewModel>> AllReservationsByOwnerIdAsync(string ownerId);


    }
}
