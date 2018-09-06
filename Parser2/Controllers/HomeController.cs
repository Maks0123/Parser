using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parser2.Models;

namespace Parser2.Controllers
{
    public class HomeController : Controller
    {
        LaptopContext db;
        public HomeController(LaptopContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Laptops.ToList());
        }

        [HttpGet]
        public IActionResult ViewLeptop(int id)
        {
            ViewBag.LaptopId = id;
            return View();
        }

    }
}
