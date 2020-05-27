using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Das Feld Titel benötigt eine Eingabe")]
        public string Title { get; set; }

        //[StringLength(20, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(ValidationResources))]
        [MaxLength(20, ErrorMessage = "Content darf maximal 20 Zeichen lang sein")]
        public string Content { get; set; }

        [Required]
        [DisplayName("Erstellt von")]
        public string CreatedBy { get; set; }

        [Required]
        [DisplayName("Erstellt am")]
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
