using PersonalNotesV2.Client.Repository;
using PersonalNotesV2.Shared.Models.Blog;

namespace PersonalNotesV2.Client.Services
{
    public class BlogService : IBlogRepository
    {
        public Task<BlogPost> AddBlogPostAsync(BlogPost item)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogPost>> GetAllBlogPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> GetBlogPostsByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveBlogPostAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> UpdateBlogPostAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
