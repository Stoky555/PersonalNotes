using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalNotesV2.Shared.Models.Blog
{
    public class UserUploadedFile
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Base64data { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
    }
}
