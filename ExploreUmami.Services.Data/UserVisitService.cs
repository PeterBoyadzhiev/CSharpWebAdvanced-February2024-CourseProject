using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;

namespace ExploreUmami.Services.Data
{
    public class UserVisitService : IUserVisitService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public UserVisitService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddUserVisitForCompletedReservationAsync(string reservationId)
        {
            Reservation? reservation = await this.dbContext.Reservations.FindAsync(reservationId);

            if (reservation == null)
            {
                throw new ArgumentException("Reservation not found.");
            }

            UserVisit userVisit = new UserVisit
            {
                UserId = reservation.UserId,
                BusinessId = reservation.BusinessId,
                ReservationId = reservation.Id,
                VisitDate = DateTime.UtcNow,
                Notes = string.Empty
            };

            await this.dbContext.UserVisits.AddAsync(userVisit);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
