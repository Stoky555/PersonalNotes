using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesV2.Shared.Models.Blog
{
    public class BlogArticle
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<UserUploadedFile> Images { get; set; } = new List<UserUploadedFile>();
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
