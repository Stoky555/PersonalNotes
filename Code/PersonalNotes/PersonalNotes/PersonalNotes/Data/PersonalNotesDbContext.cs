using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PersonalNotes.Models.Todo;
using PersonalNotes.Models.Todo.Enums;

namespace PersonalNotes.Data
{
    public class PersonalNotesDbContext : DbContext
    {
        public PersonalNotesDbContext(DbContextOptions<PersonalNotesDbContext> options) 
            : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
