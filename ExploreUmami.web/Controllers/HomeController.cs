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

        public async Task<IActionResult> All(int pageNumber = 1, int pageSize = 3)
        {
            string pageNumberString = HttpContext.Request.Query["pageNumber"];
            pageNumber = int.TryParse(pageNumberString, out int parsedPageNumber) ? parsedPageNumber : 1;

            IEnumerable<BusinessViewModel> businesses = await this.businessService.GetBusinessesAsync();

            int totalBusinesses = businesses.Count(); // Get total number of businesses
            int skip = (pageNumber - 1) * pageSize;
            businesses = businesses.Skip(skip).Take(pageSize);

            var viewModel = new AllViewModel
            {
                CurrentPage = pageNumber,
                Businesses = businesses.Select(b => new BusinessViewModel
                {
                    Id = b.Id.ToString(),
                    Title = b.Title,
                    ImageURL = b.ImageURL,
                }).ToList(),
                TotalPages = (int)Math.Ceiling((double)totalBusinesses / pageSize)
            };

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
