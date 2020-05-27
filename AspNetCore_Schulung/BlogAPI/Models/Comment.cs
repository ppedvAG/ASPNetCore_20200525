using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models
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
