using LeHuuToan_2001206939_LTW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LeHuuToan_2001206939_LTW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bai1()
        {
            List<string> listName = new List<string>() { 
                "Truong manh Hung",
                "Nguyen Hai Yen",
                "Truong thi Khanh yen",
                "Truong thi HUng ANh",

            };
            return View(listName);
        }
        public IActionResult Bai2()
        {
            List<string> listName = new List<string>() {
                "Cam ",
                "Xoai",
                "coc",
                "oi",

            };
            return View(listName);
        }
        public IActionResult Bai3()
        {
            var user = new Employee();
            return View(user);
        }

        public IActionResult Privacy()
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
