﻿using Microsoft.AspNetCore.Mvc;
using PestKitProject.DAL;

namespace PestKitProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
