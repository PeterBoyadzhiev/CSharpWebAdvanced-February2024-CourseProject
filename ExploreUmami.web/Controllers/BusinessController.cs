﻿using Microsoft.AspNetCore.Authorization;
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

        public IActionResult BusinessPerCountry() 
        { 
            return View(); 
        }
    }
}