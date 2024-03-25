using ExploreUmami.Services.Data.Interfaces;
using ExploreUmami.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExploreUmami.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBusinessService businessService;

        public HomeController(IBusinessService businessService)
        {
            this.businessService = businessService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
