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

        public async Task<TodoItem> DeleteTodoItemAsync(Guid id)
        {
            var deletedItem = await _httpClient.DeleteAsync("api/TodoItem/Delete-TodoItem/" + id);
            var response = await deletedItem.Content.ReadFromJsonAsync<TodoItem>();
            return response;
        }

        public async Task<TodoItem> GetTodoItemByIdAsync(Guid id)
        {
            var allTodoItems = await _httpClient.GetAsync("api/TodoItem/Single-TodoItemById/" + id);
            var response = await allTodoItems.Content.ReadFromJsonAsync<TodoItem>();
            return response;
        }

        public async Task<List<TodoItem>> GetTodoItemsFromContextAsyncAsync()
        {
            var allTodoItems = await _httpClient.GetAsync("api/TodoItem/All-TodoItems");
            var response = await allTodoItems.Content.ReadFromJsonAsync<List<TodoItem>>();
            return response;
        }

        public async Task<int> GetTodoItemsCurrentHighestRank()
        {
            var highestRank = await _httpClient.GetAsync("api/TodoItem/Get-TodoItemHighestRank");
            var response = await highestRank.Content.ReadFromJsonAsync<int>();
            return response;
        }

        public async Task<bool> UpdateRankDownOfTodoItem(Guid id)
        {
            var rankUpdated = await _httpClient.GetAsync("api/TodoItem/Update-TodoItemRankDown/" + id);
            var response = await rankUpdated.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<bool> UpdateRanksForTodoList(int rank)
        {
            var updatedRanks = await _httpClient.GetAsync("api/TodoItem/Update-TodoItemRanks/" + rank);
            var response = await updatedRanks.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<bool> UpdateRankUpOfTodoItem(Guid id)
        {
            var updatedTodoItem = await _httpClient.GetAsync("api/TodoItem/Update-TodoItemRankUp/" + id);
            var response = await updatedTodoItem.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<TodoItem> UpdateTodoItemAsync(TodoItem item)
        {
            var updatedTodoItem = await _httpClient.PutAsJsonAsync("api/TodoItem/Update-TodoItem", item);
            var response = await updatedTodoItem.Content.ReadFromJsonAsync<TodoItem>();
            return response;
        }
    }
}
