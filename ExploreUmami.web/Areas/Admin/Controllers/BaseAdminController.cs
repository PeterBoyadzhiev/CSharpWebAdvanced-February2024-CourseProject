using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static ExploreUmami.Common.AppConstantsGeneral;

namespace ExploreUmami.Web.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class BaseAdminController : Controller
    {

    }
}
