﻿using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.TicketingUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
