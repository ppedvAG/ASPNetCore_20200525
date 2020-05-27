using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class DynamicViewController : Controller
    {
        private readonly BlogDbContext _context;
        public DynamicViewController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            dynamic myDynamicModel = new ExpandoObject();

            myDynamicModel.Blogs = _context.Blog.ToList();
            myDynamicModel.Comments = _context.Comment.ToList();

            return View(myDynamicModel);
        }
    }
}