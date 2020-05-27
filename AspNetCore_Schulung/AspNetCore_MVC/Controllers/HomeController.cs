using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCore_MVC.Models;
using Microsoft.AspNetCore.Http;
using DependencyInjections.GuteBeispiel;
using Serilog;

namespace AspNetCore_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService _carService;
        public HomeController(ICarService carService)
        {

            _carService = carService;
        }

        public IActionResult Index()
        {
            Log.Information("HomeController.Index wurde aufgerufen");
            _carService.BuyCar(new Car { Brand = "Fiat", Color = "Blau" });
            return View();
        }

        public IActionResult Privacy()
        {
            
            //string name = HttpContext.Session.GetString("Name");
            //int age = HttpContext.Session.GetInt32("Age").Value;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
