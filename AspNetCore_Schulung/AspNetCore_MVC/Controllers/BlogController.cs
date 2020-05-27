using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCore_MVC.Data;
using AspNetCore_MVC.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace AspNetCore_MVC.Controllers
{
    // Beispiel Controller + EF access
    //public class BlogController : Controller
    //{
    //    private readonly BlogDbContext _context;

    //    public BlogController(BlogDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // GET: Blog
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _context.Blog.ToListAsync());
    //    }

    //    // GET: Blog/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var blog = await _context.Blog
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (blog == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(blog);
    //    }

    //    // GET: Blog/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Blog/Create
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Id,Title,Content,CreatedBy,CreatedAt")] Blog blog)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            //Variante1
    //            //_context.Add(blog);
    //            // Variante 2
    //            _context.Blog.Add(blog);
    //            await _context.SaveChangesAsync();
    //            //return RedirectToAction(nameof(Index));

    //            return RedirectToAction("Index", "Home");
    //        }
    //        return View(blog);
    //    }

    //    // GET: Blog/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var blog = await _context.Blog.FirstOrDefaultAsync(m => m.Id == id);


    //        if (blog == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(blog);
    //    }

    //    // POST: Blog/Edit/5
    //    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    //    // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,CreatedBy,CreatedAt")] Blog blog)
    //    {
    //        if (id != blog.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                //Variante 1
    //                //
    //                //_context.Attach(blog).State = EntityState.Modified; 

    //                //Variante 2
    //                _context.Update(blog);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!BlogExists(blog.Id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(blog);
    //    }

    //    // GET: Blog/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var blog = await _context.Blog
    //            .FirstOrDefaultAsync(m => m.Id == id);
    //        if (blog == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(blog);
    //    }

    //    // POST: Blog/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var blog = await _context.Blog.FindAsync(id);
    //        _context.Blog.Remove(blog);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool BlogExists(int id)
    //    {
    //        return _context.Blog.Any(e => e.Id == id);
    //    }
    //}


    public class BlogController : Controller
    {


        public BlogController()
        {
        }

        // GET: Blog
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = new List<Blog>();

            string url = "https://localhost:44388/api/Blogs";


            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    //Hier wandel ich das Ergebnis in JSON um
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    //Deserialsiere
                    blogs = JsonConvert.DeserializeObject<List<Blog>>(apiResponse);
                }

                if (blogs == null)
                    return NotFound();
            }

            return View(blogs);
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = null;
            string url = "https://localhost:44388/api/Blogs/" + id.Value;

            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    blog = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }

            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Blog/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,CreatedBy,CreatedAt")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                //Variante1
                //_context.Add(blog);
                // Variante 2

                string json = JsonConvert.SerializeObject(blog);

                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var url = "https://localhost:44388/api/Blogs";

                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(url, data);
                    string result = response.Content.ReadAsStringAsync().Result;
                }

                return RedirectToAction("Index", "Home");
            }
            return View(blog);
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = null;
            string url = "https://localhost:44388/api/Blogs/" + id.Value;

            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    blog = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }



            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,CreatedBy,CreatedAt")] Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(blog);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var url = "https://localhost:44388/api/Blogs/" + blog.Id;

                    using var client = new HttpClient();

                    var response = await client.PutAsync(url, data);
                    string result = response.Content.ReadAsStringAsync().Result;
                }
                catch (Exception)
                {
                    //Schreibe Exception in LogFile
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = null;
            string url = "https://localhost:44388/api/Blogs/" + id.Value;

            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    blog = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }

            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var url = "https://localhost:44388/api/Blogs/" + id;

            using var client = new HttpClient();

            var response = await client.DeleteAsync(url);
            string result = response.Content.ReadAsStringAsync().Result;

           
            return RedirectToAction(nameof(Index));
        }

       
    }
}
