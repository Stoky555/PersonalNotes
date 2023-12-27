using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalNotesV2.Shared.Models.Blog;
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

            builder.Entity<BlogPost>().HasData(
            new BlogPost { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Description = "TestData1Blog", Title = "TestData1Blog", Author = "Stoky", Text = "testest1", Images = null},
            new BlogPost { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Description = "TestData2Blog", Title = "TestData2Blog", Author = "Stoky", Text = "testest2", Images = null},
            new BlogPost { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Description = "TestData3Blog", Title = "TestData3Blog", Author = "Stoky", Text = "testest3", Images = null}
                );
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
