using Microsoft.AspNetCore.Mvc;

namespace TAREALABO;

[Route("api/[controller]")]
[ApiController]
public class ToDoItemController : ControllerBase
{
    private readonly IToDoItemService _toDoItemService;
    public ToDoItemController(IToDoItemService toDoItemService)
    {
        _toDoItemService = toDoItemService;
    }

    [HttpGet("getAllToDoItems")]
    public IActionResult GetAllToDoItems()
    {
        return Ok(_toDoItemService.GetToDoItems());
    }
    [HttpGet("getToDoItemById/{id}")]
    public IActionResult GetToDoItemById(int id)
    {
        return Ok(_toDoItemService.GetToDoItemById(id));
    }
    [HttpPost("addToDoItem")]
    public IActionResult AddToDoItem([FromBody] ToDoItemDTO toDoItemDTO)
    {
        _toDoItemService.AddToDoItem(toDoItemDTO);
        return StatusCode(201);
    }
    [HttpDelete("deleteToDoItem/{id}")]
    public IActionResult DeleteToDoItem(int id)
    {
        _toDoItemService.DeleteToDoItem(id);
        return NoContent();
    }
}
