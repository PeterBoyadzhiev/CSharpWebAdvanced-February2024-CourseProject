using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class BusinessOwner : Controller
    {
        public async Task<IActionResult> Switch()
        {
            return View();
        }
    }
}
