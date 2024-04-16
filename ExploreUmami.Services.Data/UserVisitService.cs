using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Review;
using ExploreUmami.Web.ViewModels.User;
using ExploreUmami.Web.ViewModels.UserVisit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        public async Task<IEnumerable<UserVisitDetailsViewModel>> GetUserVisitsAsync(string userId)
        {
            var userVisits = await this.dbContext.UserVisits
                .Include(uv => uv.Business)
                .Include(uv => uv.User)
                .ThenInclude(u => u.Reviews)
                .Where(uv => uv.User.Id.ToString() == userId && uv.Business.IsActive)
                .Select(uv => new UserVisitDetailsViewModel
                {
                    Id = uv.Id.ToString(),
                    VisitDate = uv.VisitDate,
                    Notes = uv.Notes,
                    Business = new BusinessDetailsViewModel
                    {
                        Id = uv.Business.Id,
                        Title = uv.Business.Title,
                    },
                    User = new UserDetailsViewModel
                    {
                        Id = uv.User.Id,
                        UserName = uv.User.UserName,
                        Email = uv.User.Email,
                        FullName = uv.User.FirstName + " " + uv.User.LastName,
                        Reviews = uv.User.Reviews
                            .Where(r => r.BusinessId == uv.BusinessId)
                            .Select(r => new ReviewInfoModel
                            {
                                Id = r.Id.ToString(),
                                Subject = r.Subject,
                                Content = r.Content,
                                Rating = r.Rating,
                                TimeStamp = r.TimeStamp,
                            })
                            .ToList(),
                    },
                    Review = uv.User.Reviews
                        .Where(r => r.BusinessId == uv.BusinessId)
                        .Select(r => new ReviewInfoModel
                        {
                            Id = r.Id.ToString(),
                            Subject = r.Subject,
                            Content = r.Content,
                            Rating = r.Rating,
                            TimeStamp = r.TimeStamp,
                        })
                        .FirstOrDefault(),
                })
                .OrderByDescending(uv => uv.VisitDate)
                .ToListAsync();

            return userVisits;
        }

        public async Task<IEnumerable<UserVisitDetailsViewModel>> GetBusinessVisitsPerOwnerAsync(string ownerId)
        {
            var visits = await this.dbContext.UserVisits
                .Include(uv => uv.Business)
                .Include(uv => uv.User)
                .ThenInclude(u => u.Reviews)
                .Where(uv => uv.Business.BusinessOwnerId.ToString() == ownerId && uv.Business.IsActive)
                .Select(uv => new UserVisitDetailsViewModel
                {
                    Id = uv.Id.ToString(),
                    VisitDate = uv.VisitDate,
                    Notes = uv.Notes,
                    Business = new BusinessDetailsViewModel
                    {
                        Id = uv.Business.Id,
                        Title = uv.Business.Title,
                    },
                    User = new UserDetailsViewModel
                    {
                        Id = uv.User.Id,
                        UserName = uv.User.UserName,
                        Email = uv.User.Email,
                        FullName = uv.User.FirstName + " " + uv.User.LastName,
                        Reviews = uv.User.Reviews
                            .Where(r => r.BusinessId == uv.BusinessId)
                            .Select(r => new ReviewInfoModel
                            {
                                Subject = r.Subject,
                                Content = r.Content,
                                Rating = r.Rating,
                                TimeStamp = r.TimeStamp,
                            })
                            .ToList(),
                    },
                    Review = uv.User.Reviews
                        .Where(r => r.BusinessId == uv.BusinessId)
                        .Select(r => new ReviewInfoModel
                        {
                            Subject = r.Subject,
                            Content = r.Content,
                            Rating = r.Rating,
                            TimeStamp = r.TimeStamp,
                        })
                        .FirstOrDefault(),
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
