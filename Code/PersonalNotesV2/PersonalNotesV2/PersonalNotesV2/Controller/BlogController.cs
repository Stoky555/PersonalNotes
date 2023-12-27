using Microsoft.AspNetCore.Mvc;
using PersonalNotesV2.Client.Repository;
using PersonalNotesV2.Shared.Models.Blog;

namespace PersonalNotesV2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public async Task<ActionResult<List<BlogPost>>> GetAllBlogPostsAsync()
        {
            var todoItem = await _blogRepository.GetAllBlogPostsAsync();

            return Ok(todoItem);
        }

        public async Task<ActionResult<BlogPost>> GetBlogPostByIdAsync(Guid id)
        {
            var blogPost = await _blogRepository.GetBlogPostByIdAsync(id);

            return Ok(blogPost);
        }

        public async Task<ActionResult<BlogPost>> AddBlogPostAsync(BlogPost blogPost)
        {
            var newBlogPost = await _blogRepository.AddBlogPostAsync(blogPost);

            return Ok(newBlogPost);
        }

        public async Task<ActionResult<bool>> DeleteBlogPostAsync(Guid id)
        {
            var deleteBlogPost = await _blogRepository.DeleteBlogPostAsync(id);

            return Ok(deleteBlogPost);
        }

        public async Task<ActionResult<BlogPost>> UpdateBlogPostAsync(BlogPost blogPost)
        {
            var updateBlogPost = await _blogRepository.UpdateBlogPostAsync(blogPost);

            return Ok(updateBlogPost);
        }
    }
}
