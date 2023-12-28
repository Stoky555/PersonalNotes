using Microsoft.AspNetCore.Identity;
using PersonalNotesV2.Shared.Models.Blog;
using PersonalNotesV2.Shared.Models.Todo;

namespace PersonalNotesV2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
        public List<BlogArticle> BlogPost { get; set; } = new List<BlogArticle>();
    }

}
