using Microsoft.EntityFrameworkCore;
using PersonalNotes.Data;
using PersonalNotes.Models.Todo;

namespace PersonalNotes.Services
{
    public class TodoListService
    {
        private IDbContextFactory<PersonalNotesDbContext> _dbContextFactory;

        public TodoListService(IDbContextFactory<PersonalNotesDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddTodoItem(TodoItem item)
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                context.TodoItems.Add(item);
                context.SaveChanges();
            }
        }

        public void GetTodoList()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var todoItem = context.TodoItems.FirstOrDefault();
            }
        }

        public TodoItem GetTodoItemById(Guid id)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var todoItem = context.TodoItems.SingleOrDefault(x => x.Id == id);
                return todoItem;
            }
        }

        ////public void UpdateTodoItemDescriptionById(Guid id, string description) 
        ////{ 
        ////    var todoItem = GetTodoItemById(id);
        ////    if (todoItem == null)
        ////    {
        ////        throw new Exception("TodoItem does not exist. Cannot update");
        ////    }
        ////    todoItem.Description = description;
        ////    using (var context = _dbContextFactory.CreateDbContext())
        ////    {
        ////        context.Update(todoItem);
        ////        context.SaveChanges();
        ////    }
        ////}

        public void RemoveTodoItemById(Guid id)
        {
            var todoItem = GetTodoItemById(id);

            if (todoItem == null)
            {
                throw new Exception("TodoItem does not exist. Cannot delete");
            }

            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.TodoItems.Remove(todoItem);
                context.SaveChanges();
            }

            UpdateRanksForTodoList(todoItem.Rank);
        }

        public void UpdateTodoItem(TodoItem todoItem)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(todoItem);
                context.SaveChanges();
            }
        }

        private void UpdateRanksForTodoList(int rank)
        {
            List<TodoItem> todoItemsToChange = new List<TodoItem>();

            foreach (var currentElement in GetTodoItems().Where(r => r.Rank > rank).OrderBy(r => r.Rank))
            {
                currentElement.Rank = currentElement.Rank - 1;
                currentElement.UpdatedDate = DateTime.Now;
                todoItemsToChange.Add(currentElement);
            }

            using (var context = _dbContextFactory.CreateDbContext())
            {
                foreach (var currentElement in todoItemsToChange)
                {
                    context.TodoItems.Update(currentElement);
                }

                context.SaveChanges();
            }
        }

        public void UpdateRankUpOfTodoItem(Guid id)
        {
            var todoItem = GetTodoItemById(id);

            using (var context = _dbContextFactory.CreateDbContext())
            {
                var exHigherRank = context.TodoItems.Where(r => r.Rank == todoItem.Rank - 1).FirstOrDefault();

                if(exHigherRank == null) 
                {
                    throw new Exception("Cannot update rank, todoitem does not exists.");
                }

                exHigherRank.Rank++;
                exHigherRank.UpdatedDate = DateTime.Now;

                todoItem.Rank--;
                todoItem.UpdatedDate = DateTime.Now;

                context.TodoItems.Update(todoItem);
                context.TodoItems.Update(exHigherRank);

                context.SaveChanges();
            }
        }

        public void UpdateRankDownOfTodoItem(Guid id)
        {
            var todoItem = GetTodoItemById(id);

            using (var context = _dbContextFactory.CreateDbContext())
            {
                var exHigherRank = context.TodoItems.Where(r => r.Rank == todoItem.Rank + 1).FirstOrDefault();

                if (exHigherRank == null)
                {
                    throw new Exception("Cannot update rank, todoitem does not exists.");
                }

                exHigherRank.Rank--;
                exHigherRank.UpdatedDate = DateTime.Now;

                todoItem.Rank++;
                todoItem.UpdatedDate = DateTime.Now;

                context.TodoItems.Update(todoItem);
                context.TodoItems.Update(exHigherRank);

                context.SaveChanges();
            }
        }

        public List<TodoItem> GetTodoItems()
        {
            var result = new List<TodoItem>();

            using (var context = _dbContextFactory.CreateDbContext())
            {
                var items = context.TodoItems.OrderBy(x => x.Rank).ToList();
                result = items;
            }

            return result;
        }

        public int GetTodoItemsCurrentHighestRank()
        {
            var todoItemsList = new List<TodoItem>();

            int highestRank = 0;

            using (var context = _dbContextFactory.CreateDbContext())
            {
                if (context.TodoItems.Any())
                {
                    int? highestRankNullable = context.TodoItems.Max(x => x.Rank);
                    highestRank = highestRankNullable ?? 0; // Providing 0 as a default value if highestRankNullable is null
                }
            }

            return highestRank;
        }
    }
}
