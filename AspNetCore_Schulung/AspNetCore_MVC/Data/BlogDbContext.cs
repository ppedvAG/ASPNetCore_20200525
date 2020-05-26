using AspNetCore_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Data
{
    public class BlogDbContext : DbContext 
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            :base (options)
        {

        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
