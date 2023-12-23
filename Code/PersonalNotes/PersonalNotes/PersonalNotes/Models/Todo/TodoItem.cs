using PersonalNotes.Models.Todo.Enums;
using System.ComponentModel.DataAnnotations;

namespace PersonalNotes.Models.Todo
{
    public class TodoItem
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime DueDate { get; set; } = DateTime.Now;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }

        public TodoItemStatus Status { get; set; } = TodoItemStatus.New;

        public TodoItemPriority Priority { get; set; } = TodoItemPriority.None;

        public int Rank { get; set; }
    }
}
