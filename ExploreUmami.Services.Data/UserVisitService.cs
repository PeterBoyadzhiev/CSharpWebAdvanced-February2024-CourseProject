using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Review;
using ExploreUmami.Web.ViewModels.User;
using ExploreUmami.Web.ViewModels.UserVisit;
using Microsoft.EntityFrameworkCore;

namespace ExploreUmami.Services.Data
{
    public class UserVisitService : IUserVisitService
    {
        private readonly ExploreUmamiDbContext dbContext;

        public UserVisitService(ExploreUmamiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddUserVisitForCompletedReservationAsync(Guid reservationId, string? notes)
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
                Notes = notes
            };

            await this.dbContext.UserVisits.AddAsync(userVisit);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserVisitDetailsViewModel>> GetUserVisitsAsync()
        {

            return await this.dbContext.UserVisits
                .Include(uv => uv.Business)
                .Include(uv => uv.Reservation)
                .Select(uv => new UserVisitDetailsViewModel
                {
                    Id = uv.Id,
                    VisitDate = uv.VisitDate,
                    Notes = uv.Notes,
                    Business = new BusinessDetailsViewModel
                    {
                        Id = uv.Business.Id.ToString(),
                        Title = uv.Business.Title,
                        Address = uv.Business.Address,
                        Category = uv.Business.Category!.ToString() ?? "Category not available",
                        Prefecture = uv.Business.Prefecture!.ToString() ?? "Prefecture not available",
                        PhoneNumber = uv.Business.PhoneNumber,
                        WebsiteUrl = uv.Business.WebsiteUrl ?? "null",
                        Description = uv.Business.Description,
                        ImageUrl = uv.Business.ImageUrl,
                    }
                })
                .OrderByDescending(uv => uv.VisitDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<UserVisitDetailsViewModel>> GetBusinessVisitsPerOwnerAsync(string ownerId)
        {
            var visits = await this.dbContext.UserVisits
                .Include(uv => uv.Business)
                .ThenInclude(uv => uv.Reviews)
                .Where(uv => uv.Business.BusinessOwnerId.ToString() == ownerId)
                .Include(uv => uv.User)
                .Where(r => r.Business.Reviews.Any())
                .Select(uv => new UserVisitDetailsViewModel
                {
                    Id = uv.Id,
                    VisitDate = uv.VisitDate,
                    Notes = uv.Notes,
                    Business = new BusinessDetailsViewModel
                    {
                        Id = uv.Business.Id.ToString(),
                        Title = uv.Business.Title,
                        Address = uv.Business.Address,
                        Category = uv.Business.Category!.ToString() ?? "Category not available",
                        Prefecture = uv.Business.Prefecture!.ToString() ?? "Prefecture not available",
                        PhoneNumber = uv.Business.PhoneNumber,
                        WebsiteUrl = uv.Business.WebsiteUrl ?? "null",
                        Description = uv.Business.Description,
                        ImageUrl = uv.Business.ImageUrl,
                        Reviews = uv.Business.Reviews.Select(r => new ReviewInfoModel
                        {
                            Subject = r.Subject,
                            Content = r.Content,
                            Rating = r.Rating,
                            TimeStamp = r.TimeStamp,
                        }).ToList(),
                    },
                    User = new UserDetailsViewModel
                    {
                        Id = uv.User.Id,
                        UserName = uv.User.UserName,
                        Email = uv.User.Email,
                    },
                    Review = new VisitsReviewViewModel
                    {
                        Subject = uv.Business.Reviews.FirstOrDefault().Subject,
                        Content = uv.Business.Reviews.FirstOrDefault().Content,
                        Rating = uv.Business.Reviews.FirstOrDefault().Rating,
                        TimeStamp = uv.Business.Reviews.FirstOrDefault().TimeStamp,
                    }
                })
                .OrderByDescending(uv => uv.VisitDate)
                .ToListAsync();

            return visits;
        }
    }
}
