﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmami.Web.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
