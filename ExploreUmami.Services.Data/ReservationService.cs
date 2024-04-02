using ExploreUmami.Data;
using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.Reservation;
using ExploreUmami.Web.ViewModels.User;
using ExploreUmami.Web.ViewModels.UserVisit;
using Microsoft.EntityFrameworkCore;

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
                                       .Include(r => r.User)
                                       .Include(r => r.Business)
                                       .ToArrayAsync();

            return reservations.Select(r => new ReservationDetailsViewModel
            {
                Id = r.Id,
                Business = new BusinessDetailsReservationViewModel
                {
                    Id = r.Business.Id.ToString(),
                    Title = r.Business.Title,
                    Address = r.Business.Address,
                    PhoneNumber = r.Business.PhoneNumber,
                    ImageUrl = r.Business.ImageUrl,
                },
                User = new UserDetailsViewModel
                {
                    Id = r.User.Id,
                    UserName = r.User.UserName,
                },
                ReservationDate = r.ReservationDate,
                Status = r.Status,
                Notes = r.Notes,
            });
        }

        public async Task<IEnumerable<ReservationDetailsViewModel>> GetReservationsForBusinessAsync(string businessId)
        {
            var reservations = await this.dbContext
                                   .Reservations
                                   .Where(r => r.BusinessId == Guid.Parse(businessId))
                                   .Include(r => r.User)
                                   .Include(r => r.Business)
                                   .Select(r => new ReservationDetailsViewModel
                                   {
                                       Id = r.Id,
                                       Business = new BusinessDetailsReservationViewModel
                                       {
                                           Id = r.Business.Id.ToString(),
                                           Title = r.Business.Title,
                                           Address = r.Business.Address,
                                           PhoneNumber = r.Business.PhoneNumber,
                                           ImageUrl = r.Business.ImageUrl,
                                       },
                                       User = new UserDetailsViewModel
                                       {
                                           Id = r.User.Id,
                                           UserName = r.User.UserName,
                                       },
                                       ReservationDate = r.ReservationDate,
                                       Status = r.Status,
                                       Notes = r.Notes,
                                   })
                                   .ToArrayAsync();

            return reservations;
        }

        public async Task<IEnumerable<ReservationDetailsViewModel>> AllReservationsByUserIdAsync(string userId)
        {
            IEnumerable<ReservationDetailsViewModel> reservations = await this.dbContext
                .Reservations
                .Where(r => r.UserId == Guid.Parse(userId))
                .Include(r => r.User)
                .Include(r => r.Business)
                .Select(r => new ReservationDetailsViewModel
                {
                    Id = r.Id,
                    Business = new BusinessDetailsReservationViewModel
                    {
                        Id = r.Business.Id.ToString(),
                        Title = r.Business.Title,
                        Address = r.Business.Address,
                        PhoneNumber = r.Business.PhoneNumber,
                        ImageUrl = r.Business.ImageUrl,
                    },
                    User = new UserDetailsViewModel
                    {
                        Id = r.User.Id,
                        UserName = r.User.UserName,
                    },
                    ReservationDate = r.ReservationDate,
                    Status = r.Status,
                    Notes = r.Notes,
                })
                .ToArrayAsync();

            return reservations;
        }

        public async Task<IEnumerable<ReservationDetailsViewModel>> AllReservationsByOwnerIdAsync(string ownerId)
        {
            IEnumerable<ReservationDetailsViewModel> reservations = await this.dbContext
                .Reservations
                .Where(r => r.Business.BusinessOwnerId == Guid.Parse(ownerId))
                .Include(r => r.User)
                .Include(r => r.Business)
                .Select(r => new ReservationDetailsViewModel
                {
                    Id = r.Id,
                    Business = new BusinessDetailsReservationViewModel
                    {
                        Id = r.Business.Id.ToString(),
                        Title = r.Business.Title,
                        Address = r.Business.Address,
                        PhoneNumber = r.Business.PhoneNumber,
                        ImageUrl = r.Business.ImageUrl,
                    },
                    User = new UserDetailsViewModel
                    {
                        Id = r.User.Id,
                        UserName = r.User.UserName,
                    },
                    ReservationDate = r.ReservationDate,
                    Status = r.Status,
                    Notes = r.Notes,
                })
                .ToArrayAsync();

            return reservations;
        }
    }
}
