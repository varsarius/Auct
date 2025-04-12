// Models/TaskItem.cs
using System.ComponentModel.DataAnnotations;

namespace auct.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }= string.Empty;
    }
}
