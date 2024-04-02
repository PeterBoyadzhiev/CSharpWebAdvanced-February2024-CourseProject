using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Web.ViewModels.Reservation;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDetailsViewModel>> GetReservationsAsync();

        Task<ReservationDetailsViewModel> GetReservationByIdAsync(string id);

        Task<ReservationDetailsViewModel> CreateReservationAsync(CreateReservationViewModel model);

        Task UpdateReservationAsync(UpdateReservationViewModel model);

        Task CancelReservationAsync(Guid reservationId, string cancellationReason);

        Task UpdateReservationStatusAsync(Guid reservationId, ReservationStatus newStatus);
    }
}
