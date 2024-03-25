using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class BusinessController : Controller
    {
        [AllowAnonymous]
        public IActionResult All()
        {
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> Add()
        {
            return View();
        }

        public IActionResult BusinessPerCountry() 
        { 
            return View(); 
        }
    }
}
