using ExploreUmami.Data;
using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Reservation;

namespace ExploreUmami.Services.Data
{
    public class ReservationService : IReservationService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public ReservationService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ReservationDetailsViewModel>> GetReservationsAsync()
        {
            var reservations = await this.dbContext
                .Reservations
        }

        public Task<ReservationDetailsViewModel> GetReservationByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ReservationDetailsViewModel> CreateReservationAsync(CreateReservationViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservationAsync(UpdateReservationViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task CancelReservationAsync(Guid reservationId, string cancellationReason)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservationStatusAsync(Guid reservationId, ReservationStatus newStatus)
        {
            throw new NotImplementedException();
        }
    }
}
