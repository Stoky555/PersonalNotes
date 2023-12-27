using PersonalNotesV2.Shared.Models.Blog;

namespace PersonalNotesV2.Client.Repository
{
    public interface IBlogRepository
    {
        Task<List<BlogPost>> GetAllBlogPostsAsync();
        Task<BlogPost> GetBlogPostsByIdAsync();
        Task<BlogPost> AddBlogPostAsync(BlogPost item);
        Task<bool> RemoveBlogPostAsync(Guid id);
        Task<BlogPost> UpdateBlogPostAsync(Guid id);

    }
}
