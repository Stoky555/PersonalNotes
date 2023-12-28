using PersonalNotesV2.Shared.Models.Blog;

namespace PersonalNotesV2.Client.Repository
{
    public interface IBlogRepository
    {
        Task<List<BlogArticle>> GetAllBlogPostsAsync();
        Task<BlogArticle> GetBlogPostByIdAsync(Guid id);
        Task<BlogArticle> AddBlogPostAsync(BlogArticle blogPost);
        Task<bool> DeleteBlogPostAsync(Guid id);
        Task<BlogArticle> UpdateBlogPostAsync(BlogArticle blogPost);

    }
}
