using System.ComponentModel.DataAnnotations;

namespace TAREALABO;

public class ToDoItemDTO
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int UserId { get; set; }
}
