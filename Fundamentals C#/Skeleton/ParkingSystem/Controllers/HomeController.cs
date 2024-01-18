﻿using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;

namespace ParkingSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(DataAccess.Cars);
        }
    }
}
