using Microsoft.AspNetCore.Mvc;
using PestKitProject.DAL;
using PestKitProject.Models;

namespace PestKitProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _db;

        public AuthorController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            
            return View();
        }
    }
}
