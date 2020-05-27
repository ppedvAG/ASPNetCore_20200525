using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AspNetCore_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class StateManagementController : Controller
    {
        public IActionResult Index()
        {
            ViewData["CoronaID"] = 123;
            ViewData["IrgendEinEintrag"] = "Das Wetter ist schön";
            return View();
        }

        public IActionResult ViewBagSample()
        {
            ViewBag.UserId = 101;
            ViewBag.Name = "John";
            ViewBag.Age = 31;

            return View();
        }

        public IActionResult TempDataFirst()
        {
            //ViewData["CoronaID"] = 987;
            ViewBag.CoronaID = 111;
            TempData["UserId"] = 777;

            IList<Blog> studentList = new List<Blog>();
            studentList.Add(new Blog() { Title = "abc"});
            studentList.Add(new Blog() { Title = "abc" });
            studentList.Add(new Blog() { Title = "abc" });

            ViewData["students"] = studentList;

            return View();
        }

        public IActionResult TempDataSecond()
        {
            var userId = TempData["UserId"] ?? null;
            TempData.Keep();
            return View();
        }

       

        public IActionResult SessionInit()
        {
            //Beispiel1 - Initialisieren mit einfachen Variablen
            HttpContext.Session.SetString("Name", "Andre");
            HttpContext.Session.SetInt32("Age", 33);

            //Beispiel2

            Blog blog = new Blog();
            blog.Title = "Microsoft Developer Magazin wurde eingestellt";
            blog.Content = "Seit November 2019 bringt Microsoft sein Entwicklermagazin nicht mehr heraus";
            blog.CreatedAt = DateTime.Now;
            blog.CreatedBy = "Bill Gates";
            blog.Id = 111;

            string jsonString = JsonSerializer.Serialize(blog);
            HttpContext.Session.SetString("BlogObj", jsonString);

            return View();
        }

        public IActionResult SessionRead()
        {
            //Beispiel1 - Lesen
            string name = HttpContext.Session.GetString("Name");
            int age = HttpContext.Session.GetInt32("Age").Value;

            string jsonString =  HttpContext.Session.GetString("BlogObj");
            Blog blog = JsonSerializer.Deserialize<Blog>(jsonString);
            return View();
        }
    }
}