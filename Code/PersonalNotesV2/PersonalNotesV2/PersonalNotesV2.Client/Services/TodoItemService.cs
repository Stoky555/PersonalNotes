using PersonalNotesV2.Shared.Models.Todo;
using PersonalNotesV2.Shared.TodoItemRepository;
using System.Net.Http.Json;

namespace PersonalNotesV2.Client.Services
{
    public class TodoItemService : ITodoItemRepository
    {
        private readonly HttpClient _httpClient;

        public TodoItemService(HttpClient httpClient)
        {

            this._httpClient = httpClient;
        }

        public async Task<TodoItem> AddTodoItemAsync(TodoItem item)
        {
            var todoItem = await _httpClient.PostAsJsonAsync("api/TodoItem/Add-TodoItem", item);
            var response = await todoItem.Content.ReadFromJsonAsync<TodoItem>();

            return response;
        }

        public Task<TodoItem> DeleteTodoItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> GetTodoItemByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            var allTodoItems = await _httpClient.GetAsync("api/TodoItem/All-TodoItems");
            var response = await allTodoItems.Content.ReadFromJsonAsync<List<TodoItem>>();
            return response;
        }

        public async Task<int> GetTodoItemsCurrentHighestRank()
        {
            var allTodoItems = await _httpClient.GetAsync("api/TodoItem/Get-TodoItemHighestRank");
            var response = await allTodoItems.Content.ReadFromJsonAsync<int>();
            return response;
        }

        public async Task<bool> UpdateRankDownOfTodoItem(Guid id)
        {
            var allTodoItems = await _httpClient.GetAsync("api/TodoItem/Update-TodoItemRankDown");
            var response = await allTodoItems.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<bool> UpdateRanksForTodoList(int rank)
        {
            var allTodoItems = await _httpClient.GetAsync("api/TodoItem/Update-TodoItemRanks");
            var response = await allTodoItems.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<bool> UpdateRankUpOfTodoItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<TodoItem> UpdateTodoItemAsync(TodoItem item)
        {
            throw new NotImplementedException();
        }

        int ITodoItemRepository.GetTodoItemsCurrentHighestRank()
        {
            throw new NotImplementedException();
        }
    }
}
