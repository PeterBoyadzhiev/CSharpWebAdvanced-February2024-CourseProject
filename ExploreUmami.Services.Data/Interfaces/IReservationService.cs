using ExploreUmami.Services.Data.Models.Reservation;
using ExploreUmami.Web.ViewModels.Reservation;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDetailsViewModel>> AllReservationsByUserIdAsync(string userId);

        Task<IEnumerable<ReservationDetailsViewModel>> AllReservationsByOwnerIdAsync(string ownerId);

        Task<ReservationFilterAndPageModel> GetReservationsByFilterForOwnerAsync(ReservationFilterViewModel filterModel, string ownerId);

        Task<ReservationFilterAndPageModel> GetReservationsByFilterForUserAsync(ReservationFilterViewModel filterModel, string userId);

        Task MakeReservationAsync(MakeReservationFormModel model, string userId, string businessId);

        Task<bool> UserHasIncompleteReservationAsync(string userId);

        Task<ReservationDetailsViewModel> GetReservationByIdAsync(string reservationId);

        Task ChangeReservationStatusByIdAsync(string reservationId, string status);

        Task<string> GetBusinessIdByReservationIdAsync(string reservationId);

        Task<ReservationCancelViewModel> GetReservationForCancelByIdAsync(string reservationId);
    }
}
