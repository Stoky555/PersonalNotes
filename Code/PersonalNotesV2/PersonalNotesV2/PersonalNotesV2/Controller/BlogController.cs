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

        [HttpGet("All-BlogPosts")]
        public async Task<ActionResult<List<BlogArticle>>> GetAllBlogPostsAsync()
        {
            var todoItem = await _blogRepository.GetAllBlogPostsAsync();

            return Ok(todoItem);
        }

        [HttpGet("Single-BlogPost/{id}")]
        public async Task<ActionResult<BlogArticle>> GetBlogPostByIdAsync(Guid id)
        {
            var blogPost = await _blogRepository.GetBlogPostByIdAsync(id);

            return Ok(blogPost);
        }

        [HttpPost("Add-BlogPost")]
        public async Task<ActionResult<BlogArticle>> AddBlogPostAsync(BlogArticle blogPost)
        {
            var newBlogPost = await _blogRepository.AddBlogPostAsync(blogPost);

            return Ok(newBlogPost);
        }

        [HttpDelete("Delete-BlogPost/{id}")]
        public async Task<ActionResult<bool>> DeleteBlogPostAsync(Guid id)
        {
            var deleteBlogPost = await _blogRepository.DeleteBlogPostAsync(id);

            return Ok(deleteBlogPost);
        }

        [HttpPut("Update-BlogPost")]
        public async Task<ActionResult<BlogArticle>> UpdateBlogPostAsync(BlogArticle blogPost)
        {
            var updateBlogPost = await _blogRepository.UpdateBlogPostAsync(blogPost);

            return Ok(updateBlogPost);
        }
    }
}
