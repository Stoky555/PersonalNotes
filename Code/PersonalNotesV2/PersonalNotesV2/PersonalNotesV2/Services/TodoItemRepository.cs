using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PersonalNotesV2.Data;
using PersonalNotesV2.Shared.Models.Todo;
using PersonalNotesV2.Shared.TodoItemRepository;

namespace PersonalNotesV2.Services
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly ApplicationDbContext _context;

        public TodoItemRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<TodoItem> AddTodoItemAsync(TodoItem item)
        {
            if(item == null) throw new ArgumentNullException("public async Task<TodoItem> AddTodoItemAsync(TodoItem item)");

            var newTodoItem = _context.TodoItems.Add(item).Entity;
            await _context.SaveChangesAsync();

            return newTodoItem;
        }

        public async Task<TodoItem?> DeleteTodoItemAsync(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("public Task<TodoItem> DeleteTodoItemAsync(Guid id)");

            var todoItem = await _context.TodoItems.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (todoItem == null) return null;

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            await UpdateRanksForTodoList(todoItem.Rank);

            return todoItem;
        }

        public async Task<TodoItem>? GetTodoItemByIdAsync(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("public Task<TodoItem> GetTodoItemAsync(Guid id)");

            var todoItem = await _context.TodoItems.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (todoItem == null) return null;

            return todoItem;
        }

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            var todoItems = await _context.TodoItems.ToListAsync();

            return todoItems;
        }

        public int GetTodoItemsCurrentHighestRank()
        {
            var todoItemsList = new List<TodoItem>();
            int highestRank = 0;

            if (_context.TodoItems.Any())
            {
                int? highestRankNullable = _context.TodoItems.Max(x => x.Rank);
                highestRank = highestRankNullable ?? 0; // Providing 0 as a default value if highestRankNullable is null
            }
            
            return highestRank;
        }

        public async Task<bool> UpdateRankDownOfTodoItem(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("public Task<TodoItem> UpdateRankDownOfTodoItem(Guid id)");

            var todoItem = _context.TodoItems.Where(i => i.Id == id).FirstOrDefault();

            var exHigherRank = _context.TodoItems.Where(r => r.Rank == todoItem.Rank + 1).FirstOrDefault();

            if (exHigherRank == null)
            {
                throw new Exception("Cannot update rank, todoitem does not exists.");
            }

            exHigherRank.Rank--;
            exHigherRank.UpdatedDate = DateTime.Now;

            todoItem.Rank++;
            todoItem.UpdatedDate = DateTime.Now;

            _context.TodoItems.Update(todoItem);
            _context.TodoItems.Update(exHigherRank);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateRankUpOfTodoItem(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentNullException("public Task<TodoItem> UpdateRankUpOfTodoItem(Guid id)");

            var todoItem = _context.TodoItems.Where(i => i.Id == id).FirstOrDefault();

            var exHigherRank = _context.TodoItems.Where(r => r.Rank == todoItem.Rank - 1).FirstOrDefault();

            if (exHigherRank == null)
            {
                throw new Exception("Cannot update rank, todoitem does not exists.");
            }

            exHigherRank.Rank++;
            exHigherRank.UpdatedDate = DateTime.Now;

            todoItem.Rank--;
            todoItem.UpdatedDate = DateTime.Now;

            _context.TodoItems.Update(todoItem);
            _context.TodoItems.Update(exHigherRank);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateRanksForTodoList(int rank)
        {
            List<TodoItem> todoItemsToChange = new List<TodoItem>();

            foreach (var currentElement in _context.TodoItems.Where(r => r.Rank > rank).OrderBy(r => r.Rank))
            {
                currentElement.Rank = currentElement.Rank - 1;
                currentElement.UpdatedDate = DateTime.Now;
                todoItemsToChange.Add(currentElement);
            }

            foreach (var currentElement in todoItemsToChange)
            {
                _context.TodoItems.Update(currentElement);
            }

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<TodoItem?> UpdateTodoItemAsync(TodoItem item)
        {
            if (item == null) throw new ArgumentNullException("public Task<TodoItem> UpdateTodoItemAsync(TodoItem item)");

            var newTodoItem = _context.TodoItems.Update(item).Entity;
            await _context.SaveChangesAsync();

            return newTodoItem;
        }
    }
}
