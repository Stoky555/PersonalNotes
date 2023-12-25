using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalNotesV2.Shared.Models.Todo;

namespace PersonalNotesV2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    { 

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
