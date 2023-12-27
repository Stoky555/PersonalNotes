using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalNotesV2.Shared.Models.Todo;

namespace PersonalNotesV2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TodoItem>().HasData(
                new TodoItem { Id = Guid.NewGuid(), CreatedDate =  DateTime.Now, Description = "TestData1", DueDate = DateTime.Now.AddDays(1), Priority = Models.Todo.Enums.TodoItemPriority.Low, Rank = 1, Status = Models.Todo.Enums.TodoItemStatus.New, Title = "TestData1" },
                new TodoItem { Id = Guid.NewGuid(), CreatedDate =  DateTime.Now, Description = "TestData2", DueDate = DateTime.Now.AddDays(2), Priority = Models.Todo.Enums.TodoItemPriority.Medium, Rank = 2, Status = Models.Todo.Enums.TodoItemStatus.New, Title = "TestData2" },
                new TodoItem { Id = Guid.NewGuid(), CreatedDate =  DateTime.Now, Description = "TestData3", DueDate = DateTime.Now.AddDays(3), Priority = Models.Todo.Enums.TodoItemPriority.High, Rank = 3, Status = Models.Todo.Enums.TodoItemStatus.New, Title = "TestData3" }
                );
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
