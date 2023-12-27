using PersonalNotesV2.Client.Repository;
using PersonalNotesV2.Shared.Models.Blog;
using PersonalNotesV2.Shared.Models.Todo;
using System.Net.Http;
using System.Net.Http.Json;

namespace PersonalNotesV2.Client.Services
{
    public class BlogService : IBlogRepository
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<BlogPost> AddBlogPostAsync(BlogPost blogPost)
        {
            var newBlogPost = await _httpClient.PostAsJsonAsync("api/Blog/Add-BlogPost", blogPost);
            var response = await newBlogPost.Content.ReadFromJsonAsync<BlogPost>();

            return response;
        }

        public async Task<List<BlogPost>> GetAllBlogPostsAsync()
        {
            var allBlogPosts = await _httpClient.GetAsync("api/Blog/All-BlogPosts");
            var response = await allBlogPosts.Content.ReadFromJsonAsync<List<BlogPost>>();
            return response;
        }

        public async Task<BlogPost> GetBlogPostByIdAsync(Guid id)
        {
            var blogPostById = await _httpClient.GetAsync("api/Blog/Single-BlogPost/" + id);
            var response = await blogPostById.Content.ReadFromJsonAsync<BlogPost>();
            return response;
        }

        public async Task<bool> DeleteBlogPostAsync(Guid id)
        {
            var deletedBlogPost = await _httpClient.DeleteAsync("api/Blog/Delete-BlogPost/" + id);
            var response = await deletedBlogPost.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<BlogPost> UpdateBlogPostAsync(BlogPost blogPost)
        {
            var updatedBlogPost = await _httpClient.PutAsJsonAsync("api/TodoItem/Update-BlogPost", blogPost);
            var response = await updatedBlogPost.Content.ReadFromJsonAsync<BlogPost>();
            return response;
        }
    }
}
