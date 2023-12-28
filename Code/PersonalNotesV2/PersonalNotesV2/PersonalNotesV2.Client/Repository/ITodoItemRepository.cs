using PersonalNotesV2.Shared.Models.Todo;

namespace PersonalNotesV2.Shared.TodoItemRepository
{
    public interface ITodoItemRepository
    {
        Task<TodoItem> AddTodoItemAsync(TodoItem item);
        Task<List<TodoItem>> GetTodoItemsFromContextAsyncAsync();
        Task<TodoItem> GetTodoItemByIdAsync(Guid id);
        Task<TodoItem> DeleteTodoItemAsync(Guid id);
        Task<TodoItem> UpdateTodoItemAsync(TodoItem item);
        Task<bool> UpdateRanksForTodoList(int rank);
        Task<bool> UpdateRankUpOfTodoItem(Guid id);
        Task<bool> UpdateRankDownOfTodoItem(Guid id);
        Task<int> GetTodoItemsCurrentHighestRank();
    }
}
