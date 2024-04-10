using System.Security.Claims;
using static ExploreUmami.Common.AppConstantsGeneral;

namespace ExploreUmami.Web.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.NameIdentifier);

        public static bool isAdmin(this ClaimsPrincipal user)
            => user.IsInRole(AdminRoleName);
    }
}
