﻿using ExploreUmami.Web.ViewModels.Business;
using ExploreUmami.Web.ViewModels.UserVisit;

namespace ExploreUmami.Services.Data.Interfaces
{
    public interface IUserVisitService
    {
        Task AddUserVisitForCompletedReservationAsync(Guid reservationId, string? notes);

        Task<IEnumerable<UserVisitDetailsViewModel>> GetUserVisitsAsync(string userId);

        Task<IEnumerable<UserVisitDetailsViewModel>> GetBusinessVisitsPerOwnerAsync(string ownerId);

        Task<bool> UserHasVisitAsync(string userId, string businessId);
    }
}
