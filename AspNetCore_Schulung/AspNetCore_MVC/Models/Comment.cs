using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }


        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

    }
}
