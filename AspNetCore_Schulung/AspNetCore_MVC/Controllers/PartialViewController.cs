using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Data;
using AspNetCore_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class PartialViewController : Controller
    {
        private readonly BlogDbContext _context;

        public PartialViewController(BlogDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PartialViewBasicSample()
        {
            return View();
        }

        public IActionResult ShowPartialViewWithViewModel()
        {
            BlogCommentViewModel vm = new BlogCommentViewModel();
            vm.Blogs = _context.Blog.ToList();
            vm.Comments = _context.Comment.ToList();
            return View(vm);
        }

        public IActionResult LoadPartialOverGetMethod()
        {
            return View();
        }

        public IActionResult OnGetMyPartial() =>
            new PartialViewResult
            {
                ViewName = "_Zeit",
                ViewData = ViewData
            };
    }
}