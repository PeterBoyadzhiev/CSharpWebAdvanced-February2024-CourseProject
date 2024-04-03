using ExploreUmami.Data;
using ExploreUmami.Data.Models;
using ExploreUmami.Data.Models.Enums;
using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Services.Data.Models.Reservation;
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

        public async Task<ReservationFilterAndPageModel> GetReservationsByFilterForOwnerAsync(ReservationFilterViewModel filterModel, string ownerId)
        {

            var query = this.dbContext.Reservations
                .Where(r => r.Business.BusinessOwnerId == Guid.Parse(ownerId))
                .Include(r => r.User)
                .Include(r => r.Business)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterModel.SearchTerm))
            {
                query = query.Where(r => r.User.UserName.Contains(filterModel.SearchTerm) ||
                                                        r.Business.Title.Contains(filterModel.SearchTerm));
            }

            if (filterModel.Status != null)
            {
                query = query.Where(r => r.Status == (ReservationStatus)Enum.Parse(typeof(ReservationStatus), filterModel.Status));
            }

            var totalReservations = await query.CountAsync();

            var reservations = await query
                .Skip((filterModel.CurrentPage - 1) * filterModel.ReservationsPerPage)
                .Take(filterModel.ReservationsPerPage)
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

            return new ReservationFilterAndPageModel
            {
                Reservations = reservations,
                TotalReservationsCount = totalReservations,
            };
        }

        public async Task<ReservationFilterAndPageModel> GetReservationsByFilterForUserAsync(ReservationFilterViewModel filterModel, string userId)
        {
            var query = this.dbContext.Reservations
                .Where(r => r.UserId == Guid.Parse(userId))
                .Include(r => r.User)
                .Include(r => r.Business)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterModel.SearchTerm))
            {
                query = query.Where(r => r.User.UserName.Contains(filterModel.SearchTerm) ||
                                                        r.Business.Title.Contains(filterModel.SearchTerm));
            }

            if (filterModel.Status != null)
            {
                query = query.Where(r => r.Status == (ReservationStatus)Enum.Parse(typeof(ReservationStatus), filterModel.Status.ToString()));
            }

            var totalReservations = await query.CountAsync();

            var reservations = await query
                .Skip((filterModel.CurrentPage - 1) * filterModel.ReservationsPerPage)
                .Take(filterModel.ReservationsPerPage)
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

            return new ReservationFilterAndPageModel
            {
                Reservations = reservations,
                TotalReservationsCount = totalReservations,
            };
        }

        public async Task MakeReservationAsync(MakeReservationFormModel model, string userId, string businessId)
        {
            Reservation reservation = new Reservation
            {
                BusinessId = Guid.Parse(businessId),
                UserId = Guid.Parse(userId),
                ReservationDate = model.ReservationDate,
                Status = ReservationStatus.Pending,
                Notes = model.Notes,
            };

            await this.dbContext.Reservations.AddAsync(reservation);
            await this.dbContext.SaveChangesAsync();
        }

        public Task<bool> UserHasIncompleteReservationAsync(string userId)
        {
            return this.dbContext.Reservations.AnyAsync(r => r.UserId == Guid.Parse(userId) && (r.Status == ReservationStatus.Pending || r.Status == ReservationStatus.Confirmed));
        }
    }
}
