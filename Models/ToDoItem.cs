using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TAREALABO;

public class ToDoItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ToDoId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
    public int UserId { get; set; }

}
