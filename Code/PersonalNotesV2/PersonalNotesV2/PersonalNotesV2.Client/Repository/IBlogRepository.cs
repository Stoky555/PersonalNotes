using PersonalNotesV2.Shared.Models.Blog;

namespace PersonalNotesV2.Client.Repository
{
    public interface IBlogRepository
    {
        Task<List<BlogPost>> GetAllBlogPostsAsync();
        Task<BlogPost> GetBlogPostByIdAsync(Guid id);
        Task<BlogPost> AddBlogPostAsync(BlogPost blogPost);
        Task<bool> DeleteBlogPostAsync(Guid id);
        Task<BlogPost> UpdateBlogPostAsync(BlogPost blogPost);

    }
}
