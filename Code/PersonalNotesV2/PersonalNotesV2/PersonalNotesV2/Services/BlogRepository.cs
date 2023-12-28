using Microsoft.EntityFrameworkCore;
using PersonalNotesV2.Client.Repository;
using PersonalNotesV2.Data;
using PersonalNotesV2.Shared.Models.Blog;

namespace PersonalNotesV2.Services
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<BlogArticle> AddBlogPostAsync(BlogArticle blogPost)
        {
            if (blogPost == null) throw new ArgumentNullException("public async Task<BlogPost> AddBlogPostAsync(BlogPost blogPost)");

            var newTodoItem = _context.BlogPosts.Add(blogPost).Entity;
            await _context.SaveChangesAsync();

            return newTodoItem;
        }

        public async Task<bool> DeleteBlogPostAsync(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("public async Task<bool> DeleteBlogPostAsync(Guid id)");

            var blogPost = await _context.BlogPosts.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (blogPost == null) return false;

            _context.BlogPosts.Remove(blogPost);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<List<BlogArticle>> GetAllBlogPostsAsync()
        {
            var blogPosts = await _context.BlogPosts.ToListAsync();

            return blogPosts;
        }

        public async Task<BlogArticle> GetBlogPostByIdAsync(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("public async Task<BlogPost> GetBlogPostsByIdAsync(Guid id)");

            var blogPost = await _context.BlogPosts.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (blogPost == null) return null;

            return blogPost;
        }

        public async Task<BlogArticle> UpdateBlogPostAsync(BlogArticle blogPost)
        {
            if (blogPost == null) throw new ArgumentNullException("public async Task<BlogPost> UpdateBlogPostAsync(BlogPost blogPost)");

            var newTodoItem = _context.BlogPosts.Update(blogPost).Entity;
            await _context.SaveChangesAsync();

            return newTodoItem;
        }
    }
}
