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
        private readonly IReviewService reviewService;

        public UserVisitService(ExploreUmamiDbContext dbContext, IReviewService reviewService)
        {
            this.dbContext = dbContext;
            this.reviewService = reviewService;
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

        public async Task<IEnumerable<UserVisitDetailsViewModel>> GetUserVisitsAsync(string userId)
        {
            return await this.dbContext.UserVisits
                .Include(uv => uv.Business)
                .Include(uv => uv.User)
                .Where(uv => uv.UserId.ToString() == userId)
                .Include(uv => uv.Reservation)
                .Select(uv => new
                {
                    uv.Id,
                    uv.VisitDate,
                    uv.Notes,
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
                    },
                    HasReview = false
                })
                .OrderByDescending(x => x.VisitDate)
                .Select(x => new UserVisitDetailsViewModel
                {
                    Id = x.Id.ToString(),
                    VisitDate = x.VisitDate,
                    Notes = x.Notes,
                    Business = x.Business,
                    HasReview = x.HasReview
                })
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
                    Id = uv.Id.ToString(),
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
                        Subject = uv.Business.Reviews.First().Subject,
                        Content = uv.Business.Reviews.First().Content,
                        Rating = uv.Business.Reviews.First().Rating,
                        TimeStamp = uv.Business.Reviews.First().TimeStamp,
                    }
                })
                .OrderByDescending(uv => uv.VisitDate)
                .ToListAsync();

            return visits;
        }

        public async Task<bool> UserHasVisitAsync(string userId, string businessId)
        {
            return await this.dbContext.UserVisits
                .AnyAsync(uv => uv.UserId.ToString() == userId && uv.BusinessId.ToString() == businessId);
        }
    }
}
