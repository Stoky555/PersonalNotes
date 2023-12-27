using Microsoft.AspNetCore.Mvc;
using PersonalNotesV2.Shared.Models.Todo;
using PersonalNotesV2.Shared.TodoItemRepository;

namespace PersonalNotesV2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemRepository _todoItemRepository;

        public TodoItemController(ITodoItemRepository todoItemRepository)
        {
            this._todoItemRepository = todoItemRepository;
        }

        [HttpPost("Add-TodoItem")]
        public async Task<ActionResult<TodoItem>> AddNewTodoItemAsync(TodoItem todoItem)
        {
            var newTodoItem = await _todoItemRepository.AddTodoItemAsync(todoItem);

            return Ok(newTodoItem);
        }

        [HttpDelete("Delete-TodoItem/{id}")]
        public async Task<ActionResult<TodoItem>> DeleteTodoItemAsync(Guid id)
        {
            var deleteTodoItem = await _todoItemRepository.DeleteTodoItemAsync(id);

            return Ok(deleteTodoItem);
        }

        [HttpGet("All-TodoItems")]
        public async Task<ActionResult<List<TodoItem>>> GetAllTodoItemsAsync()
        {
            var todoItem = await _todoItemRepository.GetTodoItemsFromContextAsyncAsync();

            return Ok(todoItem);
        }

        [HttpGet("Single-TodoItemById/{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItemByIdAsync(Guid id)
        {
            var todoItem = await _todoItemRepository.GetTodoItemByIdAsync(id);

            return Ok(todoItem);
        }

        [HttpPut("Update-TodoItem")]
        public async Task<ActionResult<TodoItem>> UpdateTodoItemsAsync(TodoItem todoItem)
        {
            var updateTodoItem = await _todoItemRepository.UpdateTodoItemAsync(todoItem);

            return Ok(updateTodoItem);
        }

        [HttpGet("Update-TodoItemRanks/{rank}")]
        public async Task<ActionResult<TodoItem>> UpdateRanksForTodoList(int rank)
        {
            var updateRank = await _todoItemRepository.UpdateRanksForTodoList(rank);

            return Ok(updateRank);
        }

        [HttpGet("Update-TodoItemRankUp/{id}")]
        public async Task<ActionResult<TodoItem>> UpdateRankUpForTodoList(Guid id)
        {
            var updateRank = await _todoItemRepository.UpdateRankUpOfTodoItem(id);

            return Ok(updateRank);
        }

        [HttpGet("Update-TodoItemRankDown/{id}")]
        public async Task<ActionResult<TodoItem>> UpdateRankDownForTodoList(Guid id)
        {
            var updateRank = await _todoItemRepository.UpdateRankDownOfTodoItem(id);

            return Ok(updateRank);
        }

        [HttpGet("Get-TodoItemHighestRank")]
        public async Task<ActionResult<TodoItem>> GetTodoItemHighestRank()
        {
            var currentHiighestRank = await _todoItemRepository.GetTodoItemsCurrentHighestRank();

            return Ok(currentHiighestRank);
        }
    }
}
