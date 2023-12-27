using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesV2.Shared.Models.Blog
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Image> Images { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
